using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { Id = 1, Name = "Buket", Surname = "Gülgün", Bakiye = 10000 };
            Musteri musteri2 = new Musteri() { Id = 2, Name = "Ceylin", Surname = "cba", Bakiye = 2000 };
            Musteri musteri3 = new Musteri() { Id = 3, Name = "Bülent", Surname = "Abc", Bakiye = 500 };
            Musteri musteri4 = new Musteri() { Id = 4, Name = "Gülsevim", Surname = "Bca", Bakiye = 50000 };

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.MusteriEkle(musteri1);
            musterimanager.MusteriEkle(musteri2);
            musterimanager.MusteriEkle(musteri3);
            musterimanager.MusteriEkle(musteri4);

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3, musteri4 };
            musterimanager.MusteriListele(musteriler);

            musterimanager.MusteriSil(musteri3);



        }
    }
}
