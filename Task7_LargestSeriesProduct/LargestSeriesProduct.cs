using System;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (span < 0 || span > digits.Length || !digits.All(char.IsDigit))
        {
            throw new ArgumentException("Invalid input parameters.");
        }

        if (span == 0)
        {
            return 1;
        }

        long maxProduct = 0;

        for (int i = 0; i <= digits.Length - span; i++)
        {
            long currentProduct = 1;

            for (int j = 0; j < span; j++)
            {
                int digit = digits[i + j] - '0';
                currentProduct *= digit;
            }

            if (currentProduct > maxProduct)
            {
                maxProduct = currentProduct;
            }
        }

        return maxProduct;
    }
}