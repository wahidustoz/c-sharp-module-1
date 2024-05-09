// jagged arraylar - jagged arraylar

// int[][] jaggedArray =
// [
//     new int[] { 1, 2, 3 }, 
//     [  1, 2, 3 ]
// ];

var sonlar = new int[3][];

sonlar[0] = [ 1, 2, 3, 0, 0, 0 ];
sonlar[1] = new int[] { 4, 5, 6 };
sonlar[2] = [1];

for(int row = 0; row < sonlar.Length; row++)
{
    for (int col = 0; col < sonlar[row].Length; col++)
    {
        Console.Write($"{sonlar[row][col]} ");
    }

    Console.WriteLine();
    
}



void MultiDArray()
{
    // multidimentional arraylar - ko'p o'lchamli massivlar

    // 1. doim tortburchak shaklda boladi. 

    int[,] matrix =
    {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }

        Console.WriteLine();
    }
}

void Arraylar_Part1()
{
    // 1. reference type
    // 2. elementarli default qiymatga ega boladi
    // 3. array elon qilingandan keyin hajmi o'zgarmaydi
    // 4. elementlar indeks orqali murojat qilinadi va indeks 0dan boshlanadi
    // 5. System.Array klasidan keladi va u reference type

    // int[] sonlar = new int[2];
    // string[] mevalar = new string[3];

    // int[] sonlar = new int[] { 1, 2, 3 };
    // string[] mevalar = new string[] { "olma", "anor", "nol" };

    // int[] sonlar =  { 1, 2, 3 };
    // string[] mevalar = { "olma", "anor", "nol" };

    // var sonlar =  new int[] { 1, 2, 3 };
    // var mevalar = new string[] { "olma", "anor", "nol" };

    int[] sonlar = [1, 2, 3];
    string[] mevalar = ["olma", "anor", "nol"];

    Console.WriteLine(sonlar[1]);

    sonlar[1] = 7;
    Console.WriteLine(sonlar[1]);

    // for(int indeks = 0; indeks < mevalar.Length; indeks++)
    //     Console.WriteLine(mevalar[indeks]);

    // for(int indeks = mevalar.Length - 1; indeks >= 0; indeks--)
    //     // Console.WriteLine(mevalar[indeks]);
    //     mevalar[indeks] = "nok";

    // foreach(var meva in mevalar)
    //     Console.WriteLine(meva);

    ReadNumbers(sonlar);

    foreach (var son in sonlar)
        Console.WriteLine(son);


    void ReadNumbers(int[] sonlar)
    {
        for (int i = 0; i < sonlar.Length; i++)
        {
            Console.Write("Son kiriting: ");
            sonlar[i] = int.Parse(Console.ReadLine() ?? "0");
        }
    }
}
