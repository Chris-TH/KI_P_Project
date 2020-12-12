using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AInit : IInitializer
{
    public List<char> genes;
    public void AssignGene(char ID)
    {
        var geneE = new GeneE();
        if (genes == null)
        {
            genes = new List<char>();
        }

        /*if (ID == geneE.ID && genes[genes.Count-1] != geneE.ID)
        {
            genes.Insert(genes.Count-1, ID);
        } */
        genes.Add(ID); 
    }

    public List<Individual> CreateInitialGeneration(int generationSize, int individualSize)
    {
        var  initialGeneration = new List<Individual>();
        for (int i = 0; i < generationSize; i++)
        {
            initialGeneration.Add(GenerateIndividual(individualSize));
        }
        
        return initialGeneration;
    }

    private Individual GenerateIndividual(int individualSize)
    {
        var individual = new Individual();
        System.Text.StringBuilder builder = new System.Text.StringBuilder(individualSize);
        for (int i = 0; i < individualSize; i++)
        {
            for (int j = 0; j < genes.Count; j++)
            {
                builder.Append(genes[j]);
            }
        }
        individual.GeneSequence = builder.ToString();

        return individual;
    }
}
