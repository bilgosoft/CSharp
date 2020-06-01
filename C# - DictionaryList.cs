// DictionaryList : Key - Value tipinde çalışır. Bir veriye ulaşabilmek için anahtar verimizi girmemiz gerekir.

// DictionaryList Tanımlamak
Dictionary<string, int> dic = new Dictionary<string, int>();

// DictionaryList' e Veri Eklemek
dic.Add("İstanbul", 34);

// DictionaryList' in Belirtilen Elemanına Ulaşmak
Console.WriteLine(dic["İstanbul"]);

// DictionaryList' in Tüm Elemanlarına Ulaşmak
foreach(var keep in dic)
{
    Console.WriteLine(keep.Key);
    Console.WriteLine(keep.Value);
}

// Key ve Value Kontrol 
Console.WriteLine(musteriler.Contains(new KeyValuePair<int, string>("İstanbul", 34))); 

// Key Kontrol 
Console.WriteLine(musteriler.ContainsKey("İstanbul"));

// Key Kontrol 
Console.WriteLine(musteriler.ContainsValue(34));