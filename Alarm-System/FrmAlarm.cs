﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Alarm_System
{
    public partial class FrmAlarm : Form
    {
        private string Username;
        private bool ShowAll = false;
        private int SelectedAlarmId = 0;
        private int SelectedRow = 0;
        private string SelectedSystem;
        private DataTable CurrentDt = null;
        public FrmAlarm(string username)
        {
            InitializeComponent();
            Username = username;
            UpdateSystemsList();
        }

        private DataTable GetDataFromDatabase(string query)
        {
            // Get data from database

            string connectionString = ConfigurationManager.ConnectionStrings["ScadaDB"].ConnectionString;
            SqlDataAdapter sda;
            DataTable dt;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                dt = new DataTable();
                try
                {
                    connection.Open();

                    sda = new SqlDataAdapter(query, connection);
                    sda.Fill(dt);
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error occurred: " + e.Message);
                }
                return dt;
            }
        }
        private void UpdateSystemsList()
        {
            string query;
            query = $"SELECT Name FROM View_SystemName WHERE Username = '{Username}'";
            DataTable dt = GetDataFromDatabase(query);
            foreach (DataRow row in dt.Rows)
            {
                Button button = new Button();
                string btnName = row[0].ToString();
                button.Text = btnName;
                button.BackColor = Color.White;
                button.Width = flpSystem.Width - 10;
                button.Click += (sender, e) =>
                    {
                        UpdateAlarmList(btnName);
                        SelectedSystem = btnName;
                    };
                flpSystem.Controls.Add(button);
            }
            SelectedSystem = dt.Rows[0][0].ToString();
            UpdateAlarmList(SelectedSystem);
        }

        private void UpdateAlarmParameters(string status, int id)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["ScadaDB"].ConnectionString;

            string query = "UPDATE Alarm SET Status = @NewStatus WHERE AlarmId = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NewStatus", status);
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    connection.Open();

                    int affected = command.ExecuteNonQuery();
                    if (affected > 0)
                    {
                        MessageBox.Show("Alarm successfully updated");
                    }
                    else
                    {
                        MessageBox.Show("No alarms were updated");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error updating status");
                }

            }
        }

        private void UpdateAlarmList(string system)
        {
            string query;
            bool sameAsPrevious = false;
            if (ShowAll)
            {
                query = $"SELECT * FROM View_AlarmBySystemName WHERE Name = '{system}'";

            }
            else
            {
                query = $"SELECT * FROM View_AlarmBySystemName WHERE Name = '{system}' AND Status != 'Inactive'";
            }
            DataTable dt = GetDataFromDatabase(query);
            if (CurrentDt == null) { sameAsPrevious = false; }
            else if (dt.Rows.Count == CurrentDt.Rows.Count && dt.Columns.Count == CurrentDt.Columns.Count)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (dt.Rows[i][j].Equals(CurrentDt.Rows[i][j]))
                        {
                            sameAsPrevious = true;
                        }
                    }
                }
            }


            if (sameAsPrevious == false)
            {
                try
                {
                    CurrentDt = dt;
                    dgvAlarms.DataSource = dt;
                    dgvAlarms.Rows[0].Selected = true;
                    for (int i = 0; i < dgvAlarms.RowCount; i++)
                    {
                        switch (Convert.ToInt64(dgvAlarms.Rows[i].Cells[3].Value))
                        {
                            case 1:
                                dgvAlarms.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                break;
                            case 2:
                                dgvAlarms.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                break;
                            case 3:
                                dgvAlarms.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                break;
                            default:
                                break;
                        }
                    }
                }
                catch (Exception)
                {

                }

            }

        }
        private void dgvAlarms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Column: " + e.ColumnIndex.ToString() + " \nRow: " + e.RowIndex.ToString());
        }

        private void rBtnActive_CheckedChanged(object sender, EventArgs e)
        {
            rBtnActive.Enabled = false;
            rBtnAll.Enabled = true;
            ShowAll = false;

            UpdateAlarmList(SelectedSystem);
        }

        private void rBtnAll_CheckedChanged(object sender, EventArgs e)
        {
            rBtnActive.Enabled = true;
            rBtnAll.Enabled = false;
            ShowAll = true;

            UpdateAlarmList(SelectedSystem);
        }

        private void dgvAlarms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvAlarms.Rows[e.RowIndex].Selected = true;

                var cellValue = dgvAlarms.Rows[e.RowIndex].Cells[6].Value;
                if (cellValue != null)
                {
                    SelectedAlarmId = Convert.ToInt32(cellValue);
                    FillChart(SelectedSystem, "Temp1", 2);
                }
                else
                {
                    MessageBox.Show("The selected cell is empty.");
                }

            }

        }

        private void FillChart(string system, string sensor, int minutesBack)
        {
            string query;
            DateTime dateTimeAlarm, dateTimeAlarmBack;
            SelectedRow = dgvAlarms.SelectedRows[0].Index;

            dateTimeAlarm = Convert.ToDateTime(dgvAlarms.Rows[SelectedRow].Cells["Time"].Value);
            dateTimeAlarmBack = dateTimeAlarm.AddMinutes(-minutesBack);

            //MessageBox.Show(dgvAlarms.Rows[SelectedRow].Cells["Time"].Value.ToString());

            query = $"SELECT Value, Time FROM View_DeviceDataBySystemName WHERE Name_System = '{system}' AND Name_Device = '{sensor}' AND Time< '{dateTimeAlarm.ToString("yyyy-MM-dd HH:mm:ss:fff")}' AND Time > '{dateTimeAlarmBack.ToString("yyyy-MM-dd HH:mm:ss:fff")}'";
            DataTable dt = GetDataFromDatabase(query);

            try
            {
                chartAlarms.Titles.Clear();
                chartAlarms.Series.Clear();
                Series series = new Series();
                series.ChartType = SeriesChartType.Line;
                series.XValueType = ChartValueType.DateTime;

                List<double> values = new List<double>();
                List<string> timestamp = new List<string>();

                foreach (DataRow row in dt.Rows)
                {
                    values.Add(Convert.ToDouble(row["Value"]));
                    timestamp.Add(Convert.ToDateTime(row["Time"]).ToString("HH:mm:ss"));
                }

                for (int i = 0; i < values.Count; i++)
                {
                    series.Points.AddXY(timestamp[i], values[i]); //Timestamp[i]
                }


                chartAlarms.ChartAreas[0].AxisY.Minimum = values.Min() - 5;
                chartAlarms.ChartAreas[0].AxisY.Maximum = values.Max() + 5;


                chartAlarms.Titles.Add("Sensor data from alarm");
                chartAlarms.ChartAreas[0].AxisX.Title = "Time";
                chartAlarms.ChartAreas[0].AxisY.Title = "Temperature °C";
                chartAlarms.Series.Add(series);
                chartAlarms.Refresh();



            }
            catch (Exception)
            {
                
            }

        }

        private void btnAcknowledge_Click(object sender, EventArgs e)
        {
            UpdateAlarmParameters("Acknowledged", SelectedAlarmId);
            UpdateAlarmList(SelectedSystem);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UpdateAlarmParameters("Inactive", SelectedAlarmId);
            UpdateAlarmList(SelectedSystem);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateAlarmList(SelectedSystem);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
