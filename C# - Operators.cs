// Operatör Nedir?
// Mantıksal, metinsel ve sayısal işlemleri yapmamızı sağlayan işaret ve ifade guruplarıdır.

// Operatör Çeşitleri Nelerdir?

// 1. Aritmetik Operatörler : Matematiksel işlemler yapmamızı sağlayan operatörlerdir.
int number1 = 10;
int number2 = 5;

int result = number1 + number2;  // (+) işareti sayısal 2 değer için toplama işlemini yapar. 
// Not : Metinsel 2 değeri yan yana yazarak birleştirir. (result = "Hello" + " " + "World")
result = number1 - number2;  // (-) işareti sayısal 2 değer için çıkarma işlemini yapar.
result = number1 * number2;  // (*) işareti sayısal 2 değer için çarpma işlemini yapar.
result = number1 / number2;  // (/) işareti sayısal 2 değer için bölme işlemini yapar.
result = number1 % number2;  // (%) işareti sayısal 2 değer için mod alma işlemini yapar.
number++;                    // (++) sayıyı 1 arttırır.
number--;                    // (--) sayıyı 1 eksiltir.

// 2. Atama Operatörleri : Bir değişkenin içine değer atarken kullandığımız yapılardır. 
// Not : (=) işaretide bir atama operatörüdür. Eşittirin sağındaki değeri solundaki değerin içine atar.

// number1 = number1 + number2;
number1 += number2;  // (+=) işareti eşittirin solundaki değer ile sağındaki değeri toplayarak solundaki değişkene atar.
// number1 = number1 - number2;
number1 -= number2;  // (-=) işareti eşittirin solundaki değerden sağındaki değeri çıkartarak solundaki değişkene atar.
// number1 = number1 * number2;
number1 *= number2;  // (*=) işareti eşittirin solundaki değer ile sağındaki değeri çarparak solundaki değişkene atar.
// number1 = number1 / number2;
number1 /= number2;  // (/=) işareti eşittirin solundaki değer ile sağındaki değeri bölerek solundaki değişkene atar.

// 3. Karşılaştırma Operatörleri : Birden fazla değişkenin değerlerinin karşılaştırılması için kullanılan yapılardır. Bool bir değer döndürür.

result = number1 == number2; // (==) işareti EŞİT Mİ? anlamına gelir. İşaretin sağındaki değer ile solundaki değerin birbirine eşit olup olmadığına bakar.
result = number1 != number2; // (!=) işareti EŞİT DEĞİL Mİ? anlamına gelir. İşaretin sağındaki değer ile solundaki değerin birbirine eşit olmadığına bakar.
result = number1 < number2;  // (<) işareti KÜÇÜK MÜ? anlamına gelir. İşaretin sağındaki değerin solundaki değerden küçük olup olmadığına bakar.
result = number1 > number2;  // (>) işareti BÜYÜK MÜ? anlamına gelir. İşaretin sağındaki değerin solundaki değerden büyük olup olmadığına bakar.
result = number1 <= number2; // (<=) işareti KÜÇÜK MÜ veya EŞİT Mİ? anlamına gelir. İşaretin sağındaki değerin solundaki değere küçük veya eşit olup olmadığına bakar.
result = number1 >= number2; // (>=) işareti BÜYÜK MÜ veya EŞİT Mİ? anlamına gelir. İşaretin sağındaki değerin solundaki değerden büyük veya eşit olup olmadığına bakar.

// 4. Mantıksal Operatörler : Ve, veya anlamlarında kullanılan operatörlerimizdir.

/*
&& : Ve anlamına gelir.
|| : Veya anlamına gelir.
!  : Değil anlamına gelir.
*/