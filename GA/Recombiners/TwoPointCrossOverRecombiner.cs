using System;
using System.Linq;
using System.Text;
using UnityEngine;
using Random = System.Random;

namespace GA.Recombiners
{
    public class TwoPointCrossOverRecombiner: IRecombiner
    {
        private Random rand;
        public string Combine(string parentA, string parentB)
        {
            var recombined = "";
            if (rand == null)
            {
                rand = new Random();
            }

            var crossOverPoint1 = rand.Next(0,parentA.Length / 2);
            var crossOverPoint2 = rand.Next((parentA.Length / 2) + 1 , parentA.Length);
            
             var crossParentA = parentA.Substring(0, crossOverPoint1);
             var crossParentB = parentB.Substring(crossOverPoint1, crossOverPoint2);
             var crossParent = parentA.Substring(crossOverPoint2 + 1);
             
             recombined = String.Concat(crossParentA, crossParentB, crossParent);

             return recombined;
        }
    }
}