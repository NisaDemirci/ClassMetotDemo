using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            musteri.Id = 1;
            musteri.Ad = "Engin";
            musteri.Soyad = "Demirog";
            musteri.Bakiye = 187;

            Musteri musteriGuncelle = new Musteri();

            musteriGuncelle.Ad = "Engin";
            musteriGuncelle.Soyad = "Demirog";
            musteriGuncelle.Id = 1;
            musteriGuncelle.Bakiye = 300;

            Musteri musteriSil = new Musteri();

            musteriSil.Ad = "Engin";
            musteriSil.Soyad = "Demirog";
            musteriSil.Id = 1;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri);
            musteriManager.MusteriGuncelle(musteriGuncelle);
            musteriManager.MusteriSil(musteriSil);



        }
    }
}