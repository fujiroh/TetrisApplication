using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;

namespace TaskPlacer
{
    public class GeneticAlgorithm
    {
        private const int LoopGenerationCount = 200;
        private const int PopulationCount = 200;
        private const float Threshold = 100;
        private const float MutationProbability = 0.1f;
        private const float CrossOverProbability = 0.3f;
        
        private readonly List<Chromosome> _geneRecord;
        private List<Chromosome> _population;

        public GeneticAlgorithm()
        {
            _geneRecord = new List<Chromosome>();
        }

        public Chromosome Execute(IEnumerable<MasterTask> tasks)
        {
            var fistGeneration = Chromosome.CreateFirstGeneration(tasks);
            var bestChromosome = fistGeneration.Clone();
            for (int generation = 0; generation < LoopGenerationCount; generation++)
            {
                if (bestChromosome.GetFitness() >= Threshold)
                {
                    return bestChromosome;
                }
                
                MoveToNextGeneration();

                var currentGenerationBestChromosome = GetBestChromosomeFromPopulation();
                var currentGenerationBestChromosomeFitness = currentGenerationBestChromosome.GetFitness();
                if (bestChromosome.GetFitness() < currentGenerationBestChromosomeFitness)
                {
                    bestChromosome = currentGenerationBestChromosome.Clone();
                }
            }

            return bestChromosome;
        }

        private void MoveToNextGeneration()
        {
            List<Chromosome> nextPopulation = new List<Chromosome>();
            while (nextPopulation.Count < PopulationCount)
            {
                var parents = GetParentsBySelectionType();
                var nextGenerationChromosome = GetNextGenerationChromosomes(parents);
                nextPopulation = nextPopulation.Concat(nextGenerationChromosome).ToList();
            }

            if (nextPopulation.Count > PopulationCount)
            {
                nextPopulation.RemoveAt(0);
            }

            _population = nextPopulation;
        }

        private IList<Chromosome> GetNextGenerationChromosomes(IList<Chromosome> parents)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            var nextGenerationChromosome = parents;
            
            // 交叉
            if ((float)rand.Next(0, 100) / 100 < CrossOverProbability)
            {
                nextGenerationChromosome = parents[0].CrossOver(parents[1]);
            }
            
            // 突然変異
            if ((float)rand.Next(0, 100) / 100 < MutationProbability)
            {
                foreach (var parent in parents)
                {
                    parent.Mutate();
                }
            }

            return nextGenerationChromosome;
        }
        
        private Chromosome GetBestChromosomeFromPopulation()
        {
            var best = _population[0];
            foreach (var individual in _population)
            {
                if (best.GetFitness() < individual.GetFitness())
                {
                    best = individual;
                }
            }

            return best;
        }

        private IList<Chromosome> GetParentsBySelectionType()
        {
            return ExecuteTournamentSelection();
        }

        // トーナメント方式で選抜
        private IList<Chromosome> ExecuteTournamentSelection()
        {
            var dummyChromosome = Chromosome.CreateDummyChromosome();
            var topTwo = Tuple.Create(dummyChromosome,dummyChromosome);
            foreach (var chromosome in _population)
            {
                if (chromosome.GetFitness() < topTwo.Item1.GetFitness())
                {
                    topTwo = Tuple.Create(chromosome, topTwo.Item2);
                    continue;
                }
                if (chromosome.GetFitness() < topTwo.Item2.GetFitness())
                {
                    topTwo = Tuple.Create(topTwo.Item1, chromosome);
                }

                if (topTwo.Item1.GetFitness() < topTwo.Item2.GetFitness())
                {
                    topTwo = Tuple.Create(topTwo.Item2,topTwo.Item1);
                }
            }

            return new List<Chromosome>() {topTwo.Item1, topTwo.Item2};
        }
    }
}