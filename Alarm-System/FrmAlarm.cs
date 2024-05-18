using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_System
{
    public partial class FrmAlarm : Form
    {
        public FrmAlarm()
        {
            InitializeComponent();
        }

        private void dgvAlarms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Column: "+e.ColumnIndex.ToString()+ " \nRow: "+e.ColumnIndex.ToString());
        }
    }
}
