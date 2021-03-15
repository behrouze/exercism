using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercism.nucleotide_count
{
    public class DNA
    {
        public Dictionary<char, int> NucleotideCounts { get; set; }


        public DNA(string nucleoChain)
        {
            NucleotideCounts = new Dictionary<char, int> { { 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 } };

            foreach (var nucleotide in nucleoChain)
            {
                if (NucleotideCounts.ContainsKey(nucleotide))
                {
                    NucleotideCounts[nucleotide]++;
                }
            }
        }

        internal int Count(char nucleotide)
        {
            try
            {
                return NucleotideCounts[nucleotide];
            }
            catch (Exception)
            {
                throw new InvalidNucleotideException();
            }
        }
    }

    public class InvalidNucleotideException: System.Exception
    {        
    }
}