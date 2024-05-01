namespace CSharpModule.Playground;

public readonly struct Student(string fullname, DateOnly birthday, int score)
{
    public string Fullname { get; init; } = fullname;
    public DateOnly Birthday { get; init; } = birthday;
    public int Score { get; init; } = score;
    public int Age => 
        DateOnly.FromDateTime(DateTime.Now).Year - Birthday.Year;
    public EGrade Grade => Score switch
    {
        >= 90 => EGrade.A,
        >= 80 => EGrade.B,
        >= 70 => EGrade.C,
        >= 60 => EGrade.D,
        _ => EGrade.F
    };

    // public Student(string fullName, DateOnly birthDate, int score) =>
    //     (FullName, BirthDate, Score) = (fullName, birthDate, score);

    public override string ToString() =>
        $"Fullname: {Fullname}, Birthday: {Birthday}, Score: {Score}, Age: {Age}, Grade: {Grade}";
}

public enum EGrade
{
    A, B, C, D, F
}