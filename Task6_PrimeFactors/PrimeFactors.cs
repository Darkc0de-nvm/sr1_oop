using System.Collections.Generic;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        var factors = new List<long>();
        long divisor = 2;

        while (divisor * divisor <= number)
        {
            while (number % divisor == 0)
            {
                factors.Add(divisor);
                number /= divisor;
            }

            divisor++;
        }

        if (number > 1)
        {
            factors.Add(number);
        }

        return factors.ToArray();
    }
}