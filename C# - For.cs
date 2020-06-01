// For : Tekrarlanmasını istediğimi bir kodu otomatik olarak tekrarlamamızı sağlayan döngü yapısıdır.

// Ekrana 1' den 10' a kadar yazdıralım.
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Ekrana 10' dan 1' e kadar yazdıralım.
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}

// Ekrana 1' den 10' a kadar tek sayıları yazdıralım.
for (int i = 0; i <= 10; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

// Ekrana 1' den 10' a kadar çift sayıları yazdıralım.
for (int i = 0; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

// Ekrana 1' den 10' a kadar sayıları yazdıralım. (6 hariç)
for (int i = 0; i <= 10; i++)
{
    if (i == 6)
    {
        continue;   // O  anki işlemi atlamamızı sağlar.
        i++;        // 6 sayısında takılı kalmamamız için sayımı 1 arttırıyorum
    }
    Console.WriteLine(i);
}

// Ekrana 1' den 10' a kadar sayıları yazdıralım. (6 sayısını gördüğü anda döngüm dursun.)
for (int i = 0; i <= 10; i++)
{
    if (i == 6)
    {
        break;  // Döngüyü kırmamızı yani bitirmemizi sağlar.
    }
    Console.WriteLine(i);
}