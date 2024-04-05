namespace CSharpModule.Tasks;

public class StringManipulation
{
    public string Reverse(string str)
    {
        string result = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            result += str[i];
        }
        return result;
    }
}