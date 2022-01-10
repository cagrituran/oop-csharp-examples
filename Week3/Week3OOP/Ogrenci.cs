using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3OOP
{
    class Ogrenci
    {
        //default, varsayılan yapıcı method /constructor method
        public Ogrenci()
        {
            Console.WriteLine("Varsayılan Yapıcı method Çalıştı");
        }

        //overloaded constructor/aşırı yüklenmi yapıcı method
        public Ogrenci(int OgrenciNo)
        {
            Console.WriteLine("Aşırı Y-1 Yapıcı method Çalıştı");
            this.ogrencino = OgrenciNo;
        }

        //overloaded constructor/aşırı yüklenmi yapıcı method
        public Ogrenci(int ogrencino, string adi, string soyadi)
        {
            Console.WriteLine("Aşırı Y-2 Yapıcı method Çalıştı");
            this.ogrencino = ogrencino;
            this.adi = adi;
            this.soyadi = soyadi;
        }

        private int ogrencino;
        private string adi;
        private string soyadi;
        private char cinsiyet;
        private string bolumu;
        private DateTime dogumtarihi;
        private string adres;

        public void SetOgrenciNo(int ogrencino)
        {
            this.ogrencino = ogrencino;
        }
        public int GetOgrenciNo()
        {
            return this.ogrencino;
        }
        public void SetAdi(string adi)
        {
            this.adi = adi;
        }
        public string GetAdi()
        {
            return this.adi;
        }
        public void SetSoyadi(string soyadi)
        {
            this.soyadi = soyadi;
        }
        public string GetSoyadi()
        {
            return this.soyadi;
        }
        public void SetCinsiyet(char cinsiyet)
        {
            this.cinsiyet = cinsiyet;
        }
        public char GetCinsiyet()
        {
            return this.cinsiyet;
        }
        public void SetBolumu(string bolumu)
        {
            this.bolumu = bolumu;
        }
        public string GetBolumu()
        {
            return this.bolumu;
        }
        public void SetDogumTarihi(DateTime dogumtarihi)
        {
            this.dogumtarihi = dogumtarihi;
        }
        public DateTime GetDogumTarihi()
        {
            return this.dogumtarihi;
        }
        public void SetAdres(string adres)
        {
            this.adres = adres;
        }
        public string GetAdres()
        {
            return this.adres;
        }

        public string ProfilGoster()
        {
            string bilgi =
                $"Ogrenci No: {GetOgrenciNo()}\n" +
                $"Adı: {adi}\n" +
                $"Soyadı: {GetSoyadi()}\n" +
                $"Cinsiyet: {cinsiyet}\n" +
                $"Bolumu: {bolumu}\n" +
                $"Doğum Tarihi: {dogumtarihi}\n" +
                $"Adres: {adres}\n";

            return bilgi;

        }

        public double GetOgrenciSec()
        {
            return (DateTime.Now- this.dogumtarihi).TotalSeconds;
        }

        public string DogumGunu()
        {
            return dogumtarihi.DayOfWeek.ToString();
        }

        //global scope
        int x = 0;
        int y = 10;
        public int Test(int x )//formal scope
        {      
            //local scope
          //  int y = 5;
            return 2 * x+y;
        }
    }
}
