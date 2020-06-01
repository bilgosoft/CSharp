/*
Değişken Nedir?
İngilizcede variable olarak adlandırılan değişkenler bellek üzerinde tutulmasını istediğimiz verileri tutmamızı sağlayan yapıdır.

Değişken Nasıl Tanımlanır?
Değişken tanımlamak için önce bir isim vermemiz gerkiyor bu ismi verebilmemiz için aşağıdaki değişken tanımlama kurallarına göz atınız.
1. Yöntem : DegiskenTipi DegiskenIsmi = DegiskenDegeri;

2. Yöntem : DegiskenTipi DegiskenIsmi; 
            DegiskenIsmi = DegiskenDegeri;

Değişken Tanımlama Kuralları
1. Türkçe karakter kullanılamaz.(Değişken tanımlamalarının ingilizce olarak tanımlanması daha uygundur.)
2. Bir değişken sayı ile bitebilir. Ama sayı ile başlayamaz
3. Değişken isimlerinde özel karakterler(?, =, vb.) kullanılamaz.

Değişken Türleri Nelerdir?

1- Tam Sayı Veri Türleri
    byte 	 : Uzunluğu 1 byte’tır, 0 ile 255 arasında değer alır. 														(byte n1 = 1;)
    sbyte 	 : Uzunluğu 1 byte’tır, -128 ile 127 arasında değer alır. 													(sbyte n1 = 1;)
    short 	 : Uzunluğu 2 byte’tır, -32768 ile 32767 arasında değer alır. 												(short n1 = 1;)
    ushort 	 : Uzunlupu 2 byte’tır, 0 ile 65535 arasında değer alır. 													(ushort n1 = 1;)
    int 	 : Uzunluğu 4 byte’tır, -2.147.483.648 ile 2.147.483.648 arasında değer alır. 								(int n1 = 1;)
    uint  	 : Uzunluğu 4 byte’tır, 0 ile 4.294.967.295 arasında değer alır. 											(uint n1 = 1;)
    long  	 : Uzunluğu 8 byte’tır, -9223372036854775808 ile 9223372036854775807 arasında değer alır. 					(long n1 = 1;)
    ulong  	 : Uzunluğu 8 byte’tır, 0 ile 18446744073709551615 arasında değer alır. 									(ulong n1 = 1;)

2- Ondalıklı Sayı Veri Türleri
    float  	 : Uzunluğu 4 byte’tır, 1.5 x 10-45 ile 3.4 x 1038 arasında değer alır. 									(float n1 = 1f;)
    double   : Uzunluğu 8 byte’tır, 5.0 x 10-324 ile 1.7 x 10308 arasında değer alır. 									(double n1 = 1;)
    decimal  : Uzunluğu 12 byte’tır, ±1.0 x 10-28 ile ±7.9 x 1028 arasında değer alır. 									(decimal n1 = 1m;)

3- Metinsel Veri Türleri
    char 	 : Uzunluğu 2 byte’tır, Bütün unicode karakterleri kapsar. 													(char n1 = '1';)
    string 	 : Tek bir karakter, sözcük veya cümle gibi değerlerin saklanmasında kullanılır. 							(string n1 = "1";)

4- Mantıksal Veri Türü
    bool 	 : True – false değer tutan tiptir. 																		(bool n1 = True;)

5- Specific Veri Türleri
nullable : Bir değişkenin değerini null yapmak için kullanılır.														(int? n1 = null;;)
variable : Bir değişken tanımlarken gelecek değer tipini bilmediğimizde kullanırız. İlk değerden sonra değişemez	(var n1 = 1;)
object   : Bir değişken tanımlarken gelecek değer tipini bilmediğimizde kullanırız. İlk değerden sonra değişebilir.	(var n1 = 1;)
enum     : Bir değişkeni 1 kez belirleriz sonrasında tek yerden değiştiririz.										(enum n1 {Bir = 1}) >>> Console.Write(n1.Bir);
*/

// En Çok Kullanılan Değişken Tanımlamaları
// 1- Short
short number1 = 5;

// 2- Integer
int number2 = 5; 

// 3- Long
long number3 = 5;   

// 4- Float
float number4 = 5.0f;   

// 5- Decimal
decimal number5 = 5.0m;   

// 6- Double
double number6 = 5.0;   

// 7- Char
char text1 = 'A';   

// 8- String
string text2 = "Bilgo Soft";   

// 9- Bool
bool bool1 = True
bool bool1 = False