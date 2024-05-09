// using CSharpModule.Tasks;

// namespace CSharpModule.Tests;

// public class StringOperationsTests
// {
//     private readonly StringOperations solutions;

//     public StringOperationsTests() => solutions = new StringOperations();

//     [Theory]
//     [InlineData("hello", "olleh")]
//     [InlineData("world", "dlrow")]
//     [InlineData("", "")]
//     [InlineData("a", "a")]
//     [InlineData("12345", "54321")]
//     public void Reverse_ShouldReverseString(string input, string expected)
//     {
//         // Arrange

//         // Act
//         string result = solutions.Reverse(input);

//         // Assert
//         Assert.Equal(expected, result);
//     }

//     [Theory]
//     [InlineData("silent", "listen", true)]
//     [InlineData("hello", "world", false)]
//     [InlineData("", "", true)]
//     [InlineData("12345", "54321", true)]
//     [InlineData("abc", "cba", true)]
//     public void AreAnagrams_ShouldReturnCorrectResult(string str1, string str2, bool expected)
//     {
//         // Arrange

//         // Act
//         bool result = solutions.AreAnagrams(str1, str2);

//         // Assert
//         Assert.Equal(expected, result);
//     }

//     [Theory]
//     [InlineData("forgeeksskeegfor", "geeksskeeg")]
//     [InlineData("abracadabra", "aca")]
//     [InlineData("aba", "aba")]
//     [InlineData("abcd", "a")]
//     [InlineData("racecar", "racecar")]
//     public void LongestPalindromeWithin_ShouldReturnLongestPalindrome(string str, string expected)
//     {
//         // Arrange

//         // Act
//         string result = solutions.LongestPalindromeWithin(str);

//         // Assert
//         Assert.Equal(expected, result);
//     }

//     [Theory]
//     [InlineData("hello", "helo")]
//     [InlineData("world", "world")]
//     [InlineData("abracadabra", "abrcd")]
//     [InlineData("aaaa", "a")]
//     [InlineData("", "")]
//     public void RemoveDuplicates_ShouldRemoveDuplicates(string input, string expected)
//     {
//         // Arrange

//         // Act
//         string result = solutions.RemoveDuplicates(input);

//         // Assert
//         Assert.Equal(expected, result);
//     }

//     [Theory]
//     [InlineData("race car", true)]
//     [InlineData("race a car", false)]
//     [InlineData("A man, a plan, a canal: Panama", true)]
//     [InlineData("hello", false)]
//     [InlineData("", true)]
//     public void IsValidPalindrome_ShouldReturnCorrectResult(string str, bool expected)
//     {
//         // Arrange

//         // Act
//         bool result = solutions.IsValidPalindrome(str);

//         // Assert
//         Assert.Equal(expected, result);
//     }

//     [Theory]
//     [InlineData("hello", 'h')]
//     [InlineData("abracadabra", 'c')]
//     [InlineData("acd", 'a')]
//     [InlineData("abcdefghijklmnopqrstuvwxyz", 'a')]
//     [InlineData("aabcc", 'b')]
//     public void FirstNonRepeatedCharacter_ShouldReturnCorrectCharacter(string str, char expected)
//     {
//         // Arrange

//         // Act
//         char result = solutions.FirstNonRepeatedCharacter(str);

//         // Assert
//         Assert.Equal(expected, result);
//     }

//     [Theory]
//     [InlineData("aabcccccaaa", "a2b1c5a3")]
//     [InlineData("aabbcc", "a2b2c2")]
//     [InlineData("", "")]
//     [InlineData("abcd", "a1b1c1d1")]
//     [InlineData("aaaaaaaaaa", "a10")]
//     public void Compress_ShouldCompressString(string str, string expected)
//     {
//         // Arrange

//         // Act
//         string result = solutions.Compress(str);

//         // Assert
//         Assert.Equal(expected, result);
//     }
// }