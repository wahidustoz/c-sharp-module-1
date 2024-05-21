using CSharpModule.Tasks;

namespace CSharpModule.Tests;

public class ArrayPracticeTests
{
    private readonly ArraySolutions solutions;

    public ArrayPracticeTests()
        => this.solutions = new ArraySolutions();

    #region Problem 1: Max Value in Array

    /// <summary>
    /// Problem: Given an array of integers, find the maximum value.
    /// Write a method in the Solutions class named MaxValueInArray that takes an integer array
    /// as input and returns the maximum value in the array.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 3, 5, 10, 7 }, 10)]
    [InlineData(new int[] { 100, 50, 20, 30 }, 100)]
    [InlineData(new int[] { -10, -5, -20, -100 }, -5)]
    [InlineData(new int[] { 0 }, 0)]
    [InlineData(new int[] { -5, -5, -5, -5 }, -5)]
    [InlineData(new int[] { 5, 5, 5, 5 }, 5)]
    [InlineData(new int[] { int.MinValue, int.MaxValue }, int.MaxValue)]
    [InlineData(new int[] { int.MaxValue, int.MaxValue, int.MaxValue }, int.MaxValue)]
    [InlineData(new int[] { int.MinValue, int.MinValue, int.MinValue }, int.MinValue)]
    [InlineData(new int[] { 0, int.MinValue, int.MaxValue }, int.MaxValue)]
    public void TestMaxValueInArray(int[] array, int expected)
    {
        Assert.Equal(expected, this.solutions.MaxValueInArray(array));
    }

    #endregion

    #region Problem 2: Reverse Array

