// ArrayList : Dinamik dizi oluşturmamızı sağlar. Array' den farkı, array statik iken arraylist dinamik bir yapıya sahiptir. Statik dizilerde belirtilen eleman sayısı kadar veri eklerken dinamik dizilerde istediğimi kadar eleman ekleyebiliriz.
// Not : ArrayList kullanmak için "using System.Collections;" kütüphanesi eklenmelidir.

// ArrayList tanımlamak.
ArrayList aList = new ArrayList();
ArrayList aList2 = new ArrayList(); 

// ArrayList Functions
// Add(); : Dizi içine veri ekler.
aList.Add(1);
aList.Add(2);
aList.Add(3);

// Remove(); : Dizi içindeki veriyi siler.
aList.Remove(1);

// Sort(); : Dizinin elemanlarını küçükten büyüğe sıralar.
aList.Sort();

// Reverse(); : Dizinin verilerini ters çevirir.
aList.Reverse();

// Clear(); : Dizinin içindeki tüm elemanları siler
aList.Clear();

// BinarySearch(); : Belirtilen ifadenin dizi içinde olup olmadığını kontrol eder.
aList.BinarySearch(1);

// Count(); : Dizinin toplam eleman sayısını sayar.
aList.Count();

// Capacity(); : Dizinin ne kara eleman barındırabileceğini bildirir.
aList.Capacity(); 

// IndexOf(); : Belirtilen değerin index numarasını yazar.
aList.IndexOf(1);

// LastIndexOf(); : Belirtilen değerin index numarasını yazar.
aList.LastIndexOf(1);

// Contains(); : Belirtilen değerin dizideki varlığına bakar.
aList.Contains(1);

// RemoveAt(); : Dizi içindeki belirtilen indexdeki elemanı siler.
aList.RemoveAt(0);

// AddRange(); : Diziyi başka bir dizinin sonuna kopyalar.
aList.AddRange(aList2);

// TrimToSize(); : Diziyi başka bir dizinin sonuna kopyalar.
aList.TrimToSize();