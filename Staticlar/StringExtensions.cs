public static class StringExtensions
{
    public static bool IsPalindrome(this string text)
    {
        for(int i = 0, j = text.Length - 1; i <= j; i++, j--)
            if(text[i] != text[j])
                return false;
            
        return true;
    }

    public static int[] ParseIntegers(this string? text)
    {
        return text?.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray() ?? [];
    }
}