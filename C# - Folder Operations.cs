// Klasör İşlemleri : İstediğimiz bir klasör üzerinde çeşitli işlemler yapmamızı sağlayan yapıdır.

// Not : Klasör işlemlerini yapabilmek için "using System.IO;" kütüphanesini eklemelisiniz.

// Klasör Oluşturmak
Directory.CreateDirectory(@"C:\NewFolder"); // Adres belirtmeden sadece "NewFolder" yazar isek program çalıştığı klasör altına yeni klasör oluşturur.

// Klasör Taşımak
Directory.Move("NewFolder", @"C:\NewFolder");

// Klasör Silmek
Directory.Delete(@"C:\NewFolder");       // İçi boş ise klasörü siler.
Directory.Delete(@"C:\NewFolder", true); // İçi boş veya doluda olsa klasörü siler.

// Klasör Hakkında Bilgi Almak
// Belirtilen klasörün oluşturulduğu tarih ve zamanı gösterir.
DateTime createTime=Directory.GetCreationTime("NewFolder"); 
Console.WriteLine(createTime.ToString());

//Klasöre en son erişim sağlandığı zamanın bilgisini döndürür.
DateTime lastAccess = Directory.GetLastAccessTime("NewFolder");
Console.WriteLine(lastAccess.ToString());

//Klasöre en son veri yazıldığı zamanın bilgisini döndürür.
DateTime addingrecentdata = Directory.GetLastWriteTime("NewFolder");
Console.WriteLine(addingrecentdata.ToString());