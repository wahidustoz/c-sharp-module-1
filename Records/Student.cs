// 1. data-centric, encapsulation, DTO - data transfer object
// 2. reference type
// 3. init-only property yaratadi; immutable

public record Student(string Fullname, int Age, int Score);

// value type
public record struct Point(int X, int Y);

public record Teacher(string Subject, string Name);