using CSharpModule.Tasks;
using FluentAssertions;

namespace CSharpModule.Tests;

public class GreetingTests
{
    private readonly Greeting greeting;

    public GreetingTests()
        => this.greeting = new Greeting();

    
    [Fact]
    public void ShouldGreet()
    {
        var expectedGreeting = "Hello world 👋";
        var actualGreeting = this.greeting.Greet();

        actualGreeting.Should().BeEquivalentTo(expectedGreeting);
    }
}