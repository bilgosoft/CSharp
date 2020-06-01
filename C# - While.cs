// While : For döngüsünün alternatifi diye biliriz. Fakat aralarında farklılıklar mevcuttur.

// Ekrana 1' den 10' a kadar yazdıralım.
int number = 1;
while(number <= 10)
{
    Console.WriteLine(i);
    number++;
}

// Ekrana 10' dan 1' e kadar yazdıralım.
int number = 1;
while(number >= 1)
{
    Console.WriteLine(i);
    number++;
}

// Ekrana 1' den 10' a kadar tek sayıları yazdıralım.
int number = 1;
while(number <= 10)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
    number++;
}

// Ekrana 1' den 10' a kadar çift sayıları yazdıralım.
int number = 1;
while(number <= 10)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    number++;
}

// Ekrana 1' den 10' a kadar sayıları yazdıralım. (6 hariç)
int number = 1;
while(number <= 10)
{
    if (i == 6)
    {
        continue;   // O  anki işlemi atlamamızı sağlar.
        i++;        // 6 sayısında takılı kalmamamız için sayımı 1 arttırıyorum
    }
    Console.WriteLine(i);
    number++;
}

// Ekrana 1' den 10' a kadar sayıları yazdıralım. (6 sayısını gördüğü anda döngüm dursun.)
int number = 1;
while(number <= 10)
{
    if (i == 6)
    {
        break;  // Döngüyü kırmamızı yani bitirmemizi sağlar.
    }
    Console.WriteLine(i);
    number++;
}