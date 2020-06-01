// Foreach : Listelerde kullanılan döngü yapımızdır. For' dan farkı; for listelerde kullandığımız zaman index numarasına, foreach ise direkt elemana ulaşım sağlar.

int[] numbers = {1, 2, 3, 4, 5};

foreach (var keep in numbers)
{
    Console.WriteLine(keep);
}
