// String Functions : String fonksiyonlar metinsel ifadeler üzerinde çeşitli işlemler yapmamızı sağlayan fonksiyonlardır.

string Text = "   Bilgo Soft   ";
var result = Text.Trim();               // İfadenin başındaki ve sonundaki boşlukları kaldırır.
var result = Text.TrimEnd();            // İfadenin sonundaki boşlukları kaldırır.
var result = Text.TrimStart();          // İfadenin başındaki boşlukları kaldırır.
var result = Text.Length;               // Karakter sayısını gösterir.
var result = Text.Remove(7);            // Belirtilen karakter sayısından sonraki karakterlerin veya belirtilen kadar karakteri siler.
var result = Text.ToUpper();            // Tüm karakterleri büyük harfe çevirir.
var result = Text.ToLower();            // Tüm karakterleri küçük harfe çevirir.
var result = Text.Replace(" ","")       // Karakterleri değiştirir.
var result = Text.Substring(3);         // Belirtilen karakterler arasındaki ifadeleri yazar.
var result = Text.StartsWith("B");      // Berlitilen ifade ile başlayıp başlamadığını kontrol eder.
var result = Text.EndsWith("B");        // Berlitilen ifade ile bitip başlamadığını kontrol eder.
var result = Text.IndexOf("Bil");       // Berlitilen ifadenin olup olmadığına bakar. (Aramaya sağdan başlar)
var result = Text.LastIndexOf("Bil");   // Berlitilen ifadenin olup olmadığına bakar. (Aramaya soldan başlar)
var result = Text.Insert(0,"by ");      // Belirtilen indexe belirtilen ifadeyi ekler.
var result = Text.Remove(3);            // Belirtilen karakterden sonrasını siler.
var result = Text.Split(" ");           // Belirtilen ifadeyi gördükçe ana ifadeyi parçalar.
var result = Text.Contains("Bil");      // Belirtilen ifadenin olup olmadığına bakar.