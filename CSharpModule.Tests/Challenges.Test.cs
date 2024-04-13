namespace CSharpModule.Tasks;
public class ChallengesTests
{

    private readonly Challenges challenges;

    public ChallengesTests() => challenges = new Challenges();
    
    // 1 - masala 
    [Theory]
    [InlineData(65, 23725)]
    [InlineData(0, 0)]
    [InlineData(20, 7300)]
    public void AgeInDays_Returns_CorrectDays(int ageInYears, int expectedDays)
      =>  Assert.Equal(expectedDays, challenges.AgeInDays(ageInYears));
    

    // 2 - masala 
    [Theory]
    [InlineData(1, 1, 5)]
    [InlineData(7, 5, 29)]
    [InlineData(38, 8, 100)]
    public void CalculateTotalScore_Returns_CorrectScore(int twoPointers, int threePointers, int expectedScore)
        =>  Assert.Equal(expectedScore, challenges.CalculateTotalScore(twoPointers, threePointers));

    // 3 - masala 
    [Theory]
    [InlineData("john", "DOE", true, "Mr. John Doe")]
    [InlineData("wahid", "AbDuHaKimOv", true, "Mr. Wahid Abduhakimov")]
    [InlineData("hermione", "Granger", false, "Mrs. Hermione Granger")]
    public void FormalName_Returns_CorrectFormalName(string firstName, string lastName, bool isMale, string expectedFormalName)
      =>  Assert.Equal(expectedFormalName, challenges.FormalName(firstName, lastName, isMale));
}