using System;
using System.Collections;
using UnityEngine;
using Random = System.Random;

public class DummyRecombiner : IRecombiner
{
    private Random rand;
    public string Combine(string parentA, string parentB)
    {
        var recombined = "";
        if (rand == null)
        {
            rand = new Random();
        }

        var min = Math.Min(parentA.Length, parentB.Length);
        var crossOverPoint = rand.Next(0,min);
            
        var crossParentA = parentA.Substring(0, crossOverPoint);
        var crossParentB = parentB.Substring(crossOverPoint);
             
        recombined = String.Concat(crossParentA, crossParentB);
        Debug.Log(recombined);
        return recombined;
    }
}
