namespace CSharpModule.EnumType;

[Flags]
public enum EWeekDays
{
    Monday = 0,
    Tuesday = 1, 
    Wednesday = 2,
    Thursday = 4,
    Friday = 8,
    Saturday = 16,
    Sunday = 32,
    Weekend = Saturday | Sunday
}