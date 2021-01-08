using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace VegaPowerPC
{
    class Vega
    {

        Chromosome[] population;
        static Random rng = new Random();
        string psatSimLocation;
        UInt32 maxIterations;
        UInt32 ipcWeight;
        UInt32 powerWeight;
        double mutateChance;
        double xoverChance;

        private double RandVal()
        {
            return rng.NextDouble();
        }

        /// <summary>
        /// Determines if the event will happen.
        /// </summary>
        /// <param name="percent">likelihood of the event.</param>
        /// <returns>True if the likelihood of the parameter matches the probability.</returns>
        private bool CanApply(double percent)
        {
            if ((RandVal() * 100) <= percent) return true;
            return false;
        }

        /// <summary>
        /// Applies Fisher-Yates algortihm on the population;
        /// </summary>
        private void OperatorShuffle()
        {
            int copyPopulationSize = population.Length;
            while (copyPopulationSize > 1)
            {
                int k = rng.Next(copyPopulationSize--);
                var temp = population[copyPopulationSize];
                population[copyPopulationSize] = population[k];
                population[k] = temp;
            }
        }

        private void OperatorMutate(int index)
        {
            if (CanApply(mutateChance))
            {
                int lowerBound = rng.Next(0, population[index].genes.Length - 2);
                int upperBound = rng.Next(lowerBound, population[index].genes.Length - 1);
                for (; lowerBound < upperBound; lowerBound++)
                {
                    population[index].genes[lowerBound] = population[index].GetGeneRandomValue(lowerBound);
                }
            }
        }

        private void OperatorCrossover(int parent1, int parent2)
        {
            if (CanApply(xoverChance))
            {
                int cutoff = rng.Next(2, population[parent1].genes.Length - 2);
                for (int i = 0; i < cutoff; i++)
                {
                    population[parent1].genes[i] = population[parent2].genes[i];
                }
                for (int i = cutoff; i < population[parent1].genes.Length; i++)
                {
                    population[parent2].genes[i] = population[parent1].genes[i];
                }
            }
        }

        private Chromosome[] EvalIPC()
        {
            var temp = population.OrderBy(c => c.ipcValue).ToArray();
            return temp;
        }

        private Chromosome[] EvalPower()
        {
            var temp = population.OrderByDescending(c => c.powerValue).ToArray();
            return temp;
        }

        private void CombinePopulations()
        {
            var ipc = EvalIPC();
            var pow = EvalPower();
            int populationHalfLength = population.Length / 2;
            for (int i = 0; i < populationHalfLength; i++)
            {
                population[i] = ipc[i];
                population[i + populationHalfLength] = pow[i];
            }
        }

        private void ApplyGeneticOperators(int index1, int index2)
        {
            OperatorCrossover(index1, index2);
            OperatorMutate(index1);
            OperatorMutate(index2);
        }

        private void GenerateNewPopulation()
        {
            CombinePopulations();
            for (int i = 0; i < population.Length - 1; i += 2)
            {
                ApplyGeneticOperators(i, i + 1);
            }
            OperatorShuffle();
        }

        public Vega(string location, UInt32 popSize, UInt32 iterations, UInt32 ipcW, UInt32 powW, double mutate, double xover)
        {
            population = new Chromosome[popSize];

            for (int i = 0; i < popSize; i++)
            {
                population[i] = new Chromosome();
            }

            psatSimLocation = location;
            maxIterations = iterations;
            ipcWeight = ipcW;
            powerWeight = powW;
            mutateChance = mutate;
            xoverChance = xover;

            foreach (var chromosome in population)
            {
                chromosome.GenerateRandom();
            }
        }


        public void GenerateXML()
        {
            XmlWriter xmlWriter = XmlWriter.Create(psatSimLocation + @"\in.xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("psatsim");
            for (int i = 0; i < population.Length; i++)
            {
                Chromosome chromosome = population[i];
                xmlWriter.WriteStartElement("config");
                xmlWriter.WriteAttributeString("name", i.ToString());
                xmlWriter.WriteStartElement("general");//general
                xmlWriter.WriteAttributeString("superscalar", chromosome.SuperScalarFactor.ToString());
                xmlWriter.WriteAttributeString("rename", chromosome.RenameSize.ToString());
                xmlWriter.WriteAttributeString("reorder", chromosome.ReorderSize.ToString());

                switch (chromosome.ReservationArchitecture)
                {
                    case 0:
                        xmlWriter.WriteAttributeString("rsb_architecture", "distributed");
                        break;
                    case 1:
                        xmlWriter.WriteAttributeString("rsb_architecture", "centralized");
                        break;
                    case 2:
                        xmlWriter.WriteAttributeString("rsb_architecture", "hybrid");
                        break;
                    case 3:
                        xmlWriter.WriteAttributeString("rsb_architecture", "hybrid");
                        break;
                }

                xmlWriter.WriteAttributeString("rs_per_rsb", chromosome.ResStationsPerBuffer.ToString());
                xmlWriter.WriteAttributeString("speculative", "true");
                xmlWriter.WriteAttributeString("speculation_accuracy", "1.000");

                if (chromosome.SeparateDecodeDispatch != 0)
                {
                    xmlWriter.WriteAttributeString("separate_dispatch", "true");
                }
                else
                {
                    xmlWriter.WriteAttributeString("separate_dispatch", "false");
                }

                xmlWriter.WriteAttributeString("seed", "0");
                xmlWriter.WriteAttributeString("trace", "compress.tra");
                xmlWriter.WriteAttributeString("output", "out.xml");
                xmlWriter.WriteAttributeString("vdd", "2.2");
                xmlWriter.WriteAttributeString("frequency", "600");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("execution");// execution
                xmlWriter.WriteAttributeString("architecture", "standard");
                xmlWriter.WriteAttributeString("integer", chromosome.IntegerEU.ToString());
                xmlWriter.WriteAttributeString("floating", chromosome.FloatingPointEU.ToString());
                xmlWriter.WriteAttributeString("branch", chromosome.BranchEU.ToString());
                xmlWriter.WriteAttributeString("memory", chromosome.MemEU.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("memory");//memory
                xmlWriter.WriteAttributeString("architecture", "l2");
                xmlWriter.WriteStartElement("l1_code");
                xmlWriter.WriteAttributeString("hitrate", "1.000");
                xmlWriter.WriteAttributeString("latency", "0");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("l1_data");
                xmlWriter.WriteAttributeString("hitrate", "1.000");
                xmlWriter.WriteAttributeString("latency", "0");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("l2");
                xmlWriter.WriteAttributeString("hitrate", "1.000");
                xmlWriter.WriteAttributeString("latency", "0");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("system");
                xmlWriter.WriteAttributeString("latency", "0");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();// /memory
                xmlWriter.WriteEndElement();// /config
            }
            xmlWriter.WriteEndElement();// /psatsim
            xmlWriter.Close();
        }

        public void UpdatePopulationIpcAndPower()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(psatSimLocation + @"\in.xml");
            XmlNodeList nodeList = doc.SelectNodes("/psatsim_results/variation");

            foreach (XmlNode node in nodeList)//pt fiecare variation
            {
                XmlElement xmlElement = (XmlElement)node;
                int configNumber = Convert.ToInt32(xmlElement.GetElementsByTagName("configuration")[0]);

                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.Name == "general")
                    {
                        var attributes = child.Attributes;
                        var ipc = Convert.ToDouble(attributes.GetNamedItem("ipc").Value);
                        var power = Convert.ToDouble(attributes.GetNamedItem("power").Value);
                        population[configNumber].ipcValue = (float)ipc;
                        population[configNumber].powerValue = (float)power;
                    }
                }
            }
        }

        public void Simulate()
        {
            Process process = new Process();
            process.StartInfo.FileName = @"D:\Facultate\Anul 4\Simulare\proiect(VEGA)\PSATSim_INSTALLED\psatsim_con.exe";
            process.StartInfo.WorkingDirectory = @"D:\Facultate\Anul 4\Simulare\proiect(VEGA)\PSATSim_INSTALLED\";
            string inputFilePath = psatSimLocation + @"\in.xml";
            string outputFilePath = psatSimLocation + @"\in.xml";
            process.StartInfo.Arguments = inputFilePath + " " + outputFilePath + " -cg -t 8";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process.StartInfo.UseShellExecute = false;
            try
            {
                bool x = process.Start();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            process.WaitForExit();// Waits here for the process to exit.
        }
    }
}