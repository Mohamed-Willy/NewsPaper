using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class FileReader
    {
        public static SimulationSystem fileReader(string testCase)
        {
            SimulationSystem simulationSystem = new SimulationSystem();
            FileStream file = new FileStream("..\\..\\TestCases\\" + testCase + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            //Read all file Lines
            List<string> lines = new List<string>();
            while (!reader.EndOfStream)
                lines.Add(reader.ReadLine());

            //Access first Inputs
            simulationSystem.NumOfNewspapers = int.Parse(lines[1]);
            simulationSystem.NumOfRecords = int.Parse(lines[4]);
            simulationSystem.PurchasePrice = decimal.Parse(lines[7]);
            simulationSystem.ScrapPrice = decimal.Parse(lines[10]);
            simulationSystem.SellingPrice = decimal.Parse(lines[13]);
            simulationSystem.UnitProfit = simulationSystem.SellingPrice - simulationSystem.PurchasePrice;
            string[] daystring = lines[16].Split(',');

            // Good = 0, Fair = 1, Poor = 2 (Day Distribution)
            for (int i = 0; i < 3; i++)
            {
                DayTypeDistribution day = new DayTypeDistribution();
                day.Probability = decimal.Parse(daystring[i]);
                if (i == 0)
                {
                    day.DayType = Enums.DayType.Good;
                    day.CummProbability = day.Probability;
                    day.MinRange = 1;
                }
                if (i == 1)
                {
                    day.DayType = Enums.DayType.Fair;
                    day.CummProbability = day.Probability + simulationSystem.DayTypeDistributions[0].CummProbability;
                    day.MinRange = simulationSystem.DayTypeDistributions[0].MaxRange + 1;
                }
                if (i == 2)
                {
                    day.DayType = Enums.DayType.Poor;
                    day.CummProbability = 1;
                    day.MinRange = simulationSystem.DayTypeDistributions[1].MaxRange + 1;
                }
                day.MaxRange = (int)(day.CummProbability * 100);
                simulationSystem.DayTypeDistributions.Add(day);
            }
            // Demand Distribution
            for (int i = 0; i < lines.Count - 19; i++)
            {
                DemandDistribution dist = new DemandDistribution();
                daystring = lines[i + 19].Split(',');
                for (int ii = 0; ii < 4; ii++)
                {
                    DayTypeDistribution day = new DayTypeDistribution();
                    if (ii == 0)
                        dist.Demand = int.Parse(daystring[ii]);
                    else
                    {
                        // Good = 1, Fair = 2, Poor = 3
                        day.Probability = decimal.Parse(daystring[ii]);
                        
                        if (ii == 1)
                            day.DayType = Enums.DayType.Good;
                        if (ii == 2)
                            day.DayType = Enums.DayType.Fair;
                        if (ii == 3)
                            day.DayType = Enums.DayType.Poor;
                        // Commulative = prop[i] + cumm[i-1]
                        if (i == 0)
                        {
                            day.CummProbability = day.Probability;
                            day.MinRange = 1;
                        }
                        else
                        {
                            day.CummProbability = day.Probability + simulationSystem.DemandDistributions[i - 1].DayTypeDistributions[ii - 1].CummProbability;
                            day.MinRange = simulationSystem.DemandDistributions[i - 1].DayTypeDistributions[ii - 1].MaxRange + 1;
                        }

                        day.MaxRange = (int)(day.CummProbability * 100);

                        dist.DayTypeDistributions.Add(day);
                    }
                }
                simulationSystem.DemandDistributions.Add(dist);
            }
            return simulationSystem;
        }
    }
}
