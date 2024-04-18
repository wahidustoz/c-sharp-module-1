int x = 10;

// implicitly conversion - yashirin o'girish
long y = x;

// explicit conversion - ochiqcha o'girish
x = (int)3.4;
Console.WriteLine(x);

Console.WriteLine($"int - {{ {int.MinValue} - {int.MaxValue} }}");

// -----------

int a, b = 10, c;

a = 20;
c = b = a;

// Parse, TryParse

// ⚠️ Format Exception
// var sonTekst = "15a";
// var son = byte.Parse(sonTekst);

// ⚠️ Overflow Exception
// var sonTekst = "425";
// var son = byte.Parse(sonTekst);

// ✅
var sonTekst = "255";
var son = byte.Parse(sonTekst);

Console.WriteLine(son / 3); // 85

// TryParse
byte natija;     // default qiymati 0

bool parseQilaOldimi = byte.TryParse("0", out natija);
Console.WriteLine($"Natija: {natija}");
Console.WriteLine($"Parse qildimi: {parseQilaOldimi}");