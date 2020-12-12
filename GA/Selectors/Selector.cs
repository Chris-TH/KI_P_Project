using System;
using System.Collections.Generic;

namespace GA.Selectors
{
    public class Selector: ISelector
    {
        private DummyFitness fitness;
        public List<string> SelectFromGeneration(GenerationDB.Generation parentGeneration)
        {
            var selectedGeneration = new GenerationDB.Generation();
          //  var container = new List<String>(selectedGeneration.Individuals.Count * 2);
            var container = new List<String>();


            var car = new CarState();

            foreach (var parent in parentGeneration.Individuals)
            {
                if (parent.Fitness >= fitness.DetermineFitness(car))
                {
                    container.Add(parent.GeneSequence);
                }
                selectedGeneration.Add(container);
            }
            return container;
        }
    }
}