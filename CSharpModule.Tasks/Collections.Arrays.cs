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
        if (array is null or { Length: 0 })
            throw new ArgumentException("Array cannot be empty.");

        int max = array[0];

        foreach (var element in array)
            if (element > max)
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
        for (int i = 0, j = array.Length - 1; i < j; i++, j--)
            (array[i], array[j]) = (array[j], array[i]);

        return array;

    }

    /// <summary>
    /// Problem: Determine if an array of integers is sorted in non-decreasing order.
    /// </summary>
    /// <param name="array">The input integer array.</param>
    /// <returns>True if the array is sorted in non-decreasing order, otherwise false.</returns>
    public bool IsArraySorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
                return false;
        }
        return true;
    }

    /// <summary>
    /// Problem: Find the sum of all even numbers in an array of integers.
    /// </summary>
    /// <param name="array">The input integer array.</param>
    /// <returns>The sum of all even numbers in the array.</returns>
    public int SumOfEvenNumbers(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                sum += num;
            }
        }

        return sum;
    }

    /// <summary>
    /// Problem: Remove duplicates from a sorted array of integers in-place.
    /// </summary>
    /// <param name="array">The input sorted integer array.</param>
    /// <returns>The new length of the modified array after removing duplicates.</returns>
    public int RemoveDuplicates(int[] array)
    {
        if (array.Length == 0) return 0;

        int uniqueIndex = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] != array[i - 1])
            {
                array[uniqueIndex] = array[i];
                uniqueIndex++;
            }
        }
        return uniqueIndex;
    }

    /// <summary>
    /// Problem: Rotate an array to the right by k steps.
    /// </summary>
    /// <param name="array">The input integer array.</param>
    /// <param name="k">The number of steps to rotate.</param>
    public void RotateArray(int[] array, int k)
    {
        if (array == null || array.Length == 0 || k <= 0)
            return;

        int n = array.Length;
        k %= n;

        int[] temp = new int[k];

        Array.Copy(array, n - k, temp, 0, k);
        for (int i = n - 1; i >= k; i--)
        {
            array[i] = array[i - k];
        }
        for (int i = 0; i < k; i++)
        {
            array[i] = temp[i];
        }

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
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }
        while (j >= 0)
        {
            nums1[k] = nums2[j];
            j--;
            k--;
        }

    }

    /// <summary>
    /// Problem: Find the missing number in an array containing n distinct numbers taken from 0, 1, 2, ..., n.
    /// </summary>
    /// <param name="nums">The input integer array.</param>
    /// <returns>The missing number.</returns>
    public int FindMissingNumber(int[] nums)
    {
        int n = nums.Length;
        int expectedSum = (n * (n + 1)) / 2;
        int actualSum = 0;

        foreach (int num in nums)
        {
            actualSum += num;
        }

        return expectedSum - actualSum;
    }

    /// <summary>
    /// Problem: Find a peak element in an array, which is an element that is strictly greater than its neighbors.
    /// </summary>
    /// <param name="nums">The input integer array.</param>
    /// <returns>The index of any peak element.</returns>
    public int FindPeakElement(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int mid = (left + right) / 2;

            if (nums[mid] > nums[mid + 1])
            {

                right = mid;
            }
            else
            {

                left = mid + 1;
            }
        }
        return left;
    }

    /// <summary>
    /// Problem: Sort an array of non-negative integers such that all even elements come before all odd elements.
    /// </summary>
    /// <param name="nums">The input integer array.</param>
    /// <returns>The modified array with even elements followed by odd elements.</returns>
    public int[] SortArrayByParity(int[] nums)
    {
        int[] result = new int[nums.Length];
        int evenIndex = 0;
        int oddIndex = nums.Length - 1;

        foreach (int num in nums)
        {
            if (num % 2 == 0)
            {
                result[evenIndex++] = num;
            }
            else
            {
                result[oddIndex--] = num;
            }
        }

        Array.Reverse(result, oddIndex + 1, nums.Length - oddIndex - 1);

        return result;
    }

    
}