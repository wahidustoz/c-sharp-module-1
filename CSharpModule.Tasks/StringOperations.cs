using System.Text;

namespace CSharpModule.Tasks;

public class StringOperations
{
    public string Reverse(string str)
    {
        string result = string.Empty;
        // hello
        for(int i = str.Length - 1; i >= 0; i--)
            result += str[i];

        return result;
    }

    // CTRL + } -- chapga kodni siljitadi
    // CTRL + { -- kodni o'ngga siljitadi

    // hello, elloh
    public bool AreAnagrams(string str1, string str2)
    {
        if(str1.Length != str2.Length)
            return false;

        for(int i = 0; i < str1.Length; i++)
        {
            var index = str2.IndexOf(str1[i]);
            if(index < 0)
                return false; // str1 is not an anagram of str2
            
            str2 = str2.Remove(index, 1);
        }

        return true;
    }

    public string LongestPalindromeWithin(string str) => str;

    // aaabbccdd
    public string RemoveDuplicates(string str)
    {
        var builder = new StringBuilder();
        
        for(int i = 0; i < str.Length; i++)
        {
            if(builder.ToString().Contains(str[i]) == false)
                builder.Append(str[i]);
        }   

        return  builder.ToString();
    }

    public bool IsValidPalindrome(string str)
    {
        var clearArray = str.Where(char.IsLetterOrDigit).ToArray();
        for(int i = 0, j = clearArray.Length - 1; i < j; i++, j--)
        {
            var a = clearArray[i].ToString();
            var b = clearArray[j].ToString();
            if(string.Equals(a, b, StringComparison.CurrentCultureIgnoreCase) == false)
                return false;
        }

        return true;
    }

    public char FirstNonRepeatedCharacter(string str)
    {
        while(str.Length > 0)
        {
            if(str.Substring(1).Contains(str[0]))
                str = str.Replace(str[0].ToString(), string.Empty);
            else 
                return str[0];
        }

        return ' ';
    }

    public string Compress(string str)
    {
        var builder = new StringBuilder();
        for(int i = 0; i < str.Length; )
        {
            builder.Append(str[i]);

            int j = i + 1;
            while(j < str.Length && str[i] == str[j])
                j++;
            
            builder.Append(j - i);

            i = j;
        }

        return builder.ToString();
    }
}