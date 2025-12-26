using System.Collections.Generic;
using UnityEngine;

public class DNA_sc
{

    List<int> genes = new List<int>();

    int dnaLenght = 0;

    int maxValues = 0;

    public DNA_sc(int lenght, int maxV)
    {
        this.dnaLenght = lenght;
        this.maxValues = maxV;
        SetRandom();

    }

    public void SetRandom()
    {
        this.genes.Clear();
        for (int i = 0; i < this.dnaLenght; i++)
        {
            this.genes.Add(Random.Range(0, this.maxValues));
        }

    }

    public void SetGene(int pos, int value)
    {
        this.genes[pos] = value;
    }

    public int GetGene(int pos)
    {
        return this.genes[pos];
    }

    public void Combine(DNA_sc parent1, DNA_sc parent2)
    {
        // Dna uzunluðunun yarýsýný parent1'den yarýsýný parent2'den al
        for (int i = 0; i < this.dnaLenght; i++)
        {
            if (i < dnaLenght / 2.0f)
            {
                int c = parent1.GetGene(i);
                this.genes[i] = c;
            }
            else
            {
                int c = parent2.GetGene(i);
                this.genes[i] = c;
            }
        }
    }

    public void Mutate()
    {
        // mevcut genetik koddaki rastgele bi konumdaki genin deðerini rastgele olarak belirle
        this.genes[Random.Range(0, this.dnaLenght)] = Random.Range(0, this.maxValues);

    }
}