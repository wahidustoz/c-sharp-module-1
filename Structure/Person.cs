namespace CSharpModule.Structure;

public readonly unsafe struct Person
{
    public string Name { get; init; }
    public int Age { get; init; } = 17;
    public Person* Father { get; init; } = null;

    public Person(string name, int age, Person* father = null) 
    {
        Name = name;
        Age = age;
        Father = father;
    }

    public override string ToString() => 
        $"Name: {Name}, Age: {Age}, Father: {(Father == null ? "null" : (*Father).ToString())}";
}