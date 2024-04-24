using System.Text;

namespace CSharpModule.Tasks;

public class Challenges
{
    public string FormalName(string firstName, string lastName, bool isMale)
    {
        var formalNameBuilder = new StringBuilder();
        // ternary operator

        formalNameBuilder.Append(isMale ? "Mr. " : "Ms. ");
        // jOHN -> J
        formalNameBuilder.Append(firstName.Substring(0, 1).ToUpper());
        // jOHN -> ohn
        formalNameBuilder.Append(firstName.Substring(1, firstName.Length - 1).ToLower());
        // dOE -> D
        formalNameBuilder.Append(lastName.Substring(0, 1).ToUpper());
        // dOE -> oe
        formalNameBuilder.Append(lastName.Substring(1, lastName.Length - 1).ToLower());


        // Mr. John Doe
        return formalNameBuilder.ToString();
    }

    // CTRL + { yoki CTRL + }
}