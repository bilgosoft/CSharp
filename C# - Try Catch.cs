// Try - Catch : Programlama sırasında veya programın çalışma esnasında çıkabilecek hatalarımı yönetmemi sağlayan yapıdır.

// Try : Hata gelebileceğini düşündüğümüz kodları yazdığımız bloktur.
try
{
    Console.Write("Sayıyı Giriniz : ");
    int number = int.Parse(Console.ReadLine());
}

// Catch : Hata geldiği zaman çalışmasını istediğimiz kodları yazdığımız bloktur.
catch // Tek tek hata gruplarını yazmamak için kullanacağımız genel hata yapısıdır.
{
    Console.WriteLine("Hata!");
}

/*
catch(ArgumentNullException error1) // Boş geçildiğinde durumunda çalışan hata grubumuzdur.
{
    Console.WriteLine("Bu Alan Boş Bırakılamaz");
}

catch(FormatException error2) // Farklı bir veri tipi girildiğinde çalışan hata grubumuzdur.
{
    Console.WriteLine("Hatalı türde veri girdiniz.");
}
*/

// Finally : Hata gelsede gelmesede çalışacak kod bloğumuzdur.
finally
{
    Console.WriteLine("Progam Başlatıldı");
}