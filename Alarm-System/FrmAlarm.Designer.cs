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
            this.dgvAlarms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarms)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlarms
            // 
            this.dgvAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlarms.Location = new System.Drawing.Point(142, 91);
            this.dgvAlarms.Name = "dgvAlarms";
            this.dgvAlarms.RowHeadersWidth = 51;
            this.dgvAlarms.RowTemplate.Height = 24;
            this.dgvAlarms.Size = new System.Drawing.Size(1144, 657);
            this.dgvAlarms.TabIndex = 0;
            this.dgvAlarms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlarms_CellDoubleClick);
            // 
            // FrmAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 778);
            this.Controls.Add(this.dgvAlarms);
            this.Name = "FrmAlarm";
            this.Text = "Alarm monitoring";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlarms;
    }
}

