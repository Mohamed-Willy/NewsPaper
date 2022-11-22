using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels.Student_Code
{
    public class TableMaker
    {
        public static void createSimTable(Random rnd, SimulationSystem simulationSystem)
        {
            // Looping on Days (Records)
            for (int i = 0; i < simulationSystem.NumOfRecords; i++)
            {
                // Intialize Day number and random values
                SimulationCase simCase = new SimulationCase
                {
                    DayNo = i + 1,
                    RandomNewsDayType = (rnd.Next() % 100) + 1,
                    RandomDemand = (rnd.Next() % 100) + 1
                };
                
                // Set Daytype Within Distributions Range
                for (int ii = 0; ii < 3; ii++)
                    if ((simCase.RandomNewsDayType >= simulationSystem.DayTypeDistributions[ii].MinRange) &&
                        (simCase.RandomNewsDayType <= simulationSystem.DayTypeDistributions[ii].MaxRange))
                    {
                        simCase.NewsDayType = simulationSystem.DayTypeDistributions[ii].DayType;
                        break;
                    }
                
                // Set Demand within Demands Distributions
                foreach (DemandDistribution deman in simulationSystem.DemandDistributions)
                {
                    // Good Day Range
                    if (simCase.NewsDayType == Enums.DayType.Good)
                    {
                        if ((simCase.RandomDemand >= deman.DayTypeDistributions[0].MinRange) &&
                           (simCase.RandomDemand <= deman.DayTypeDistributions[0].MaxRange))
                        {
                            simCase.Demand = deman.Demand;
                        }
                    }
                    // Fair Day Range
                    else if (simCase.NewsDayType == Enums.DayType.Fair)
                    {
                        if ((simCase.RandomDemand >= deman.DayTypeDistributions[1].MinRange) &&
                          (simCase.RandomDemand <= deman.DayTypeDistributions[1].MaxRange))
                        {
                            simCase.Demand = deman.Demand;
                        }
                    }
                    // Poor Day Range
                    else
                    {
                        if ((simCase.RandomDemand >= deman.DayTypeDistributions[2].MinRange) &&
                          (simCase.RandomDemand <= deman.DayTypeDistributions[2].MaxRange))
                        {
                            simCase.Demand = deman.Demand;
                        }
                    }
                }

                // Cost = Number of newspapers * Cost of each newspaper
                simCase.DailyCost = simulationSystem.NumOfNewspapers * simulationSystem.PurchasePrice;
                simulationSystem.PerformanceMeasures.TotalCost = simCase.DailyCost * simulationSystem.NumOfRecords;

                // Profit = Number of sold newspapers * Selling price
                simCase.SalesProfit = simCase.Demand < simulationSystem.NumOfNewspapers ? simCase.Demand * simulationSystem.SellingPrice :
                    simulationSystem.NumOfNewspapers * simulationSystem.SellingPrice;
                simulationSystem.PerformanceMeasures.TotalSalesProfit += simCase.SalesProfit;

                // Lost Profit = Extra news papers wanted * Profit of selling a newspaper
                simCase.LostProfit = simCase.Demand < simulationSystem.NumOfNewspapers ? 0 :
                    (simCase.Demand - simulationSystem.NumOfNewspapers) * simulationSystem.UnitProfit;
                simulationSystem.PerformanceMeasures.TotalLostProfit += simCase.LostProfit;

                // Scrap Profit = Leftovers newspapers * Scrap price
                simCase.ScrapProfit = simCase.Demand >= simulationSystem.NumOfNewspapers ? 0 :
                    (simulationSystem.NumOfNewspapers - simCase.Demand) * simulationSystem.ScrapPrice;
                simulationSystem.PerformanceMeasures.TotalScrapProfit += simCase.ScrapProfit;

                // Daily Net = Sales Profit + Scrap Profit - Daily Cost - Lost Profit
                simCase.DailyNetProfit = simCase.SalesProfit + simCase.ScrapProfit - simCase.DailyCost - simCase.LostProfit;
                simulationSystem.PerformanceMeasures.TotalNetProfit += simCase.DailyNetProfit;

                // Updating Days with Extra and less sold papers (Demand != Number of newspapers)
                if (simCase.LostProfit > 0) simulationSystem.PerformanceMeasures.DaysWithMoreDemand++;
                else if (simCase.ScrapProfit > 0) simulationSystem.PerformanceMeasures.DaysWithUnsoldPapers++;

                // casePrinter(simCase);
                simulationSystem.SimulationTable.Add(simCase);
            }
        }
    }
}
