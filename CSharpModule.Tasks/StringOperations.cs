using System.Text;

namespace CSharpModule.Tasks;

public class StringOperations
{
    public string Reverse(string str)
    {
        // your code here
        StringBuilder result = new StringBuilder();
        for (int i = str.Length - 1; i >= 0; i--)
            result.Append(str[i]);

        return result.ToString();
    }

    public bool AreAnagrams(string str1, string str2)
    {
        if(str1.Length != str2.Length)
            return false;
        
        // If this loop is completelly ceculated it means two strings are anagrams
        for(int i = 0; i < str1.Length; i++)
        {
            // This code searches if character in str1 exists in str2
            var index = str2.IndexOf(str1[i]);

            // If there is no match returns false
            if(index < 0)
                return false;
            
            // Removes found character
            str2 = str2.Remove(index, 1);
        }

        return true;
    }

    public string LongestPalindromeWithin(string str) => str;

    public string RemoveDuplicates(string str)
    {
        var result = new StringBuilder();

        for(int i = 0; i < str.Length; i++)
        {
            if(!result.ToString().Contains(str[i]))
                result.Append(str[i]);
        }

        return result.ToString();
    }

    public bool IsValidPalindrome(string str)
    {
        // Cleans from all unnecessary characters
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

        for(int i = 0; i < str.Length;)
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