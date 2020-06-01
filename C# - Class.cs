using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace CLASS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* 
			OBJECT ORIENTED PROGRAMMING - NESNE TABANLI PROGRAMLAMA
		
		 CLASS : Yapmak istediğimiz işlemleri gruplara ayırıp daha düzenli ve profesyonel kodlar yazabilmek için kullanılan yapıdır.
		 PARENT / SUPER CLASS : Miras veren class' dır.
		 CHILD / SUB CLASS : Miras veren class' dır.
		
		 ERİŞİM BELİRLEYİCİLER : Class veya instancelara nasıl erişebileceğimizi belirlerler.
		
		   I)   public			 	: Her yerden erişim sağlanır.
		  II)  	private			 	: Sadece tanımlandığı sınıfta erişim sağlanır.
		 III) 	internal			: Sadece tanımlandığı projede erişim sağlanır.
		  IV) 	protected			: Sadece tanımlandığı sınıfta veya mirasçı sınıfta erişim sağlanır.
		   V)	protected internal 	: protected' dan farkı tanımlamanın aynı projede olmasına gerek yoktur.
		  VI)  	private protected   : Sadece kendinden türetilmiş nesneler üzerinden kullanılabilir.

			Not : Eğer bir üye üzerinde yapılan değişiklik başka yapıları da etkiliyorsa veya zarar veriyorsa, o üye private tanımlanmalıdır,
			Not : Private verilerin değerlerini alan ve ayarlayan metotlar public olmalıdır.
		*/

//------------------------------------------------------------------------------------------------ CLASS ÇAĞRILDIĞI KISIM -------------------------------------------------------------------------------------------------
		
		// KONU 1 : FIELD TANIMLAMA
		// INSTANCE : Bir class' dan üretilen nesnedir.
		Person p1 = new Person();
		p1._Name = "Ali";
		p1._Surname = "YILDIRIM";
		p1._Age = 35;
		p1._Gender = 'e';
		//Console.WriteLine($"{p1._Name} {p1._Surname} {p1._Age} {p1._Gender}");
		
//--------------------------------------------------------------------------------------------------------------------------------------------------------
		
	
		// KONU 2 : ENCAPSULATION (KAPSÜLLEME)
		Person2 p2 = new Person2 { Name = "Ayşe", Surname = "KARATAŞ", Age = 15, Gender = 'k' }; // Üstte yazdığımız şekil dışında bu şekildede yazabiliriz.
		//Console.WriteLine($"{p2._Name} {p2._Surname} {p2._Age} {p2._Gender}");
		
//--------------------------------------------------------------------------------------------------------------------------------------------------------

		
		// KONU 3 : INHERITANCE (KALITIM / MİRASLAMA)
		Person3 p3 = new Person3();
		p3.Name = "Mehmet";
		p3.Surname = "ATEŞ";
		p3.FullName(p3.Name, p3.Surname);
		p3.Greetings();
		//Console.WriteLine($"{p3.Name} {p3.Surname}");
		
		Person4 p4 = new Person4();
		p1._Name = "Tuana";
		p1._Surname = "DEMİR";
		p4.Age = 22;
		p4.FullName(p4.Name, p4.Surname);
		p4.Greetings();
		//Console.WriteLine($"{p4.Name} {p4.Surname} {p4.Age}");
		
//--------------------------------------------------------------------------------------------------------------------------------------------------------

		
		// KONU 4 : INHERITANCE (KALITIM / MİRASLAMA)
		Person5 p5 = new Person5();
		p5.Greetings();
		
		Person6 p6 = new Person6();
		p6.Greetings();

//--------------------------------------------------------------------------------------------------------------------------------------------------------

		
		// KONU 5 :	ABSTRACT CLASS
		//Person7 p7 = new Person7(); >>> Abstract class' dan intance oluşturulamaz.

		Person8 p8 = new Person8();
		p8.Greetings();
		p8.GreetingsTR();

//--------------------------------------------------------------------------------------------------------------------------------------------------------

		
		// KONU 6 :	CONSTRUCTOR VE DESTRUCTOR METOTLAR
		Tructor tructor = new Tructor();		// Class' dan instance ürettiğim için constructor metodum otomatik çalışacak.
		
		string Name = "Gözde";				// Overload constructor metodum için parametre oluşturdum.
		Tructor tructor2 = new Tructor(Name);	// Class' dan instance ürettiğim ve parametre oluşturduğum için overload constructor metodum otomatik çalışacak.
	
        }
    }
     
//--------------------------------------------------------------------------------------------------------------------------------------------------------
		
        // KONU 7 : STATIC CLASS : Instance üretilemeyen class tipidir.
        Person9.Greetings();
}
    
//------------------------------------------------------------------------------------------------ CLASS YAZILDIĞI KISIM --------------------------------------------------------------------------------------------------
// KONU 1 : FIELD TANIMLAMA : Class içinde tanımlanan değişkenlerdir. Default erişim belirleyici private' dir. Güvenlik için private olmalıdır. Field' lar _FieldName olarak tanımlanır. Yazısız kurallardandır.
class Person // Class Tanımlıyoruz.
{
	public string _Name;		
	public string _Surname;	
	public int _Age;				
	public char _Gender;		
	// Not : Güvenlik için private olmak zorunda ama bir sonraki örnekte encapsulation konusunu anlatabilmek için bunu public yaptım.
}

//--------------------------------------------------------------------------------------------------------------------------------------------------------

