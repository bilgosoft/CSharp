// Do While : For ve while döngüsü gibi bir döngüdür. Fakat bir farkı var. Diğer döngülerimiz önce kontrol edip ona göre döngüye giriyordur. Do while ise ilk önce döngüye giriyor sonra kontrol ediyor.

int password;
		
do  // Koşula girmeden çalışacak kodlarımı yazdığım blok.
{
    Console.Write("Şifre Giriniz : ");
    password = int.Parse(Console.ReadLine());
    
}while(password != 123); // Koşulum sağlanana kadar döngümü sağlayan kod satırım.
    
Console.WriteLine("Şifre Doğru"); // Koşul sağlanıp, döngüden çıkınca çalışacak kodum.
