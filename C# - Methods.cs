// Metot : Bir kodu bir kez yazmamızı ve istediğimiz her yerde sadece metot ismini yazarak oluşturmamızı sağlayan yapıdır.

// Metot Oluşturmak

// Geriye Değer DÖndürmeyen Parametresiz Metot
static void Add1()
{
    Console.WriteLine(5 + 5);
}

// Geriye Değer Döndüren Parametresiz Metot
static int Add2()
{
    return 5 + 5;
}

// Geriye Değer DÖndürmeyen Parametreli Metot
static void Add3(int n1, int n2)
{
    Console.WriteLine(n1 + n2);
}

// Geriye Değer Döndüren Parametreli Metot
static int Add4(int n1, int n2)
{
    return n1 + n2;
}

// Overload Metot
static int Add4(int n1, int n2, int n3)
{
    return n1 + n2 + n3;
}

// Sınırsız Parametreli Metot
static int Add5(params int[] numbers)
{
    int result = 0;
    foreach (var keep in numbers)
    {
        result += keep;
    }
    return result;
}

// REF Kullanımı
static void Add6(ref int n1) // Değişkenin bellekteki değerini alabilmesi için ref kodunu değişken tipinin önüne yazıyoruz.
{
    n1++;
}

// OUT Kullanımı
static void Add7(out int n2) // Değişkenin bellekteki değerini alabilmesi için ref kodunu değişken tipinin önüne yazıyoruz.
{
    n2 = 5;
    n2++;
}


// Metot Çağırmak (Yazılan Metodu Kullanmak)

Add1();
Add2();
Add3(5, 5);
Console.WriteLine(Add4(5, 5));
Console.WriteLine(Add4(5, 5, 5));
Add5();

// REF Kullanımı
int n1 = 5;
Add6(ref n1); // Bellekteki değeri baz alarak işlem yapması için ref kodunu yazıyoruz.
Console.WriteLine(n1);

// OUT Kullanımı
int n2;
Add7(out n2); // REF kodundan farkı değişkenin değeri metot içinde tanımlanmasıdır.
Console.WriteLine(n1);