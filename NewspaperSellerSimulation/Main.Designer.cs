namespace NewspaperSellerSimulation
{
    partial class Main
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
            this.Run_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tst_cs_cmb = new System.Windows.Forms.ComboBox();
            this.day_type_dvg = new System.Windows.Forms.DataGridView();
            this.dayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.demand_dvg = new System.Windows.Forms.DataGridView();
            this.demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.good = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fairRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poorRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_nwppr_tb = new System.Windows.Forms.TextBox();
            this.no_rcd_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scrp_prc_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pur_prc_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sll_prc_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.day_type_dvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demand_dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // Run_btn
            // 
            this.Run_btn.Enabled = false;
            this.Run_btn.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run_btn.Location = new System.Drawing.Point(12, 12);
            this.Run_btn.Name = "Run_btn";
            this.Run_btn.Size = new System.Drawing.Size(222, 52);
            this.Run_btn.TabIndex = 0;
            this.Run_btn.Text = "RUN";
            this.Run_btn.UseVisualStyleBackColor = true;
            this.Run_btn.Click += new System.EventHandler(this.Run_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test Case";
            // 
            // tst_cs_cmb
            // 
            this.tst_cs_cmb.FormattingEnabled = true;
            this.tst_cs_cmb.Items.AddRange(new object[] {
            "TestCase1",
            "TestCase2",
            "TestCase3"});
            this.tst_cs_cmb.Location = new System.Drawing.Point(344, 27);
            this.tst_cs_cmb.Name = "tst_cs_cmb";
            this.tst_cs_cmb.Size = new System.Drawing.Size(426, 24);
            this.tst_cs_cmb.TabIndex = 2;
            this.tst_cs_cmb.SelectedIndexChanged += new System.EventHandler(this.tst_cs_cmb_SelectedIndexChanged);
            // 
            // day_type_dvg
            // 
            this.day_type_dvg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.day_type_dvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.day_type_dvg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.day_type_dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.day_type_dvg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayType,
            this.Prob,
            this.Cumm,
            this.min,
            this.max});
            this.day_type_dvg.Location = new System.Drawing.Point(23, 207);
            this.day_type_dvg.Name = "day_type_dvg";
            this.day_type_dvg.ReadOnly = true;
            this.day_type_dvg.RowHeadersWidth = 51;
            this.day_type_dvg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.day_type_dvg.Size = new System.Drawing.Size(738, 118);
            this.day_type_dvg.TabIndex = 3;
            // 
            // dayType
            // 
            this.dayType.HeaderText = "Type of Newsday";
            this.dayType.MinimumWidth = 6;
            this.dayType.Name = "dayType";
            this.dayType.ReadOnly = true;
            this.dayType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Prob
            // 
            this.Prob.HeaderText = "Probability";
            this.Prob.MinimumWidth = 6;
            this.Prob.Name = "Prob";
            this.Prob.ReadOnly = true;
            this.Prob.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cumm
            // 
            this.Cumm.HeaderText = "Cumulative Probability";
            this.Cumm.MinimumWidth = 6;
            this.Cumm.Name = "Cumm";
            this.Cumm.ReadOnly = true;
            this.Cumm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // min
            // 
            this.min.HeaderText = "Min Range";
            this.min.MinimumWidth = 6;
            this.min.Name = "min";
            this.min.ReadOnly = true;
            this.min.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // max
            // 
            this.max.HeaderText = "Max Range";
            this.max.MinimumWidth = 6;
            this.max.Name = "max";
            this.max.ReadOnly = true;
            this.max.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Newspapers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Day Type Distribution";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Demand Distribution";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // demand_dvg
            // 
            this.demand_dvg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.demand_dvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.demand_dvg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.demand_dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.demand_dvg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.demand,
            this.good,
            this.fair,
            this.poor,
            this.goodRange,
            this.fairRange,
            this.poorRange});
            this.demand_dvg.Location = new System.Drawing.Point(23, 373);
            this.demand_dvg.Name = "demand_dvg";
            this.demand_dvg.ReadOnly = true;
            this.demand_dvg.RowHeadersWidth = 51;
            this.demand_dvg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.demand_dvg.Size = new System.Drawing.Size(738, 216);
            this.demand_dvg.TabIndex = 13;
            this.demand_dvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.demand_dvg_CellContentClick);
            // 
            // demand
            // 
            this.demand.HeaderText = "Demand";
            this.demand.MinimumWidth = 6;
            this.demand.Name = "demand";
            this.demand.ReadOnly = true;
            // 
            // good
            // 
            this.good.HeaderText = "Good";
            this.good.MinimumWidth = 6;
            this.good.Name = "good";
            this.good.ReadOnly = true;
            // 
            // fair
            // 
            this.fair.HeaderText = "Fair";
            this.fair.MinimumWidth = 6;
            this.fair.Name = "fair";
            this.fair.ReadOnly = true;
            // 
            // poor
            // 
            this.poor.HeaderText = "Poor";
            this.poor.MinimumWidth = 6;
            this.poor.Name = "poor";
            this.poor.ReadOnly = true;
            // 
            // goodRange
            // 
            this.goodRange.HeaderText = "Good Range";
            this.goodRange.MinimumWidth = 6;
            this.goodRange.Name = "goodRange";
            this.goodRange.ReadOnly = true;
            // 
            // fairRange
            // 
            this.fairRange.HeaderText = "Fair Range";
            this.fairRange.MinimumWidth = 6;
            this.fairRange.Name = "fairRange";
            this.fairRange.ReadOnly = true;
            // 
            // poorRange
            // 
            this.poorRange.HeaderText = "Poor Range";
            this.poorRange.MinimumWidth = 6;
            this.poorRange.Name = "poorRange";
            this.poorRange.ReadOnly = true;
            // 
            // no_nwppr_tb
            // 
            this.no_nwppr_tb.Location = new System.Drawing.Point(167, 82);
            this.no_nwppr_tb.Name = "no_nwppr_tb";
            this.no_nwppr_tb.ReadOnly = true;
            this.no_nwppr_tb.Size = new System.Drawing.Size(146, 22);
            this.no_nwppr_tb.TabIndex = 18;
            // 
            // no_rcd_tb
            // 
            this.no_rcd_tb.Location = new System.Drawing.Point(577, 82);
            this.no_rcd_tb.Name = "no_rcd_tb";
            this.no_rcd_tb.ReadOnly = true;
            this.no_rcd_tb.Size = new System.Drawing.Size(170, 22);
            this.no_rcd_tb.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Number of Records";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrp_prc_tb
            // 
            this.scrp_prc_tb.Location = new System.Drawing.Point(613, 142);
            this.scrp_prc_tb.Name = "scrp_prc_tb";
            this.scrp_prc_tb.ReadOnly = true;
            this.scrp_prc_tb.Size = new System.Drawing.Size(148, 22);
            this.scrp_prc_tb.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Scrap Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pur_prc_tb
            // 
            this.pur_prc_tb.Location = new System.Drawing.Point(318, 142);
            this.pur_prc_tb.Name = "pur_prc_tb";
            this.pur_prc_tb.ReadOnly = true;
            this.pur_prc_tb.Size = new System.Drawing.Size(141, 22);
            this.pur_prc_tb.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Purchase Price";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sll_prc_tb
            // 
            this.sll_prc_tb.Location = new System.Drawing.Point(15, 142);
            this.sll_prc_tb.Name = "sll_prc_tb";
            this.sll_prc_tb.ReadOnly = true;
            this.sll_prc_tb.Size = new System.Drawing.Size(148, 22);
            this.sll_prc_tb.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Selling Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 604);
            this.Controls.Add(this.sll_prc_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pur_prc_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.scrp_prc_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.no_rcd_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.no_nwppr_tb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.demand_dvg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.day_type_dvg);
            this.Controls.Add(this.tst_cs_cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Run_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "TEAM 28";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.day_type_dvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demand_dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Run_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tst_cs_cmb;
        private System.Windows.Forms.DataGridView day_type_dvg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView demand_dvg;
        private System.Windows.Forms.TextBox no_nwppr_tb;
        private System.Windows.Forms.TextBox no_rcd_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scrp_prc_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pur_prc_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sll_prc_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn good;
        private System.Windows.Forms.DataGridViewTextBoxColumn fair;
        private System.Windows.Forms.DataGridViewTextBoxColumn poor;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn fairRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn poorRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn min;
        private System.Windows.Forms.DataGridViewTextBoxColumn max;
    }
}
