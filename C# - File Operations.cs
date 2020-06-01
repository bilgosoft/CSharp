// Dosya İşlemleri : İstediğimiz bir dosyaya mesela bir txt dosyasını oluşturup üzerinde işlemler yapmamızı sağlayan yapıdır.
// Not : Dosya işlemlerini yapabilmek için "using System.IO;" kütüphanesini eklemelisiniz.

// Dosya Yolu ve İsmi Belirlemek
var path = @"C:text.txt"; 

// DOSYA VERİ EKLEMEK
/*
1. Parametre path
2. Parametre dosya yok ise oluşturmayı, var ise açmamızı sağlar.
3. Parametre dosyaya veri yazacağımızı belirtir.
*/
FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
StreamWriter sw = new StreamWriter(path);   // Yazma işlemi için StreamWriter class' ını çağırıyoruz.
sw.WriteLine("Hello World");				// Çağırdığımız class' dan oluşturudğumuz instance ile yazma işlemini yapıyoruz.
sw.Close();									// Nesnemizi kapatıyoruz.
fs.Close();                                 // Nesnemizi kapatıyoruz.

// DOSYA OKUMAK
/*
1. Parametre path
2. Parametre dosya yok ise oluşturmayı, var ise açmamızı sağlar.
3. Parametre dosyadan okuma işlemi yapacağımızı belirtir.
*/
FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
StreamWriter sw = new StreamWriter(path);   // Okuma işlemi için StreamWriter class' ını çağırıyoruz.
string text = sw.ReadLine();
while(text != null) // Döngüm null görene kadar dönerek tüm metnimi okumamı sağlayacak
{
    Console.WriteLine(text);
    text = sw.ReadLine();
}
sw.Close();									// Nesnemizi kapatıyoruz.
fs.Close();                                 // Nesnemizi kapatıyoruz.

// DOSYAYI TAŞIMAK
File.Move(path,@"C:\text.txt");

// DOSYA KOPYALAMAK
var path2 = @"C:\text3.txt";    // Kopyalanacak yeri ve yeni dosya adını yazıyoruz.

if (File.Exists(path2))			// Kopyalanacak yerde aynı isimde dosya olup olmadığına bakıyoruz. 
{
    Console.Write("Aynı Dizinde Dosya Mevcut.\nDosyayı Var Olan ile Değiştirmek İstermisiniz ? (E/H) : ");
    char apply = char.Parse(Console.ReadLine());
    if (apply == 'E')
    {
        File.Copy(path, path2, true); // Belirtilen dosya var ise üzerine kopyalar.
        Console.WriteLine("Dosya Kopyalandı !");
    }
    else if (apply == 'H')
    {
        Console.WriteLine("Dosya Kopyalanmadı");
    }
}
else
{
    File.Copy(path, path2); // Aynı dosya yok ise direkt kopyalama işlemini gerçekleştirir.
}

// DOSYA SİLMEK
File.Delete(path);




