using System.Text;

namespace CSharpModule.Tasks;

public class StringOperations
{

    public string Reverse(string str)
    {
        // char[] charArray = str.ToCharArray();
        // Array.Reverse(charArray);
        // return new string(charArray);
        string result = string.Empty;
        for (int i = str.Length - 1; i >= 0; i--)
            result += str[i];
        return result;
    }

    public bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length) return false;
        for (int i = 0; i < str1.Length; i++)
        {
            var index = str2.IndexOf(str1[i]);
            if (index < 0)
                return false;
            str2 = str2.Remove(index, 1);
        }
        return str2.Length == 0;
    }
//aabbssdd => return absd
    public string LongestPalindromeWithin(string str) => str;
        
    public string RemoveDuplicates(string str)
    {
        var builder = new StringBuilder();

        for (int i = 0 ; i < str.Length; i++)
        {
            if (builder.ToString().Contains(str[i]) == false)
                builder.Append(str[i]);
        }
        return builder.ToString();
       
    }

    public bool IsValidPalindrome(string str)
    {
        var cleanArray = str.Where(char.IsLetterOrDigit).ToArray();
        for (int i = 0, j = cleanArray.Length - 1; i < j; i++, j--)
        {


            var a = cleanArray[i].ToString();
            var b = cleanArray[j].ToString();

            if (string.Equals(a, b, StringComparison.OrdinalIgnoreCase) == false)
                return false;
        }
        return true;
    }




    public char FirstNonRepeatedCharacter(string str)
    {
        while (str.Length > 0)
        {
            if (str.Substring(1).Contains(str[0]))
                str = str.Replace(str[0].ToString(), string.Empty);
            else
                return str[0];
        }
        return ' ';
    }

    public string Compress(string str)
    {
        var builder = new StringBuilder();
        for (var i = 0; i < str.Length;)
        {
            builder.Append(str[i]);
            int j = i + 1;
            while (j < str.Length && str[j] == str[i])
                j++;
            builder.Append(j - i);
            i = j;
        }
        return builder.ToString();
    }


}