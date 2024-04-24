//#### 1. Checked addition
//Write a C# function to add two integers and return the result. Return `-1` if the addition overflows.
// Console.WriteLine("a va b o'zgaruvchiga qiymat kiriting");
// int a = int.Parse(Console.ReadLine()!);
// int b = int.Parse(Console.ReadLine()!);

// if (a <= 1 || b <= 1) 
// {
//     Console.WriteLine($"{a + b}");
// }
// else 
// {
//     Console.WriteLine($"{-1}");
// }

using System;
using System.Numerics;
using System.Text;

public class Module
{
    public static int Add(int a, int b)
    {
        try
        {
            checked
            {
                return a + b;
            }
        }
        catch (OverflowException)
        {
            return -1;
        }
    }
/*
2. Clean number
Write a C# function which accepts a string with numbers, 
spaces and special characters in it. 
Clean out the all non-numeric characters and parse 
the string into single BigInteger type.
*/
    // public BigInteger CleanNumber(string str)
    // {
    //     StringBuilder stringBuilder = new StringBuilder();
    //     for(int i = 0; i < str.Length; i++)
    //     {
    //         if(str[i] >= '0' && str[i] <= '9')
    //         {
    //             stringBuilder.Append(str[i]);
    //         } else 
    //         {
    //             Console.WriteLine(0);
    //         }
    //     }
    //     var response = BigInteger.Parse(stringBuilder.ToString());
    //     return response;
    // }

//1. Checked addition 
    // public int CheckedAdd(int a, int b)
    // {
    //     checked {
    //         try 
    //         {
    //             return a + b;
    //         }
    //         catch 
    //         {
    //             return -1;
    //         }
    //     }
    // }

    //3. Add Transactions
    public BigInteger AddTransactions(string amount1, string amount2)
    {
        checked
        {
            try 
            {
                BigInteger totalAmount = BigInteger.Parse(amount1 + amount2);
                string totalAmountStr = totalAmount.ToString();
                
            }
            catch
            {
                return 0; 
                
            }

        }
        return 0;
        
    }
}
