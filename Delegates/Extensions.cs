namespace Delegates;

public static class Extensions
{
    public static IEnumerable<int> Filter(
        this int[] array,
        Func<int, bool> filterlashSharti)
    {
        var result = new List<int>();

        foreach(var son in array)
            if(filterlashSharti?.Invoke(son) is true)
                result.Add(son);

        return result;
    }

    public static IEnumerable<int> Songa(
        this IEnumerable<string> stringlar, 
        Func<string, int> songaOguruvchiMethod)
    {
        // var sonlar = new List<int>();
        // foreach(var str in stringlar)
        //     sonlar.Add(songaOguruvchiMethod(str));

        // return sonlar;

        foreach(var str in stringlar)
            yield return songaOguruvchiMethod(str);
    }
}