using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi=("Doğukan");
            musteri1.Soyadi = ("Nalbant");
            musteri1.TcNo = 123456789;
            musteri1.Yasi = 25;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = ("Peter");
            musteri2.Soyadi = ("Parker");
            musteri2.TcNo = 987654321;
            musteri2.Yasi = 18;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = ("Polat");
            musteri3.Soyadi = ("Alemdar");
            musteri3.TcNo = 741258963;
            musteri3.Yasii = ("Ölümsüz");
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            Console.WriteLine("PROFİLİNİZ OLUŞTURULUYOR ECİK SABIR");
            Console.WriteLine(" " );
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine(" ");
            Console.WriteLine("MÜŞTERİLER LİSTELENİYOR");
            Console.WriteLine(" ");
            musteriManager.Liste(musteri1);
            Console.WriteLine(" ");
            musteriManager.Liste(musteri2);
            Console.WriteLine(" ");
            musteriManager.Liste(musteri3);
            Console.WriteLine(" ");

            Console.WriteLine("MÜŞTERİLER SİLİNİYOR");
            Console.WriteLine(" ");
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            
        }
    }
}
