// Datetime Module : Tarih ve zaman işlemlerimizi yapmamızı sağlayan modüldür.

DateTime date = new DateTime(2020, 3, 22); 		// Geçmiş veya gelecek tarih bilgisi tutan bir instance ürettik.
DateTime current = DateTime.Now; 				// DateTime Oluşturduk
var result = current; 							// Sistemin tarih ve saat bilgisini alır.
var result = current.Day; 						// Sistemin gün bilgisini alır.
var result = current.Month; 					// Sistemin ay bilgisini alır.
var result = current.Year; 						// Sistemin yıl bilgisini alır.
var result = current.Hour; 						// Sistemin saat bilgisini alır.
var result = current.Minute; 					// Sistemin saat bilgisini alır.
var result = current.Second; 					// Sistemin saat bilgisini alır.
DateTime gunEkle = current.AddDays(1); 			// Sistem tarihinin üstüne parantez içinde belirtilen sayı kadar .AddDays kodu ile gün ekler.
DateTime saatEkle = current.AddHours(10); 		// Sistem saatinin üstüne parantez içinde belirtilen sayı kadar .AddHours kodu ile saat ekler.
var result = current.ToString("yyyy-dd-mm");	// Sistem tarihini istediğimiz düzende yazdırdık.
var result = current.ToString("HH:mm:ss"); 		// Sistem saatini istediğimiz düzende yazdırdık. NOT: HOURS(SAAT ANLAMINA GELEN "HH" İFADESİNİZ KÜÇÜK YAZAR İSEK(hh) 09, BÜYÜK YAZAR İSEK(HH) 21 ŞEKLİNDE GÖSTERİR.)
var result = current.ToShortDateString(); 		// Sistemin sadece saat bilgisini alır.
var result = current.ToShortTimeString();	 	// Sistemin saat ve dakika bilgisini alır.
var result = current.ToLongDateString(); 		// Sistemin tarih bilgisini uzun formatta alır.
var result = current.ToLongTimeString(); 		// Sistemin saat bilgisini uzun formatta alır.