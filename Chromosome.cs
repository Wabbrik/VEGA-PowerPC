using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegaPowerPC
{
    class Chromosome
    {
        static Random r = new Random();
        public UInt16[] genes;
        public static UInt16[] geneMaxValues = { 16, 512, 512, 1, 3, 8, 8, 8, 8, 8 };
        public static UInt16[] geneMinValues = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 1 };
        public float powerValue { get; set; }
        public float ipcValue { get; set; }
        public float score { get; set; }

        public Chromosome()
        {
            genes = new UInt16[10];
        }

        public void GenerateRandom()
        {
            for (int i = 0; i < genes.Count(); i++)
            {
                genes[i] = GetGeneRandomValue(i);
            }
        }

        public UInt16 GetGeneRandomValue(int index)
        {
            return (UInt16)r.Next(geneMinValues[index], geneMaxValues[index] + 1);
        }

        public UInt16 SuperScalarFactor { get { return genes[0]; } set { genes[0] = value; } }
        public UInt16 RenameSize { get { return genes[1]; } set { genes[1] = value; } }
        public UInt16 ReorderSize { get { return genes[2]; } set { genes[2] = value; } }
        public UInt16 SeparateDecodeDispatch { get { return genes[3]; } set { genes[3] = value; } }
        public UInt16 ReservationArchitecture { get { return genes[4]; } set { genes[4] = value; } }
        public UInt16 ResStationsPerBuffer { get { return genes[5]; } set { genes[5] = value; } }
        public UInt16 IntegerEU { get { return genes[6]; } set { genes[6] = value; } }
        public UInt16 FloatingPointEU { get { return genes[7]; } set { genes[7] = value; } }
        public UInt16 BranchEU { get { return genes[8]; } set { genes[8] = value; } }
        public UInt16 MemEU { get { return genes[9]; } set { genes[9] = value; } }
    }
}