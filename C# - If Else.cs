// If - Else If - Else : Bir şarta bağlı olarak kontrol işlemlerini yapmamızı sağlayan yapıdır.

int number1 = 50;

// If : Kontrol mekanizmamda şartıma çalışacak ilk yapı.
if (number1 < 50)
{
    Console.WriteLine("Sayı 50' den Küçüktür.");
}

// Else If : Kontrol mekanizmamda eğer if bloğum çalışmaz yani şartım sağlanmaz ise çalışacak diğer yapı.
else if (number1 > 50)
{
    Console.WriteLine("Sayı 50' den Büyüktür.");
}

// Else : Kontrol mekanizmamda if ve else if bloklarım çalışmaz ise mutlaka çalışacak yapı.
else
{
    Console.WriteLine("Sayı 50' e Eşittir.");
}

// İç İçe If Kullanımı
char gender;
int birthOfYear;

Console.Write("Cinsiyetinizi Giriniz (E/K) : ");
gender = char.Parse(Console.ReadLine());

if (gender == 'K')
{
    Console.WriteLine("Kadınlar Askere Alınamaz.");
}

else
{
    Console.Write("Doğum Yılınızı : ")
    birthOfYear = int.Parse(Console.ReadLine());
    if (2020 - birthOfYear >= 20 and 2020 - birthOfYear <= 28)
    {
        Console.WriteLine("Askere Gidebilirsiniz.");
    }

    else if (2020 - birthOfYear < 20)
    {
        Console.WriteLine("Askere Gidemezsiniz.");
    }

    else if (2020 - birthOfYear >= 28)
    {
        Console.WriteLine("Askere Gitmek Zorundasınız.");
    }
}