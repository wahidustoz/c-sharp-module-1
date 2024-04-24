var belgi = Console.Read();

// && - short-circuiting
// & - ikkila tarafni ham tekshiradi
if(belgi is >= '0' and <= '9') // belgi >= '0' && belgi <= '9'
    Console.WriteLine("Son");
else
    Console.WriteLine("Belgi");

bool IsLetter(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');
bool IsDigit(char c) => false; // sizlar uchun :)

void ReadNullableInt()
{
    var son = GetNumberOrDefault(Console.ReadLine());

    if(son is null)
    {
        Console.WriteLine("Son olishda xatolik yuz berdi");
    }
    else
    {
        Console.WriteLine($"Son = {son}");
    }

    int? GetNumberOrDefault(string? text)
    {
        try
        {
            return int.Parse(text!);
        }
        catch (Exception ex)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Failed to parse text into integer.");
            Console.ForegroundColor = originalColor;

            return null;
        }
    }
}
void SwitchSample()
{
    object son = Console.ReadLine();

    switch(son)
    {
        case int i:
            Console.WriteLine("Integer");
            break;
        case string s:
            Console.WriteLine("String");
            break;
    }
}
void PatternMatchingSample()
{
    object obj = 10;

    switch(obj)
    {
        case int: 
            Console.WriteLine("Integer");
            break;
        case string s:
            Console.WriteLine("String");
            break;
    }


    // casts the type into int, returns true if successeful
    if(obj is int)
    {
        Console.WriteLine("Integer");
    }
    else if(obj is string)
    {
        Console.WriteLine("String");
    }
}
void PrintSon()
{
    // 0~9 oraliqda bitta son o'qing 
    // va uni ingliz tilida chop eting

    var son = int.Parse(Console.ReadLine() ?? "0");

    // if(son == 0)
    //     Console.WriteLine("zero");
    // else if(son == 1)
    //     Console.WriteLine("one");
    // //...
    // else if(son == 9)
    //     Console.WriteLine("nine");
    // else 
    //     Console.WriteLine("other");


    switch(son)
    {
        case 0:
            Console.WriteLine("zero");
            break;
        case 1: 
            Console.WriteLine("one");
            break;
        case 2: 
            Console.WriteLine("two");
            break;
        default:
            Console.WriteLine("other");
            break;
    }
}