using System;
using System.Collections.Generic;

namespace GA.Selectors
{
    public class RandomSelector: ISelector
    {
        private Random rand;
        public List<string> SelectFromGeneration(GenerationDB.Generation parentGeneration)
        {
            var selectedGeneration = new GenerationDB.Generation();
            var container = new List<String>();
            
            if (rand == null)
                rand = new Random();
            
            for (var i=0; i< parentGeneration.Individuals.Count; i++)
            {
                container.Add(parentGeneration.Individuals[rand.Next(parentGeneration.Individuals.Count)].GeneSequence);
            }
            selectedGeneration.Add(container);
            
            return container;
        }
    }
}