using CSharpModule.Tasks;
using FluentAssertions;

namespace CSharpModule.Tests;

public class ExampleTests
{
    private readonly Example example;

    public ExampleTests()
    {
        this.example = new Example();
    }


    [Theory]
    [MemberData(nameof(TestArrays))]
    public void ShouldReverseArray(int[] original, int[] reversed)
    {
        var reversedByMethod = this.example.ReverseArray(original);

        reversedByMethod.Should().NotBeEmpty()
            .And.HaveCount(original.Length)
            .And.ContainInOrder(reversed);
    }

    public static object[][] TestArrays = 
    [
        [new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 }],
        [new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1}]
    ];
}