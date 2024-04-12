using System.Numerics;

namespace CSharpModule.Tasks;

public class Numbers 
{
    // 1 - masala 
    public BigInteger CheckedAdd(int a, int b) 
    {
        if (int.MaxValue < a || int.MaxValue < b) 
            return BigInteger.Zero;
        else 
            return BigInteger.Add(a, b);
    }

    
    // 2 - masala
    public BigInteger CleanNumber(string str) 
    {
        string result = "";
        foreach (char i in str) 
        {
            if (char.IsDigit(i)) 
            {
                result += i;
            }
            else return 0;
        }
        return BigInteger.Parse(result);
    }

    // 3 - masala | Ishlay olmadim 

    public BigInteger AddTransactions(string amount1, string amount2)
    {
        return 0;
    }

    // 4 - masala | Masalalar o'ta qiyin ekan☠️
    public BigInteger PredictPopulation(BigInteger initialPopulation, int growthRate, int years) 
    {
        return 0;    
    }

    
    // 5 - masala 

    public decimal ConvertCurrency(decimal amount, float rate) 
    {
        return 0;
    }
}