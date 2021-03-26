using System;
using System.Collections.Generic;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 2)
            throw new ArgumentOutOfRangeException();

        var primesBoolArray = Enumerable.Repeat(true, limit + 1).ToList();
        for (int i = 2; i <= (int)Math.Sqrt(limit); i++)
        {
            MarkAsNonPrime( i, limit, primesBoolArray);
        }

        return GetFinalArray(primesBoolArray).ToArray();
    }
    
    private static void MarkAsNonPrime(int numberToTest, int maxIteration, List<bool> primes)
    {
        if (!primes[numberToTest])
            return;

        for (int i = 0; i <= maxIteration; i++)
        {
            int indexToToggle = (int)Math.Pow(numberToTest, 2) + numberToTest * i;
            if (indexToToggle > maxIteration)
                return;

            primes[indexToToggle] = false;
        }
    }

    private static IEnumerable<int> GetFinalArray(List<bool> primes)
    {
        for (int i = 2; i < primes.Count; i++)
        {
            if (primes[i])
                yield return i;
        }
    }
}
