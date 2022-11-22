using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }// Done
        public int NumOfRecords { get; set; }// Done
        public decimal PurchasePrice { get; set; }// Done
        public decimal SellingPrice { get; set; }// Done
        public decimal ScrapPrice { get; set; }// Done
        public decimal UnitProfit { get; set; }// Done
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }// Done
        public List<DemandDistribution> DemandDistributions { get; set; }// Done

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }// Done
        public PerformanceMeasures PerformanceMeasures { get; set; }// Done
    }
}
