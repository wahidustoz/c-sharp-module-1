namespace CSharpModule.Tasks;

public class StringOperations
{
    //1
    public string Reverse(string str)
    {
        var arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
    //2
    public bool AreAnagrams(string str1, string str2)
    {
        var a = str1.ToCharArray();
        var b = str2.ToCharArray();

        Array.Sort(a);
        Array.Sort(b);
        return new string(a) == new string(b);
    }
    //3
    public string LongestPalindromeWithin(string str)
    {
        return new NotImplementedException().Message;   
    }
    //4
    public string RemoveDuplicates(string str)
    {
        string result = "";

        foreach (var c in str)
        {
            if (result.IndexOf(c) == -1)
            {
                result += c;
            }
        }
        return result;
        // your code here
    }
    //5
    public bool IsValidPalindrome(string str)
    {
        str = str.ToLower();
        string finalString = "";
        for(int i = 0; i < str.Length; i++)
        {
            if(char.IsLetterOrDigit(str[i]))
            {
                finalString += str[i];
            }
        }
        for(int i = 0; i < finalString.Length / 2; i++)
        {
            if(finalString[i] != finalString[finalString.Length - i - 1])
            {
                return false;
            }
        }

        return true;

    }
    //6
    public char FirstNonRepeatedCharacter(string str)
    {
        int c = 0;
        for(int i = 0; i < str.Length; i++)
        {
            c = 0;
            for(int j = i + 1; j < str.Length; j++)
            {
                if(str[i] == str[j])
                {
                    c++;
                }
            }
            if(c == 0)
            {
                return str[i];
            }
        }
        return ' ';
    }
    //7
    public string Compress(string str)
    {
        int occ = 0;
        string result = "";

        for(int i = 0; i < str.Length; i++)
        {
            occ++;
            if(i + 1 >= str.Length || str[i] != str[i + 1])
            {
                result += str[i] + occ.ToString();
                occ = 0;
            }
        }

        return result;
    }
}