// // assignment operators (=) - o'zlashtirish operatori
// // 1. bu operatorni chap tarafida doim o'zgaruvchi turadi
// // 2. variable = value | variable | expression

// var a = 10;             // variable = value
// var b = a;              // variable = variable
// var c = a + (b * 10);   // variable = expression 

// // compound assignment operators
// var son = 10;
// son += 10;      // son = son + 10; // 20
// son -= 10;      // son = son - 10; // 10
// son *= 10;      // son = son * 10; // 100
// son /= 10;      // son = son / 10; // 10
// son %= 10;      // son = son % 10; // 0

// // increment/decrement - sonning qiymatini 1ga oshirish yoki kamaytirish
// son++;              // son += 1;       // son = son + 1;
// son--;              // son -= 1;       // son = son - 1;

// // postfix increment/decrement - amalni bajarish va keyin qiymatni 1ga oshirish/kamaytirish
// // agar  ++/-- expressino ichida o'zgaruvchidan keyin kelsa, 
// // bu amal boshqa operatsiyalardan keyin bajariladi
// son = 0;
// var natija = son++;
// Console.WriteLine($"Son = {son++}");
// Console.WriteLine($"Natija = {natija}");
// Console.WriteLine($"Son = {son}");

// // prefix increment/decrement - qiymatni 1ga oshirish/kamaytirish va keyin boshqa amallarni bajarish
// son = 0;
// var result = ++son;
// Console.WriteLine($"Son = {son}");
// Console.WriteLine($"Result = {result}");

// var x = 0;
// var y = 0;
// var z = 0;
// z = ++x + y++;
// Console.WriteLine(x);
// Console.WriteLine(y);
// Console.WriteLine(z);

// // chain assignment
// x = y = z = 15;

// // xato: x = y + 1 = z = 15;


// // arithmetic operators - +,-,*,/,%
// Console.WriteLine("-------------- Arithmetic operators --------------");
// Console.WriteLine(10 + 5);
// Console.WriteLine(10 - 5);
// Console.WriteLine(10 * 5);
// Console.WriteLine(10 / 5);
// Console.WriteLine(10 % 5);

// // integer division - butun bo'lish
// // butun sonni butun songa bo'lganda natija ham butun son chiqadi
// // var quotient = 10 / 3;      // 3
// // var quotient2 = 10.3 / 3;    // 3.33333333

// // comparison operators -  solishtirish operatorlari
// // 1. qiymatlarni solishtiradi va true/false natija beradi

// a = 10;
// b = 15;
// Console.WriteLine(a > b);   // false
// Console.WriteLine(a >= b);  // false
// Console.WriteLine(a < b);   // true
// Console.WriteLine(a <= b);  // true
// Console.WriteLine(a == b);  // false
// Console.WriteLine(a != b);  // true

// // logical operators - mantiqiy operatorlar
// // 1. && - ikkala taraf ham true bo'lsa true qaytaradi, yo'qsa false qaytaradi
// // 2. || - hech bo'lmaganda bitta tarafi true bo'lsa true qaytaradi, yo'qsa false qaytaradi
// // 3. ! - true bo'lsa false qaytaradi, false bo'lsa true qaytaradi

// Console.WriteLine($"true && true = {true && true}");
// Console.WriteLine($"true && false = {true && false}");
// Console.WriteLine($"false && true = {false && true}");
// Console.WriteLine($"false && false = {false && false}");
// Console.WriteLine($"true || true = {true || true}");
// Console.WriteLine($"true || false = {true || false}");
// Console.WriteLine($"false || true = {false || true}");
// Console.WriteLine($"false || false = {false || false}");
// Console.WriteLine($"!true = {!true}");
// Console.WriteLine($"!false = {!false}");

// // bitta belgi o'qing. agar belgi harf bo'lsa True yo'qsa False deb chop eting
// var belgi = (char)Console.Read();
// var kichikHarfmi = belgi >= 'a' && belgi <= 'z';
// var kattaHarfmi = belgi >= 65 && belgi <= 90;
// var harfmi = kichikHarfmi || kattaHarfmi;

// Console.WriteLine(kichikHarfmi);
// Console.WriteLine(kattaHarfmi);
// Console.WriteLine(harfmi);

// ternary operator
// 3 ta qismdan iborat
// condition ? true_value : false_value

// var i = int.Parse(Console.ReadLine()!);
// var j = int.Parse(Console.ReadLine()!);

// var kattasi = i > j ? i : j;
// Console.WriteLine(kattasi);

// bitta belgi o'qing
// agar belgi kichik harf bo'lsa lowercase deb
// agar belgi katta harf bo'lsa uppercase deb

var belgi = (char)Console.Read();
var kattaHarf = belgi >= 65 && belgi <= 90;
var kichikHarf = belgi >= 'a' && belgi <= 'z';

Console.WriteLine(kattaHarf ? "uppercase" : "lowercase");


// bitwise operators
 