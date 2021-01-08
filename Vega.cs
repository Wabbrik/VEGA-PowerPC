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
        Chromosome bestChromosome;
        int iterations;
        string psatSimLocation;
        int noEvolutionCount;
        UInt32 maxIterations;
        UInt32 ipcWeight;
        UInt32 powerWeight;
        double mutateChance;
        double xoverChance;
        XMLhelper xmlh;
        string benchmark;
        int numberOfProcesses;
        public Vega(string location, UInt32 popSize, UInt32 maxIterations, UInt32 ipcW, UInt32 powW, double mutate, double xover, string benchmark, int numberOfProcesses = 8, int noEvolutionCount = 3, int iterations = 0)
        {
            population = new Chromosome[popSize];

            for (int i = 0; i < popSize; i++)
            {
                population[i] = new Chromosome();
            }
            this.iterations = iterations;
            bestChromosome = null;
            psatSimLocation = location;
            this.maxIterations = maxIterations;
            ipcWeight = ipcW;
            powerWeight = powW;
            mutateChance = mutate;
            xoverChance = xover;
            this.benchmark = benchmark;
            this.numberOfProcesses = numberOfProcesses;
            this.noEvolutionCount = noEvolutionCount;
            foreach (var chromosome in population)
            {
                chromosome.GenerateRandom();
            }

            string xmlInputOutput = Environment.CurrentDirectory + @"\in.xml";

            xmlh = new XMLhelper(xmlInputOutput, xmlInputOutput, location, "-g -t ", numberOfProcesses, benchmark);
        }

        internal void UpdatePopulationIpcAndPower()
        {
            xmlh.UpdatePopulationIpcAndPower(population);
        }

        internal void Simulate()
        {
            xmlh.Simulate();
        }

        internal void GenerateXML()
        {
            xmlh.GenerateXML(population);
        }

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

        private bool StopGa(int numberOfGenerationsWithoutImprovement)
        {
            return (numberOfGenerationsWithoutImprovement >= noEvolutionCount || iterations >= maxIterations) ? true : false;
        }

        private Chromosome maxChromosome(Chromosome x, Chromosome y)
        {
            return (x.score > y.score) ? x : y;
        }

        private void UpdateBestChromosome(Chromosome x, Chromosome y)
        {
            bestChromosome = maxChromosome(bestChromosome, maxChromosome(x, y));
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
                population[i].UpdateScore(ipcWeight, powerWeight);
                population[i + populationHalfLength].UpdateScore(ipcWeight, powerWeight);
                UpdateBestChromosome(population[i], population[i + populationHalfLength]);
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

        public void StartSimulation()
        {
            int noImpctr = 0;
            while (!StopGa(noImpctr))
            {
                GenerateXML();
                Simulate();
                UpdatePopulationIpcAndPower();
                var tempChromosome = bestChromosome;
                GenerateNewPopulation();
                if (tempChromosome == bestChromosome) noImpctr++;
                iterations += 1;
            }
        }
    }
}