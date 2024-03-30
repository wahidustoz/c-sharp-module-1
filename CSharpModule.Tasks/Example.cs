namespace CSharpModule.Tasks;

public class Example
{
    public int[] ReverseArray(int[] original)
    {
        for(int i = 0, j = original.Length - 1; i < j; i++, j--)
            (original[i], original[j]) = (original[j], original[i]);

        return original;
    }
}
