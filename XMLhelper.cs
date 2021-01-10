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
    class XMLhelper
    {
        string inputFile;
        string outputFile;
        string processLocation;
        string processParameters;
        string traceFile;
        XmlWriter xmlWriter;

        public XMLhelper(string inputFile, string outputFile, string processLocation, string processParameters, int numberOfProcesses, string traceFile)
        {
            this.inputFile = inputFile;
            this.outputFile = outputFile;
            this.processLocation = processLocation;
            this.processParameters = processParameters + numberOfProcesses;
            this.traceFile = traceFile;
        }

        /// <summary>
        /// Builds and XML that represents the configurations of the chromosomes inside the population.
        /// </summary>
        public void GenerateXML(Chromosome[] population)
        {
            xmlWriter = XmlWriter.Create(inputFile);
            xmlWriter.WriteStartDocument();
            WritePsatSim(population);
            xmlWriter.Close();
        }

        private void WritePsatSim(Chromosome[] population)
        {
            xmlWriter.WriteStartElement("psatsim");
            for (int configNumber = 0; configNumber < population.Length; configNumber++)
            {
                WriteConfigOfChromosome(configNumber, population[configNumber]);
            }
            xmlWriter.WriteEndElement();
        }

        private void WriteConfigOfChromosome(int i, Chromosome chromosome)
        {
            xmlWriter.WriteStartElement("config");
            xmlWriter.WriteAttributeString("name", i.ToString());
            WriteInnerNodes(chromosome);
            xmlWriter.WriteEndElement();// /config
        }

        private void WriteInnerNodes(Chromosome chromosome)
        {
            WriteGeneral(chromosome);
            WriteExecution(chromosome);
            WriteMemory();
        }

        private void WriteGeneral(Chromosome chromosome)
        {
            xmlWriter.WriteStartElement("general");
            xmlWriter.WriteAttributeString("superscalar", chromosome.SuperScalarFactor.ToString());
            xmlWriter.WriteAttributeString("rename", chromosome.RenameSize.ToString());
            xmlWriter.WriteAttributeString("reorder", chromosome.ReorderSize.ToString());
            WriteReservationArchitecture(chromosome.ReservationArchitecture);
            xmlWriter.WriteAttributeString("rs_per_rsb", chromosome.ResStationsPerBuffer.ToString());
            xmlWriter.WriteAttributeString("speculative", "true");
            xmlWriter.WriteAttributeString("speculation_accuracy", "1.000");
            WriteSeparateDecodeDispatch(chromosome);
            xmlWriter.WriteAttributeString("seed", "0");
            xmlWriter.WriteAttributeString("trace", traceFile);
            xmlWriter.WriteAttributeString("output", inputFile);
            xmlWriter.WriteAttributeString("vdd", "2.2");
            xmlWriter.WriteAttributeString("frequency", "600");
            xmlWriter.WriteEndElement();
        }

        private void WriteSeparateDecodeDispatch(Chromosome chromosome)
        {
            if (chromosome.SeparateDecodeDispatch != 0)
            {
                xmlWriter.WriteAttributeString("separate_dispatch", "true");
            }
            else
            {
                xmlWriter.WriteAttributeString("separate_dispatch", "false");
            }
        }

        private void WriteReservationArchitecture(ushort architectureOrder)
        {
            switch (architectureOrder)
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
        }

        private void WriteExecution(Chromosome chromosome)
        {
            xmlWriter.WriteStartElement("execution");// execution
            xmlWriter.WriteAttributeString("architecture", "standard");
            xmlWriter.WriteAttributeString("integer", chromosome.IntegerEU.ToString());
            xmlWriter.WriteAttributeString("floating", chromosome.FloatingPointEU.ToString());
            xmlWriter.WriteAttributeString("branch", chromosome.BranchEU.ToString());
            xmlWriter.WriteAttributeString("memory", chromosome.MemEU.ToString());
            xmlWriter.WriteEndElement();
        }

        private void WriteMemory()
        {
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
        }

        /// <summary>
        /// Updates population's Ipc and Power attributes respectively
        /// </summary>
        public void UpdatePopulationIpcAndPower(Chromosome[] population)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(inputFile);
            XmlNodeList nodeList = doc.SelectNodes("/psatsim_results/variation");
            ParseVariationNodes(population, nodeList);
        }

        private static void ParseVariationNodes(Chromosome[] population, XmlNodeList nodes)
        {
            foreach (XmlNode node in nodes)
            {
                var elementAttributeList = node.Attributes;
                int configNumber = Convert.ToInt32(elementAttributeList.GetNamedItem("configuration").Value);
                UpdateChromosomes(population[configNumber], node.ChildNodes);
            }
        }

        private static void UpdateChromosomes(Chromosome chromosome, XmlNodeList nodes)
        {
            foreach (XmlNode node in nodes)
            {
                if (node.Name == "general")
                {
                    UpdateChromosomeWithAttribute(chromosome, node.Attributes);
                }
            }
        }
       
        private static void UpdateChromosomeWithAttribute(Chromosome chromosome, XmlAttributeCollection attributes)
        {
            chromosome.powerValue = GetPowerAttribute(attributes);
            chromosome.ipcValue = GetIpcAttribute(attributes);
        }

        private static double GetPowerAttribute(XmlAttributeCollection attributes)
        {
            double returnValue;
            Double.TryParse(attributes.GetNamedItem("power").Value, out returnValue);
            return returnValue;
        }

        private static double GetIpcAttribute(XmlAttributeCollection attributes)
        {
            double returnValue;
            Double.TryParse(attributes.GetNamedItem("ipc").Value, out returnValue);
            return returnValue;
        }

        private string getProcessFolder()
        {
            return Path.GetDirectoryName(processLocation);
        }

        private ProcessStartInfo processInfoFactory()
        {
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.FileName = processLocation + @"\psatsim_con.exe"; //@"D:\Facultate\Anul 4\Simulare\proiect(VEGA)\PSATSim_INSTALLED\psatsim_con.exe"
            psi.WorkingDirectory = processLocation + @"\"; //@"D:\Facultate\Anul 4\Simulare\proiect(VEGA)\PSATSim_INSTALLED\";
            psi.Arguments = inputFile + " " + outputFile + " " +processParameters;
            psi.WindowStyle = ProcessWindowStyle.Maximized;
            psi.UseShellExecute = false;
            return psi;
        }

        public void Simulate()
        {

            var psi = processInfoFactory();
            var process = System.Diagnostics.Process.Start(psi);
            process.WaitForExit();
        }
    }
}