    /// <summary>
    /// Problem: Given an array of integers, reverse it in-place.
    /// Write a method in the Solutions class named ReverseArray that takes an integer array
    /// as input and reverses the elements in the array.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
    [InlineData(new int[] { 40, 30, 20, 10 }, new int[] { 10, 20, 30, 40 })]
    [InlineData(new int[] { -5, 10, 0, -20 }, new int[] { -20, 0, 10, -5 })]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new int[] { 10 }, new int[] { 10 })]
    [InlineData(new int[] { -5, -10 }, new int[] { -10, -5 })]
    [InlineData(new int[] { int.MaxValue, int.MinValue }, new int[] { int.MinValue, int.MaxValue })]
    [InlineData(new int[] { int.MinValue, int.MinValue, int.MinValue }, new int[] { int.MinValue, int.MinValue, int.MinValue })]
    [InlineData(new int[] { int.MaxValue, int.MaxValue, int.MaxValue }, new int[] { int.MaxValue, int.MaxValue, int.MaxValue })]
    public void TestReverseArray(int[] array, int[] expected)
    {
        Assert.Equal(expected, this.solutions.ReverseArray(array));
    }

    #endregion

    #region Problem 3: Check if Array is Sorted

    /// <summary>
    /// Problem: Given an array of integers, determine if it is sorted in non-decreasing order.
    /// Write a method in the Solutions class named IsArraySorted that takes an integer array
    /// as input and returns true if the array is sorted in non-decreasing order, otherwise false.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, true)]
    [InlineData(new int[] { 5, 4, 3, 2, 1 }, false)]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, true)]
    [InlineData(new int[] { 10, 20, 30, 20, 50 }, false)]
    [InlineData(new int[] { }, true)]
    [InlineData(new int[] { 10 }, true)]
    [InlineData(new int[] { -5, -5, -5, -5 }, true)]
    [InlineData(new int[] { -10, -5, 0, 5 }, true)]
    [InlineData(new int[] { int.MaxValue, int.MaxValue, int.MaxValue }, true)]
    [InlineData(new int[] { int.MinValue, int.MaxValue, int.MinValue }, false)]
    public void TestIsArraySorted(int[] array, bool expected)
    {
        Assert.Equal(expected, this.solutions.IsArraySorted(array));
    }

    #endregion

    #region Problem 4: Sum of Even Numbers in Array

    /// <summary>
    /// Problem: Given an array of integers, find the sum of all even numbers.
    /// Write a method in the Solutions class named SumOfEvenNumbers that takes an integer array
    /// as input and returns the sum of all even numbers in the array.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 6)]
    [InlineData(new int[] { 10, 20, 30, 40 }, 100)]
    [InlineData(new int[] { -10, -5, -20, -100 }, -130)]
    [InlineData(new int[] { 0 }, 0)]
    [InlineData(new int[] { -5, -5, -5, -5 }, 0)]
    [InlineData(new int[] { 5, 5, 5, 5 }, 0)]
    [InlineData(new int[] { int.MinValue, int.MaxValue }, int.MinValue)]
    [InlineData(new int[] { int.MaxValue, int.MaxValue, int.MaxValue }, 0)]
    [InlineData(new int[] { int.MinValue, int.MinValue, int.MinValue }, int.MinValue)]
    [InlineData(new int[] { 0, int.MinValue, int.MaxValue }, int.MinValue)]
    public void TestSumOfEvenNumbers(int[] array, int expected)
    {
        Assert.Equal(expected, this.solutions.SumOfEvenNumbers(array));
    }

    #endregion

    #region Problem 5: Remove Duplicates from Sorted Array

    /// <summary>
    /// Problem: Given a sorted array of integers, remove duplicates in-place such that each element appears only once.
    /// Write a method in the Solutions class named RemoveDuplicates that takes a sorted integer array
    /// as input and modifies the array in-place to remove duplicates, returning the new length of the modified array.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2 }, 2)]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 }, 5)]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1 }, 1)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 }, 5)]
    [InlineData(new int[] { }, new int[] { }, 0)]
    [InlineData(new int[] { -5, -5, -5, -5 }, new int[] { -5 }, 1)]
    [InlineData(new int[] { int.MaxValue, int.MaxValue, int.MaxValue }, new int[] { int.MaxValue }, 1)]
    [InlineData(new int[] { int.MinValue, int.MaxValue }, new int[] { int.MinValue, int.MaxValue }, 2)]
    [InlineData(new int[] { -10, -5, 0, 5 }, new int[] { -10, -5, 0, 5 }, 4)]
    public void TestRemoveDuplicates(int[] array, int[] expectedArray, int expectedLength)
    {
        int length = this.solutions.RemoveDuplicates(array);
        Assert.Equal(expectedLength, length);
        for (int i = 0; i < length; i++)
        {
            Assert.Equal(expectedArray[i], array[i]);
        }
    }

    #endregion

    #region Problem 6: Rotate Array

    /// <summary>
    /// Problem: Given an array, rotate the array to the right by k steps, where k is non-negative.
    /// Write a method in the Solutions class named RotateArray that takes an integer array and an integer k
    /// as input and modifies the array in-place to rotate it to the right by k steps.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, new int[] { 3, 4, 5, 1, 2 })]
    [InlineData(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(new int[] { 1 }, 0, new int[] { 1 })]
    [InlineData(new int[] { }, 0, new int[] { })]
    [InlineData(new int[] { 1, 2 }, 1, new int[] { 2, 1 })]
    [InlineData(new int[] { -5, -5, -5, -5 }, 3, new int[] { -5, -5, -5, -5 })]
    [InlineData(new int[] { int.MaxValue, int.MaxValue, int.MaxValue }, 1, new int[] { int.MaxValue, int.MaxValue, int.MaxValue })]
    [InlineData(new int[] { int.MinValue, int.MaxValue }, 1, new int[] { int.MaxValue, int.MinValue })]
    public void TestRotateArray(int[] array, int k, int[] expected)
    {
        this.solutions.RotateArray(array, k);
        Assert.Equal(expected, array);
    }

    #endregion

    #region Problem 7: Merge Sorted Arrays

    /// <summary>
    /// Problem: Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
    /// The number of elements initialized in nums1 and nums2 are m and n respectively.
    /// Write a method in the Solutions class named MergeSortedArrays that takes three parameters:
    /// integer array nums1 (with enough space to hold additional elements), integer m (the number of elements initialized in nums1),
    /// integer array nums2 (length is n), and integer n (the number of elements initialized in nums2).
    /// The method should merge nums2 into nums1 as one sorted array.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
    [InlineData(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })]
    [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { -1, 0, 4 }, 3, new int[] { -1, 0, 1, 2, 3, 4 })]
    [InlineData(new int[] { 4, 5, 6, 0, 0, 0 }, 3, new int[] { 1, 2, 3 }, 3, new int[] { 1, 2, 3, 4, 5, 6 })]
    [InlineData(new int[] { }, 0, new int[] { }, 0, new int[] { })]
    public void TestMergeSortedArrays(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        this.solutions.MergeSortedArrays(nums1, m, nums2, n);
        Assert.Equal(expected, nums1);
    }

    #endregion

    #region Problem 8: Find Missing Number

    /// <summary>
    /// Problem: Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.
    /// Write a method in the Solutions class named FindMissingNumber that takes an integer array nums containing n distinct numbers
    /// as input and returns the missing number.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 3, 0, 1 }, 2)]
    [InlineData(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
    [InlineData(new int[] { 0 }, 1)]
    [InlineData(new int[] { 1 }, 0)]
    [InlineData(new int[] { 1, 2, 3 }, 0)]
    [InlineData(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 9)]
    [InlineData(new int[] { 1, 0, 3, 2, 5, 6, 7, 9, 8 }, 4)]
    public void TestFindMissingNumber(int[] nums, int expected)
    {
        Assert.Equal(expected, this.solutions.FindMissingNumber(nums));
    }

    #endregion

    #region Problem 9: Find Peak Element

    /// <summary>
    /// Problem: A peak element in an array is an element that is strictly greater than its neighbors.
    /// Given an integer array nums, find a peak element, and return its index. If the array contains multiple peaks,
    /// return the index to any of the peaks. You may imagine that nums[-1] = nums[n] = -∞.
    /// Write a method in the Solutions class named FindPeakElement that takes an integer array nums
    /// as input and returns the index of any peak element.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 }, 2)] // Peak is at index 2
    [InlineData(new int[] { 1, 2, 1, 3, 5, 6, 4 }, 5)] // Peak is at index 5
    [InlineData(new int[] { 1, 2, 3 }, 2)] // Peak is at index 2
    [InlineData(new int[] { 1, 2, 1, 2, 1 }, 3)] // Peak is at index 1 or 3
    public void TestFindPeakElement(int[] nums, int expected)
    {
        Assert.Equal(expected, this.solutions.FindPeakElement(nums));
    }

    #endregion

    #region Problem 10: Sort Array By Parity

    /// <summary>
    /// Problem: Given an array nums of non-negative integers, return an array consisting of all the even elements of nums,
    /// followed by all the odd elements of nums. You may return any answer array that satisfies this condition.
    /// Write a method in the Solutions class named SortArrayByParity that takes an integer array nums as input
    /// and returns the modified array with all even elements followed by all odd elements.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 3, 1, 2, 4 }, new int[] { 2, 4, 3, 1 })]
    [InlineData(new int[] { 0, 2, 1, 3 }, new int[] { 0, 2, 1, 3 })]
    [InlineData(new int[] { 2, 4, 6, 8 }, new int[] { 2, 4, 6, 8 })]
    [InlineData(new int[] { 1, 3, 5, 7 }, new int[] { 1, 3, 5, 7 })]
    [InlineData(new int[] { 2 }, new int[] { 2 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 2, 4, 6, 1, 3, 5 })]
    public void TestSortArrayByParity(int[] nums, int[] expected)
    {
        Assert.Equal(expected, this.solutions.SortArrayByParity(nums));
    }

    #endregion
}
