using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteriBilgileri)
        {
            Console.WriteLine(musteriBilgileri.Ad + " " + musteriBilgileri.Soyad + " adlı musteri başarılı bir şekilde eklendi.");
        }
        public void MusteriGuncelle(Musteri musteriBilgileri)
        {
            Console.WriteLine(musteriBilgileri.Ad + musteriBilgileri.Soyad + " İsimli Müşterinin güncel bakiyesi " + musteriBilgileri.Bakiye);
        }

        public void MusteriSil(Musteri musteriBilgileri)
        {
            Console.WriteLine(musteriBilgileri.Ad + musteriBilgileri.Soyad + " Musterisi silindi.");
        }
    }
}