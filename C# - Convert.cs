// Convert : Klavyeden girilen her veri string olarak kabul edilir. Bu yüzden farklı bir veri tipi almak istiyorsak convert yani tip dönüşüm işlemi yapmalıyız.

// 1. Yöntem
// Not : Çift yönlü convert işlemi sağlanabildiği için tercih sebebidir.
int number1;

Console.Write("Lütfen Bir Sayı Giriniz : ")
number1 = Convert.ToInt32(Console.ReadLine());

// 2. Yöntem
// Not : Parse fonksiyonu sadece string veri tipinden başka veri tipine dönüştürür. Başka veri tipinden string' e dönüştürmez.
int number1;

Console.Write("Lütfen Bir Sayı Giriniz : ")
number1 = int.Parse(Console.ReadLine());