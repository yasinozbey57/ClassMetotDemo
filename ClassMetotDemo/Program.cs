using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 168301;
            musteri1.Adi = "Yasin";
            musteri1.Soyadi = "Özbey";
            musteri1.TcKimlikNo = 258963;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 168302;
            musteri2.Adi = "Nisanur";
            musteri2.Soyadi = "Kaçak";
            musteri2.TcKimlikNo = 852963;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("ID : "+ musteri.Id+"ADI : "+musteri.Adi+"SOYADI : "+musteri.Soyadi+"TC KİMLİK NO : "+musteri.TcKimlikNo);

            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);

            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
        }
    }
}