// KONU 2 : ENCAPSULATION (KAPSÜLLEME) : Bir field' ı private yaparak erişimi ksııtlayıp aynı zamanda field üzerinde işlem yapmamızı sağlayan konudur.
class Person2 // Class Tanımlıyoruz.
{
	private string _Name;	
	private string _Surname;	
	private int _Age;
	
	// PROPERTY : Güvenliği sağlamak için private yapılan field' lara erişim sağlayabilmek ve FIELD ÜZERİNDE İŞLEM YAPABİLMEK için kullanılan yapılardır. Public olmalıdırlar.
		public string Name			
	{
		get {return "Merhaba " + _Name; }	// GET : Geriye dönecek değeri belirler.
		set	{_Name = value;}				// SET : Field' a gidecek değeri belirler. 		
	}
	
	public string Surname					
	{	
		get {return _Surname; }					
		set{_Surname = value;}				
	}
	
	public int Age				
	{
		get {return _Age; }		
		set						
		{
			if(value < 18)
				_Age = 18;
			else
			{_Age = value;}			
		}	
	}
	public char Gender{get; set;}	// Get, set metotlarını açmadan ve field tanımlamadan da property yazılabilir. Fakat field olmadığı için field işlemleri yapılamaz sadece değer tutar.
}

//--------------------------------------------------------------------------------------------------------------------------------------------------------

// KONU 3 : INHERITANCE (KALITIM / MİRASLAMA) : Bir class' ın başka class' a kendi nesnelerini miras vermesidir. Çok kodlu programlarda önemi daha iyi anlanır. Az programlarda çok önemsenmez.
class Person3 				// Parent Class
{
	public string Name{get; set;}
	public string Surname{get; set;}
	
	public void FullName(string Name, string Surname)
	{
		//Console.WriteLine($"Hoşgeldiniz, {Name} {Surname}");
	}
	
	public void Greetings()
	{
		Console.WriteLine("Hello World");
	}
}

class Person4 : Person3 	// Child Class
{
	public int Age{get; set;}
}

// SEALED CLASS : class' ın önüne sealed koyduğumuzda o class hiç bir class' ın parent' ı olamaz.
sealed class ParentClass
{
	//...
}

/*class ChildClass : ParentClass // Yazar isek sealed' dan dolayı hata alırız.
{

}*/

//--------------------------------------------------------------------------------------------------------------------------------------------------------

// KONU 4 : POLYMORPHISM (ÇOK BİÇİMLİLİK) : Parent class' ın metodunu child class' da aynı isimde fakat farklı içerikle kullanmaktır.
class Person5
{
	public virtual void Greetings() // Virtual Method : Sanal metot anlamına gelir.
	{
		Console.WriteLine("Hello World");
	}
}

class Person6 : Person5
{
	public override void Greetings() // Override Method : Aşırı yüklü metot anlamına gelir.
	{
		// base.Greetings(); >>> Bu kod açık kalırsa parent class' ın virtual metodu içinde kodlar çalışır.
		Console.WriteLine("Merhaba Dünya");
	}
}

//--------------------------------------------------------------------------------------------------------------------------------------------------------
		
// KONU 5 :	ABSTRACT CLASS : İçi dolu olmayan virtual metotlardır. Her class kendine özgü doldurur. Abstract class' dan intance oluşturulamaz.
abstract class Person7
{
	public void Greetings() // Completed Method (Tamamlanmış Metot) : Abstract class' da içi dolu olan metotlardır.
	{
		Console.WriteLine("Hello World");
	}
	
	public abstract void GreetingsTR(); // Incompleted Method (Tamamlanmamış Metot) : Abstract class' da içi boş olan metotlardır.
}

class Person8 : Person7
{
	public override void GreetingsTR()
	{
		Console.WriteLine("Merhaba Dünya");
	}
}

//--------------------------------------------------------------------------------------------------------------------------------------------------------
		
// KONU 6 : CONSTRUCTOR VE DESTRUCTOR METOTLAR : Constructor' lar class' dan instance üretildiğinde otomatik çalışan metotlardır. Destroctur ise program kapatıldığında çalışan metotdur.
// Not : Class ismi ile metot isimleri aynı olmalıdır. Destroctur metodunda isim önüne tilde(~)(ALT + 0126) işareti getirilmelidir. 
class Tructor
{
	public Tructor() 							//CONSTRUCTOR METHOD (YAPICI METOT) : Class' dan instance üretildiğinde çalışan metotdur.
	{
		Console.WriteLine("Hello World");
	}
		
	
	public Tructor(string Name)					// OVERLOAD CONSTRUCTOR METHOD (AŞIRI YÜKLÜ YAPICI METOT) : Class' dan instance üretildiğinde çalışan parametreli metotdur.
	{
		Console.WriteLine("Merhaba Dünya " + Name);
	}
	

	~Tructor()									// DESTRUCTOR METHOD (YIKICI METOT) : Program kapatılırken kullanılan metotdur.  
	{
		Console.WriteLine("Good Bye");
		System.Threading.Thread.Sleep(2000);
	}
}
    
//--------------------------------------------------------------------------------------------------------------------------------------------------------
		
// KONU 7 : STATIC CLASS : Instance üretilemeyen class tipidir.
static class Person9
{
    public static void Greetings() // Metoda erişim sağlayabilmek için public erişim belirleyicisini açıyoruz.
    {
        Console.WriteLine("Hello World");
    }   
}  
