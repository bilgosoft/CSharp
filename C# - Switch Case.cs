// Switch Case : If koşul yapımın alternatifi diyebileceğimiz fakat aralarında farklar olan bi koşul mekanizmamdır.

int number;

Console.Write("Kaçıncı Mevsimi Görmek İstersiniz? : ");
number = int.Parse(Console.ReadLine());

// Neyi kontrol ettirmek istiyorsam onu switch() içine yazıyorum.
switch (number) 
{
    // Kontrol sağlamasını istediğim her şart için bir case yazıyorum. 
    case 1: Console.Writeline("Ocak"); break
    case 2: Console.Writeline("Şubat"); break
    case 3: Console.Writeline("Mart"); break
    
    case 4: Console.Writeline("Nisan"); break
    case 5: Console.Writeline("Mayıs"); break
    case 6: Console.Writeline("Haziran"); break
    
    case 7: Console.Writeline("Temmuz"); break
    case 8: Console.Writeline("Ağustos"); break
    case 9: Console.Writeline("Eylül"); break
    
    case 10: Console.Writeline("Ekim"); break
    case 11: Console.Writeline("Kasım"); break
    case 12: Console.Writeline("Aralık"); break
    
    // Case' lerim çalışmaz ise çalışacak olan default yazıyorum.
    default: Console.Writeline("Girmiş Olduğunuz Sayıyı Ait Bir Ay Bilgisi Bulunamadı."); break
}