
using CSharpModule.EnumType;

// var day = EWeekDays.Tuesday;
// Enum.TryParse<EWeekDays>("monday", out var monday);
// var monday2 = Enum.Parse<EWeekDays>("monday", ignoreCase: true);

// Console.WriteLine(monday);
// Console.WriteLine(monday2);

// Console.WriteLine((int)day);
// Console.WriteLine(day);


// FLAGS

// var days = Enum.GetValues(typeof(EWeekDays));
// var randomDay = (EWeekDays)(new Random().Next(0, days.Length));

// var weekend = EWeekDays.Saturday | EWeekDays.Sunday;
// Console.WriteLine(weekend);

// if(randomDay is EWeekDays.Weekend)
// {
//     Console.WriteLine($"{randomDay} is weekend.");
// }
// Console.WriteLine($"{randomDay} is weekend.");

Console.WriteLine((int)EWeekDays.Weekend);


decimal CalculateParkingFee(EWeekDays day)
{
    // if(day is EWeekDays.Saturday or EWeekDays.Sunday)
    //     return 10_000;
    // else if(day is EWeekDays.Monday or EWeekDays.Wednesday or EWeekDays.Friday)
    //     return 8_000;
    // else
    //     return 5_000;

    var specialDay = EWeekDays.Monday | EWeekDays.Wednesday | EWeekDays.Friday;
    
    // if(day.HasFlag(EWeekDays.Weekend))
    //     return 10_000;
    // else if(day.HasFlag(specialDay))
    //     return 8_000;
    // else
    //     return 5_000;

    return day switch
    {
        EWeekDays.Weekend => 10_000,
        EWeekDays.Monday or EWeekDays.Wednesday or EWeekDays.Friday => 8_000,
        _ => 5_000
    };
}