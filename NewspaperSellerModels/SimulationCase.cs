using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationCase
    {
        public int DayNo { get; set; }// Done
        public int RandomNewsDayType { get; set; }// Done
        public Enums.DayType NewsDayType { get; set; }// Done
        public int RandomDemand { get; set; }// Done
        public int Demand { get; set; }// Done
        public decimal DailyCost { get; set; }// Done
        public decimal SalesProfit { get; set; }// Done
        public decimal LostProfit { get; set; }// Done
        public decimal ScrapProfit { get; set; }// Done
        public decimal DailyNetProfit { get; set; }// Done
    }
}
