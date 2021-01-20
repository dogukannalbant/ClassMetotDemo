using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Hoşgeldiniz: "+ musteri.Adi+" "+ musteri.Soyadi);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Elveda Listesi: " + musteri.Adi+ " " + musteri.Soyadi);

        }
        public void Liste(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi: " + musteri.Adi+ " "+ musteri.Soyadi);
            Console.WriteLine("Müşteri TC no: " +musteri.TcNo);
            Console.WriteLine("Müşteri Yaşı: " + musteri.Yasi + musteri.Yasii);
        }

    }
}
