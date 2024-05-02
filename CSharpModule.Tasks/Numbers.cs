using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;

namespace CSharpModule.Tasks
{
    public class Numbers
    {
        // 1-st task
        public int CheckedAdd(int a, int b)
        {
            if ((a > 0 && b > int.MaxValue - a) || (a < 0 && b < int.MinValue - a))
                return -1;

            return a + b;
        }

        // 2-nd task
        public BigInteger CleanNumber(string str) => BigInteger.Parse(string.Concat(str.Where(char.IsDigit)));

        // 3-rd task
        public BigInteger AddTransactions(string amount1, string amount2)
        {
            if(amount1 == string.Empty && amount2 == string.Empty)
                return 0;

            return BigInteger.Parse(amount1) + BigInteger.Parse(amount2);
        }

        // 4-th task
        public BigInteger PredictPopulation(BigInteger initialPopulation, int growthRate, int years) 
        {
            BigInteger population = initialPopulation * BigInteger.Pow(growthRate + 1, years);
    
            return population;
        }

        // 5-th task
        public decimal ConvertCurrency(decimal amount, float rate) => amount * (decimal)rate;
    }
}