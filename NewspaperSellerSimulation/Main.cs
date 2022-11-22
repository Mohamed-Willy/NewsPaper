using NewspaperSellerModels;
using NewspaperSellerModels.Student_Code;
using NewspaperSellerTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperSellerSimulation
{
    public partial class Main : Form
    {
        SimulationSystem simulationSystem;
        int idx;
        String[] testcases = {
                Constants.FileNames.TestCase1,
                Constants.FileNames.TestCase2,
                Constants.FileNames.TestCase3,
                Constants.FileNames.TestCase4,
                Constants.FileNames.TestCase5,
                Constants.FileNames.TestCase6,
                Constants.FileNames.TestCase7,
                Constants.FileNames.TestCase8,
                Constants.FileNames.TestCase9,
                Constants.FileNames.TestCase10
        };
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            

        }
        private void tst_cs_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            idx = tst_cs_cmb.SelectedIndex;
            simulationSystem = FileReader.fileReader(tst_cs_cmb.Items[idx].ToString());
            day_type_dvg.Rows.Clear();
            demand_dvg.Rows.Clear();
            no_nwppr_tb.Text = simulationSystem.NumOfNewspapers.ToString();
            no_rcd_tb.Text = simulationSystem.NumOfRecords.ToString();
            pur_prc_tb.Text = simulationSystem.PurchasePrice.ToString();
            scrp_prc_tb.Text = simulationSystem.ScrapPrice.ToString();
            sll_prc_tb.Text = simulationSystem.SellingPrice.ToString();

            foreach (DayTypeDistribution dist in simulationSystem.DayTypeDistributions)
            {
                day_type_dvg.Rows.Add(
                    dist.DayType,
                    dist.Probability,
                    dist.CummProbability,
                    dist.MinRange,
                    dist.MaxRange
                );
            }
            foreach (DemandDistribution dist in simulationSystem.DemandDistributions)
            {
                demand_dvg.Rows.Add(
                    dist.Demand,
                    dist.DayTypeDistributions[0].CummProbability,
                    dist.DayTypeDistributions[1].CummProbability,
                    dist.DayTypeDistributions[2].CummProbability,
                    dist.DayTypeDistributions[0].MinRange > 100 ? "------" : dist.DayTypeDistributions[0].MinRange + " - " +  dist.DayTypeDistributions[0].MaxRange,
                    dist.DayTypeDistributions[1].MinRange > 100 ? "------" : dist.DayTypeDistributions[1].MinRange + " - " +  dist.DayTypeDistributions[1].MaxRange,
                    dist.DayTypeDistributions[2].MinRange > 100 ? "------" : dist.DayTypeDistributions[2].MinRange + " - " +  dist.DayTypeDistributions[2].MaxRange
                );
            }
            Run_btn.Enabled = true;
        }
        private void Run_btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            TableMaker.createSimTable(rnd, simulationSystem);
            string result = TestingManager.Test(simulationSystem, testcases[idx]);
            MessageBox.Show(result);
            SimulationTable simulationTable = new SimulationTable{table = simulationSystem.SimulationTable};
            simulationTable.Show();
        }
        private void demand_dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
