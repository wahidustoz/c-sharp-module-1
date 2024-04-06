// bool -  true/false qiymatni saqlash uchun ishlatiladi
// bool x = true;
// bool y = false;

// byte - 1 byte { 0, 255 } qiymatni saqlash uchun ishlatiladi
// byte x = 1;
// byte y = 255;
// byte z = 256;  // 256 soni byte uchun juda katta
// byte z = -1;  // byte faqat musbat sonlar qabul qiladi

// sbyte - (signed byte-ishorali byte) 1 byte { -128, 127 } qiymatni saqlash uchun ishlatiladi
// sbyte x = -128;
// sbyte y = 127;
// sbyte z = 128;  // 128 soni sbyte uchun juda katta
// sbyte z = -129;  // sbyte faqat musbat sonlar qabul qiladi

// short - 2 byte { -32768, 32767 } qiymatni saqlash uchun ishlatiladi
// short x = -32768;
// short y = 32767;

// ushort - 2 byte { 0, 65535 } qiymatni saqlash uchun ishlatiladi
// ushort x = 0;
// ushort y = 65535;

// int - 4 byte { -2147483648, 2147483647 } qiymatni saqlash uchun ishlatiladi
// int x = -2147483648;
// int y = 2147483647;

// uint - 4 byte { 0, 4294967295 } qiymatni saqlash uchun ishlatiladi
// uint x = 0;
// uint y = 4294967295;

// long - 8 byte { -9223372036854775808, 9223372036854775807 } qiymatni saqlash uchun ishlatiladi
// long x = -9223372036854775808;
// long y = 9223372036854775807;

// ulong - 8 byte { 0, 18446744073709551615 } qiymatni saqlash uchun ishlatiladi
// ulong x = 0;
// ulong y = 18446744073709551615;


// BigInteger - bu data tipning mantiqiy chegarasi yo'q


// using System.Numerics;

// BigInteger kattaSon = BigInteger.Parse("12312312312312313123123123123123123123123123123131231231231231231231231231231231312312312312312312312312312312313123123123123123");
// Console.WriteLine((kattaSon * 10000).ToString());

// var kiritalganTekst = Console.ReadLine();
// var son = int.Parse(kiritalganTekst);
// var natija = son / 10;
// Console.WriteLine(natija);

var kiritilganTekst = Console.ReadLine();
int son;
bool parseQildimi = int.TryParse(kiritilganTekst, out son);

Console.WriteLine($"Parse qildimi: {parseQildimi}");
Console.WriteLine($"Son: {son}");

// void change(out int a)
// {
//     a = 15;
// }

// int son = 10;
// change(out son);

// Console.WriteLine(son);
