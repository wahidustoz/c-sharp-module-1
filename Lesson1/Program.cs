// // variable - o'zgaruvchi

// int son;    // declaration - e'lon qilish
// son = 11;   // assignment - qiymat o'zlashtirish

// // int sanoq = 1;      // intialization - elon qilib qiymat berish

// // int a, b, c;        // bir xil tipdagi bir necha o'zgaruvchini
//                     // bitta qatorda e'lon qilsa boladi

// // int son = 15;       // error: o'zgaruvchi ismini qayta ishlatish mumkin emas
// // float harorat = 36.6, int x;    // error: bitta qatorda bir necha xildagi 
//                                    // o'zgarvuchi elon qilish mumkin emas.

// // nomlash qoidalari
// // 1. nomda alifbo harflari, raqamlar va underscore (_) ishlatish mumkin
// // 2. nomning birinchi belgisi raqam bo'la olmaydi
// // 3. nomda maxsus belgilar bo'lsihi mumkin emas.
// // 4. maxsus kalit so'zlardan nom sifatida foydalanish mumkin emas.

// // int katta son;      // error: o'rtasida bo'sha katak bor
// // int #raqam;         // error: maxsus belgi ishaltish mumkin emas.
// // int 2024best;       // error: birinchi belgi raqam bo'lishi mumkin emas
// // int while;          // error: while kalit so'zi ishlatilgan

// // char belgi9 = '9';


// // casing rules - katta harf va kichik harf bilan ishlash
// // local o'zgaruvchilar camelCase o'rqali yoziladi
// // propertylar, class nomlari, method nomlari PascalCase orqali yoziladi
// // constant qiymatga ega o'zgaruvchilar UPPERCASE o'rqali yoziladi

// // int kattaSon = 12312323;
// // const float PI = 3.14;

// // public class Student
// // {
// //     public string FullName { get; set; }
// // }


// // scope - hudud qoidalari

// if(true)
// {
//     int y = 20;
// }

// Console.WriteLine(son);

// // void PrintHello()
// // {
// //     int x = 15;

// //     Console.WriteLine(x);
// // }

// // Console.WriteLine(x);

// Console.WriteLine("Hello World!");

using System.Globalization;

NumberStyles number = new Numbers();