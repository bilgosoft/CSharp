// TimeSpan Module : Tarih ve zaman bilgilerine tarih ve zaman bilgieri ekleyerek işlemler yapmamızı sağlar

DateTime current1 = DateTime.Now;

DateTime current2 = current1.AddHours(1); 		// current1 nesnesinin üstüne 1 saat ekledik ve current2 nesnesine aktardık.
TimeSpan difference = current1 - current2; 		// current1 ve current2 nesnesinin arasındaki süre farkını aldık.

Console.WriteLine($"İki Zaman Arasındaki Süre  : {difference}");
