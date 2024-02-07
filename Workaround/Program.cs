using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        SelamVer(isim: "Engin");
        SelamVer(isim: "Ahmet");
        SelamVer(isim: "Ayşe");
        SelamVer();
        int sonuc = Topla(6, 58);
        Person person1 = new Person();
        person1.FirstName = "irfan";
        person1.LastName = "ayaz";
        person1.DateOfBirthYear = 1983;
        person1.NationalIdentity = 123;


        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);


      
    }

    static void SelamVer(string isim="isimsiz")
    {
        Console.WriteLine("Merhaba: " + isim);
    }
    static int Topla(int sayi1 = 5, int sayi2 = 10)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam: "+ sonuc);
        return sonuc;
    }

}