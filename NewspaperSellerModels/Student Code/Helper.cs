using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels.Student_Code
{
    public class Helper
    {
        public static void printer(SimulationSystem simulationSystem)
        {
            Console.WriteLine("Number of News Papers : " + simulationSystem.NumOfNewspapers);
            Console.WriteLine("Number of Records : " + simulationSystem.NumOfRecords);
            Console.WriteLine("Purchase price : " + simulationSystem.PurchasePrice);
            Console.WriteLine("Scrap price : " + simulationSystem.ScrapPrice);
            Console.WriteLine("Selling price : " + simulationSystem.SellingPrice);
            Console.WriteLine("Unit profit : " + simulationSystem.UnitProfit);
            foreach (DayTypeDistribution day in simulationSystem.DayTypeDistributions)
            {
                Console.WriteLine(day.DayType + " " + day.Probability + " " + day.CummProbability + " " + day.MinRange + " " + day.MaxRange);
            }
            foreach (DemandDistribution deman in simulationSystem.DemandDistributions)
            {
                Console.WriteLine("Demand : " + deman.Demand);
                foreach (DayTypeDistribution day in deman.DayTypeDistributions)
                {
                    Console.Write(day.DayType + " " + day.Probability + " " + day.CummProbability + " " + day.MinRange + " " + day.MaxRange + " ");
                }
                Console.WriteLine();
            }
        }
        public static void casePrinter(SimulationCase cs)
        {
            Console.WriteLine(cs.DayNo + " " + cs.RandomNewsDayType + " " + cs.NewsDayType + " " + cs.RandomDemand + " " + cs.Demand + " " + cs.DailyCost
                + " " + cs.SalesProfit + " " + cs.LostProfit + " " + cs.ScrapProfit + " " + cs.DailyNetProfit);
        }
    }
}
