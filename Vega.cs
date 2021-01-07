using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegaPowerPC
{
    class Vega
    {
        Chromosome[] population;
        string psatSimLocation;
        UInt32 maxIterations;
        UInt32 ipcWeight;
        UInt32 powerWeight;

        Vega(string location, UInt32 popSize, UInt32 iterations, UInt32 ipcW, UInt32 powW)
        {
            population = new Chromosome[popSize];
            psatSimLocation = location;
            maxIterations = iterations;
            ipcWeight = ipcW;
            powerWeight = powW;

            foreach(var chromosome in population)
            {
                chromosome.GenerateRandom();
            }
        }
    }
}
