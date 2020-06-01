// Random Module : Rastgele sayı üretmemizi sağlayan modüldür.

// Random Modülünü Dahil Etmek
ndom rnd = new Random();

// Rastgele Tam Sayı Üretmek
int number1 = rnd.Next(1, 100);
Console.WriteLine(number1);

// Rastgele Harf Üretmek
int asciicode = rnd.Next(65, 91);

char character = Convert.ToChar(asciicode);
Console.WriteLine(character);

// Rastgele Metinsel İfade Üretmek
string alphabet = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVWQXYZabcçdefgğhıijklmnoöprsştuüvqwxyz";
string text = "";

Console.Write("Metin Kaç Karakterden Oluşsun? : ")
int textlen = int.Parse(Console.ReadLine());

for (int keep = 0; keep < textlen; keep++)
{
    text += alphabet[rnd.Next(alphabet.Length)];
}
Console.WriteLine(text);
