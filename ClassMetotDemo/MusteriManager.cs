using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi." + musteri.Adi + musteri.Soyadi);
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi."+musteri.Id+musteri.Adi+musteri.Soyadi+musteri.TcKimlikNo);
        }
        
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi."+musteri.Id+musteri.Adi+musteri.Soyadi+musteri.TcKimlikNo);
        }
        
     






    }
}
