using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.hamming
{
    public class Hamming
    {   
        internal static int Compute(string DNA1, string DNA2)
        {
            int counter = 0;
            if (DNA1.Length == DNA2.Length)
            {
                if (DNA1.Length == 0 || DNA1.Equals(DNA2))
                    return 0;

                for (int i = 0; i < DNA1.Length; i++)
                {
                    if (DNA1[i] != DNA2[i])
                        counter++;
                }
            }
            return counter;
        }
    }
}