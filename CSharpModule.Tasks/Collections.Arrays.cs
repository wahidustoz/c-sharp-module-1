namespace CSharpModule.Tasks;

public class ArraySolutions
{
    /// <summary>
    /// Problem: Given an array of integers, find the maximum value.
    /// </summary>
    /// <param name="array">The input integer array.</param>
    /// <returns>The maximum value in the array.</returns>
    public int MaxValueInArray(int[] array)
    {
        if(array is null or { Length: 0 })
            throw new ArgumentException("Array cannot be empty.");

        int max = array[0];

        foreach(var element in array)
            if(element > max)
                max = element;

        return max;
    }

    /// <summary>
    /// Problem: Reverse an array of integers in-place.
    /// </summary>
    /// <param name="array">The input integer array.</param>
    /// <returns>The reversed array.</returns>
    public int[] ReverseArray(int[] array)
    {
        // Implementation left empty
        //Array.Reverse(array);
        var result = new int[array.Length];
        

        return array;

    }

    /// <summary>
    /// Problem: Determine if an array of integers is sorted in non-decreasing order.
    /// </summary>
    /// <param name="array">The input integer array.</param>
    /// <returns>True if the array is sorted in non-decreasing order, otherwise false.</returns>
    public bool IsArraySorted(int[] array)
    {
        // Implementation left empty
        throw new NotImplementedException();
        //

    }

    /// <summary>
    /// Problem: Find the sum of all even numbers in an array of integers.
    /// </summary>
    /// <param name="array">The input integer array.</param>
    /// <returns>The sum of all even numbers in the array.</returns>
    public int SumOfEvenNumbers(int[] array)
    {
        // Implementation left empty
        throw new NotImplementedException();
    }

    /// <summary>
    /// Problem: Remove duplicates from a sorted array of integers in-place.
    /// </summary>
    /// <param name="array">The input sorted integer array.</param>
    /// <returns>The new length of the modified array after removing duplicates.</returns>
    public int RemoveDuplicates(int[] array)
    {
        // Implementation left empty
        throw new NotImplementedException();
    }

    /// <summary>
    /// Problem: Rotate an array to the right by k steps.
    /// </summary>
    /// <param name="array">The input integer array.</param>
    /// <param name="k">The number of steps to rotate.</param>
    public void RotateArray(int[] array, int k)
    {
        // Implementation left empty
        throw new NotImplementedException();
    }

    /// <summary>
    /// Problem: Merge two sorted integer arrays into one sorted array in-place.
    /// </summary>
    /// <param name="nums1">The first sorted integer array.</param>
    /// <param name="m">The number of elements initialized in nums1.</param>
    /// <param name="nums2">The second sorted integer array.</param>
    /// <param name="n">The number of elements initialized in nums2.</param>
    public void MergeSortedArrays(int[] nums1, int m, int[] nums2, int n)
    {
        // Implementation left empty
        throw new NotImplementedException();
    }

    /// <summary>
    /// Problem: Find the missing number in an array containing n distinct numbers taken from 0, 1, 2, ..., n.
    /// </summary>
    /// <param name="nums">The input integer array.</param>
    /// <returns>The missing number.</returns>
    public int FindMissingNumber(int[] nums)
    {
        // Implementation left empty
        throw new NotImplementedException();
    }

    /// <summary>
    /// Problem: Find a peak element in an array, which is an element that is strictly greater than its neighbors.
    /// </summary>
    /// <param name="nums">The input integer array.</param>
    /// <returns>The index of any peak element.</returns>
    public int FindPeakElement(int[] nums)
    {
        // Implementation left empty
        throw new NotImplementedException();
    }

    /// <summary>
    /// Problem: Sort an array of non-negative integers such that all even elements come before all odd elements.
    /// </summary>
    /// <param name="nums">The input integer array.</param>
    /// <returns>The modified array with even elements followed by odd elements.</returns>
    public int[] SortArrayByParity(int[] nums)
    {
        // Implementation left empty
        throw new NotImplementedException();
    }
}