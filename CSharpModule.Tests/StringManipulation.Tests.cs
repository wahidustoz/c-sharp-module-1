using CSharpModule.Tasks;

namespace CSharpModule.Tests;

public class StringManipulationTests
{
    private readonly StringManipulation stringManipulation;

    public StringManipulationTests()
        => this.stringManipulation = new StringManipulation();

    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("world", "dlrow")]
    public void ReverseWithStringBuilderSHouldWork(string input, string output) 
        => Assert.Equal(output, this.stringManipulation.Reverse(input));
    
}