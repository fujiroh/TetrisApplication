using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TaskPlacer
{
    public class Chromosome
    {
        private readonly IList<TaskComponent> _gene;
        private readonly IEnumerable<int> _sequence;

        // todo:実装中のダミー用 (後で消す)
        public static Chromosome CreateDummyChromosome()
        {
            return new Chromosome(new[] {0, 0, 1, 1});
        }

        private Chromosome(IEnumerable<int> sequence)
        {
            _sequence = sequence;
        }

        public static Chromosome CreateFirstGeneration(IEnumerable<MasterTask> tasks)
        {
            const float bufferRate = 0.5f;

            var sumCost = tasks.Sum(task => task.ProductionCost);
            var temporaryCost = (int) (sumCost * (1.0f + bufferRate));
            var emptyCost = temporaryCost - sumCost;

            IEnumerable<int> seq = new List<int>();
            foreach (var task in tasks)
            {
                seq = seq.Concat(Enumerable.Repeat(task.Id, task.ProductionCost));
            }

            return new Chromosome(seq.Concat(Enumerable.Repeat(TaskComponent.Empty.Id, emptyCost)).ToList());
        }

        public IList<Chromosome> CrossOver(Chromosome other)
        {
            // 仮実装
            var dummyChromosome = CreateDummyChromosome();
            return new[] {dummyChromosome, dummyChromosome};
        }

        public void Mutate()
        {
        }

        public float GetFitness()
        {
            return FitnessCalculator.CalculateFitness(this);
        }

        public Chromosome Clone()
        {
            return new Chromosome(_sequence);
        }
    }
}