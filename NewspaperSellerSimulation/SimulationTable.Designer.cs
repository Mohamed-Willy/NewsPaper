namespace NewspaperSellerSimulation
{
    partial class SimulationTable
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
            this.output_dv = new System.Windows.Forms.DataGridView();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rvn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daliy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.output_dv)).BeginInit();
            this.SuspendLayout();
            // 
            // output_dv
            // 
            this.output_dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.output_dv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.output_dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.output_dv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.day,
            this.rndDay,
            this.dayType,
            this.rndDemand,
            this.dmnd,
            this.rvn,
            this.lst,
            this.slvg,
            this.daliy});
            this.output_dv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_dv.Location = new System.Drawing.Point(0, 0);
            this.output_dv.Name = "output_dv";
            this.output_dv.ReadOnly = true;
            this.output_dv.RowHeadersWidth = 51;
            this.output_dv.RowTemplate.Height = 24;
            this.output_dv.Size = new System.Drawing.Size(1105, 582);
            this.output_dv.TabIndex = 0;
            // 
            // day
            // 
            this.day.HeaderText = "Day";
            this.day.MinimumWidth = 6;
            this.day.Name = "day";
            this.day.ReadOnly = true;
            // 
            // rndDay
            // 
            this.rndDay.HeaderText = "Random Digits for Day Type";
            this.rndDay.MinimumWidth = 6;
            this.rndDay.Name = "rndDay";
            this.rndDay.ReadOnly = true;
            // 
            // dayType
            // 
            this.dayType.HeaderText = "Day Type";
            this.dayType.MinimumWidth = 6;
            this.dayType.Name = "dayType";
            this.dayType.ReadOnly = true;
            // 
            // rndDemand
            // 
            this.rndDemand.HeaderText = "Random Digits of Demand";
            this.rndDemand.MinimumWidth = 6;
            this.rndDemand.Name = "rndDemand";
            this.rndDemand.ReadOnly = true;
            // 
            // dmnd
            // 
            this.dmnd.HeaderText = "Demand";
            this.dmnd.MinimumWidth = 6;
            this.dmnd.Name = "dmnd";
            this.dmnd.ReadOnly = true;
            // 
            // rvn
            // 
            this.rvn.HeaderText = "Revenue from Sales";
            this.rvn.MinimumWidth = 6;
            this.rvn.Name = "rvn";
            this.rvn.ReadOnly = true;
            // 
            // lst
            // 
            this.lst.HeaderText = "Lost Profit";
            this.lst.MinimumWidth = 6;
            this.lst.Name = "lst";
            this.lst.ReadOnly = true;
            // 
            // slvg
            // 
            this.slvg.HeaderText = "Salvage";
            this.slvg.MinimumWidth = 6;
            this.slvg.Name = "slvg";
            this.slvg.ReadOnly = true;
            // 
            // daliy
            // 
            this.daliy.HeaderText = "Daily Profit";
            this.daliy.MinimumWidth = 6;
            this.daliy.Name = "daliy";
            this.daliy.ReadOnly = true;
            // 
            // SimulationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 582);
            this.Controls.Add(this.output_dv);
            this.Name = "SimulationTable";
            this.Text = "Output";
            this.Load += new System.EventHandler(this.SimulationTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.output_dv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView output_dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn rvn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lst;
        private System.Windows.Forms.DataGridViewTextBoxColumn slvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn daliy;
    }
}