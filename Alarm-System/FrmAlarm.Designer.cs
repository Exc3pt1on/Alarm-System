namespace Alarm_System
{
    partial class FrmAlarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvAlarms = new System.Windows.Forms.DataGridView();
            this.flpSystem = new System.Windows.Forms.FlowLayoutPanel();
            this.chartAlarms = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblAlarms = new System.Windows.Forms.Label();
            this.lblChart = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panAlarmMode = new System.Windows.Forms.Panel();
            this.rBtnAll = new System.Windows.Forms.RadioButton();
            this.rBtnActive = new System.Windows.Forms.RadioButton();
            this.lblAlarmMode = new System.Windows.Forms.Label();
            this.btnAcknowledge = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAlarms)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panAlarmMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlarms
            // 
            this.dgvAlarms.AllowUserToAddRows = false;
            this.dgvAlarms.AllowUserToDeleteRows = false;
            this.dgvAlarms.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlarms.Location = new System.Drawing.Point(251, 141);
            this.dgvAlarms.Name = "dgvAlarms";
            this.dgvAlarms.ReadOnly = true;
            this.dgvAlarms.RowHeadersWidth = 51;
            this.dgvAlarms.RowTemplate.Height = 24;
            this.dgvAlarms.Size = new System.Drawing.Size(954, 657);
            this.dgvAlarms.TabIndex = 0;
            this.dgvAlarms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlarms_CellClick);
            this.dgvAlarms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlarms_CellDoubleClick);
            // 
            // flpSystem
            // 
            this.flpSystem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flpSystem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flpSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSystem.Location = new System.Drawing.Point(45, 280);
            this.flpSystem.Name = "flpSystem";
            this.flpSystem.Size = new System.Drawing.Size(200, 518);
            this.flpSystem.TabIndex = 1;
            // 
            // chartAlarms
            // 
            this.chartAlarms.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chartAlarms.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartAlarms.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAlarms.Legends.Add(legend1);
            this.chartAlarms.Location = new System.Drawing.Point(1211, 141);
            this.chartAlarms.Name = "chartAlarms";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAlarms.Series.Add(series1);
            this.chartAlarms.Size = new System.Drawing.Size(798, 657);
            this.chartAlarms.TabIndex = 2;
            this.chartAlarms.Text = "chart1";
            // 
            // lblSystem
            // 
            this.lblSystem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSystem.AutoSize = true;
            this.lblSystem.Location = new System.Drawing.Point(42, 261);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(52, 16);
            this.lblSystem.TabIndex = 3;
            this.lblSystem.Text = "System";
            // 
            // lblAlarms
            // 
            this.lblAlarms.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAlarms.AutoSize = true;
            this.lblAlarms.Location = new System.Drawing.Point(248, 119);
            this.lblAlarms.Name = "lblAlarms";
            this.lblAlarms.Size = new System.Drawing.Size(49, 16);
            this.lblAlarms.TabIndex = 4;
            this.lblAlarms.Text = "Alarms";
            // 
            // lblChart
            // 
            this.lblChart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChart.AutoSize = true;
            this.lblChart.Location = new System.Drawing.Point(1208, 119);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(163, 16);
            this.lblChart.TabIndex = 5;
            this.lblChart.Text = "System before trigger time";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHeader.Location = new System.Drawing.Point(917, 40);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(158, 25);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Alarm monitoring";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.signOutToolStripMenuItem.Text = "Sign out";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panAlarmMode
            // 
            this.panAlarmMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panAlarmMode.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panAlarmMode.Controls.Add(this.rBtnAll);
            this.panAlarmMode.Controls.Add(this.rBtnActive);
            this.panAlarmMode.Location = new System.Drawing.Point(45, 141);
            this.panAlarmMode.Name = "panAlarmMode";
            this.panAlarmMode.Size = new System.Drawing.Size(200, 104);
            this.panAlarmMode.TabIndex = 8;
            // 
            // rBtnAll
            // 
            this.rBtnAll.AutoSize = true;
            this.rBtnAll.Location = new System.Drawing.Point(30, 59);
            this.rBtnAll.Name = "rBtnAll";
            this.rBtnAll.Size = new System.Drawing.Size(119, 20);
            this.rBtnAll.TabIndex = 11;
            this.rBtnAll.TabStop = true;
            this.rBtnAll.Text = "Show all alarms";
            this.rBtnAll.UseVisualStyleBackColor = true;
            this.rBtnAll.CheckedChanged += new System.EventHandler(this.rBtnAll_CheckedChanged);
            // 
            // rBtnActive
            // 
            this.rBtnActive.AutoSize = true;
            this.rBtnActive.Checked = true;
            this.rBtnActive.Enabled = false;
            this.rBtnActive.Location = new System.Drawing.Point(30, 19);
            this.rBtnActive.Name = "rBtnActive";
            this.rBtnActive.Size = new System.Drawing.Size(141, 20);
            this.rBtnActive.TabIndex = 10;
            this.rBtnActive.TabStop = true;
            this.rBtnActive.Text = "Show active alarms";
            this.rBtnActive.UseVisualStyleBackColor = true;
            this.rBtnActive.CheckedChanged += new System.EventHandler(this.rBtnActive_CheckedChanged);
            // 
            // lblAlarmMode
            // 
            this.lblAlarmMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAlarmMode.AutoSize = true;
            this.lblAlarmMode.Location = new System.Drawing.Point(42, 119);
            this.lblAlarmMode.Name = "lblAlarmMode";
            this.lblAlarmMode.Size = new System.Drawing.Size(80, 16);
            this.lblAlarmMode.TabIndex = 9;
            this.lblAlarmMode.Text = "Alarm Mode";
            // 
            // btnAcknowledge
            // 
            this.btnAcknowledge.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAcknowledge.BackColor = System.Drawing.SystemColors.Control;
            this.btnAcknowledge.Location = new System.Drawing.Point(732, 804);
            this.btnAcknowledge.Name = "btnAcknowledge";
            this.btnAcknowledge.Size = new System.Drawing.Size(234, 54);
            this.btnAcknowledge.TabIndex = 10;
            this.btnAcknowledge.Text = "Acknowledge alarm";
            this.btnAcknowledge.UseVisualStyleBackColor = false;
            this.btnAcknowledge.Click += new System.EventHandler(this.btnAcknowledge_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReset.Location = new System.Drawing.Point(972, 804);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(234, 54);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset alarm";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1678, 810);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(234, 54);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1924, 876);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAcknowledge);
            this.Controls.Add(this.lblAlarmMode);
            this.Controls.Add(this.panAlarmMode);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblChart);
            this.Controls.Add(this.lblAlarms);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.chartAlarms);
            this.Controls.Add(this.flpSystem);
            this.Controls.Add(this.dgvAlarms);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAlarm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAlarms)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panAlarmMode.ResumeLayout(false);
            this.panAlarmMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlarms;
        private System.Windows.Forms.FlowLayoutPanel flpSystem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAlarms;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblAlarms;
        private System.Windows.Forms.Label lblChart;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Panel panAlarmMode;
        private System.Windows.Forms.Label lblAlarmMode;
        private System.Windows.Forms.RadioButton rBtnActive;
        private System.Windows.Forms.RadioButton rBtnAll;
        private System.Windows.Forms.Button btnAcknowledge;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
    }
}

