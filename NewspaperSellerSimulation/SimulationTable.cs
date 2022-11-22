using NewspaperSellerModels;
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
    public partial class SimulationTable : Form
    {
        public List<SimulationCase> table { get; set; }
        public SimulationTable()
        {
            InitializeComponent();
        }

        private void SimulationTable_Load(object sender, EventArgs e)
        {
            foreach (SimulationCase simCase in table)
            {
                output_dv.Rows.Add(
                    simCase.DayNo,
                    simCase.RandomNewsDayType,
                    simCase.NewsDayType,
                    simCase.RandomDemand,
                    simCase.Demand,
                    simCase.SalesProfit,
                    simCase.LostProfit,
                    simCase.ScrapProfit,
                    simCase.DailyNetProfit
                );
            }
        }
    }
}
