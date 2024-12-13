namespace CSharpModule.Tasks;

public class StringOperations
{
    static string Reverse(string str)
        {
             StringBuilder stringBuilder = new StringBuilder();
             
            for(int i=str.Length-1; i>=0; i--)
            {
                stringBuilder.Append(str[i]);
            }
            return stringBuilder.ToString();
        }

        static bool AreAnograms(string str1, string str2)
        {
            str1 = str1.ToLower();
            str2 = str2.ToLower();

            str1 = string.Concat(str1.OrderBy(x=>x));
            str2 = string.Concat(str2.OrderBy(x=>x));
            
            bool result = str1.Equals(str2);
            return result;
        }
    
}