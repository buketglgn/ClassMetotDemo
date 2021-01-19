using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name+" "+musteri.Surname+ " İsimli Musteri EKLENDİ ");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Name +" "+ musteri.Surname + " İsimli Musteri SİLİNDİ \n ");
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            Console.WriteLine("Musteriler Listeleniyor");
            foreach(var musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + musteri.Bakiye + "\n");
            }
        }
    }
}
