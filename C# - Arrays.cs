// Arrays : Kelime anlıma Listeler' dir. Listeler birden fazla veriyi bellek üzerinde tutmamızı sağlayan yapılardır.
// Index : Bizler saymaya 1' den, programlama dilleri ise 0' dan başlar. Liste içindeki 1. elemanımız 0. index numarasına sahiptir.

// Tek Boyutlu Dizi Tanımlama (Vector)

//I. Yöntem
int[] Numbers = new int[2];
Numbers[0] = 1; // Dizin 1. elemanını giriyoruz.
Numbers[1] = 2; // Dizin 1. elemanını giriyoruz.

// II. Yöntem
int[] Numbers2;
Numbers2 = new int[10];
Numbers2[0] = 1; // Dizi içine veri giriyoruz
Numbers2[1] = 2; // Dizi içine veri giriyoruz

// III. Yöntem
// Bu yöntemde dizi tanımlanırken içine veri eklenir
int[] Numbers3 = {1, 2};

// Çok Boyutlu Dizi Tanımlama (Matrix)
char[,] Text = new char[1,2]; // 1 : Satır - 2 : Sütun
Text[0,0] = 'A';
Text[0,1] = 'B';

// ARRAY FUNCTION
int[] Numbers4 = {1,2,3,4,5};
int[] Numbers5 = new int[5];
Console.WriteLine(Numbers4[0]);     // Dizinin belirtilen index numarasındaki elemanını ekrana yazdırır.
Console.WriteLine(Numbers4.Length);	// Dizinin eleman sayısını söyler.
Array.Sort(Numbers4);				// Dizi elemanlarını küçükten büyüğe sıralar.
Array.Reverse(Numbers4);			// Dizi elemanlarını ters çevirir.
Array.IndexOf(Numbers4,1,0,-1);		// Berlitilen dizi içinde belirtilen ifade, berlitilen değerler arasında aranır. (Aramaya sağdan başlar)
Array.LastIndexOf(Numbers4,1); 		// Berlitilen dizi içinde belirtilen ifade aranır. (Aramaya soldan başlar)
Array.Clear(Numbers4);				// Dizinin elamanlarını siler.
Array.Copy(Numbers4,Numbers5,3);	// Diziyi başka bir diziye kopyalar.
foreach (var keep in Numbers4)      // Dizinin tüm elemanlarını foreach döngüsü ile ekrana yazdırdık.
{
    Console.WriteLine(keep)
}