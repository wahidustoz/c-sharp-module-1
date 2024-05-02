using Kichik_Shaxzoda_Masalasi;

Console.Write("Enter test cases: ");
var testCases = int.Parse(Console.ReadLine() ?? "0");

for(int i = 0; i < testCases; i++)
{
    var intersectionCount = 0;

    Console.Write("Enter coordinates of Prince and Princess: ");
    var coordinates = Console.ReadLine()!.
    Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray(); 

    var prince = new Point(coordinates![0], coordinates![1]);
    var princess = new Point(coordinates![2], coordinates![3]);

    Console.Write("Enter number of planets: ");
    var planetCount = int.Parse(Console.ReadLine() ?? "0");

    for(int j = 0; j < planetCount; j++)
    {
        Console.Write($"Enter planet number {j + 1}`s coordinates and radius: ");
        var planetCoordinates = Console.ReadLine()!
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

        var center = new Point(planetCoordinates![0], planetCoordinates![1]);
        var planet = new Circle(center, planetCoordinates![2]);

        var isPrinceInPlanet = planet.IsWithinCircle(prince);
        var isPrincessInPlanet = planet.IsWithinCircle(princess);

        // var kesishadimi = isPrinceInPlanet ^ isPrincessInPlanet; 

        // if(kesishadimi)
        //     intersectionCount++; 

        if(isPrinceInPlanet || isPrincessInPlanet)
            intersectionCount++;
    }
    Console.WriteLine($"Intersects {intersectionCount} times!");
}

