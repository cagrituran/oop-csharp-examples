using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3OOP
{
    class Program
    {

        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci(13456,"Ali","Karaca");
            //o1.SetOgrenciNo(123456);
            //o1.SetAdi("Ali");
            //o1.SetSoyadi("Kalaycı");
            o1.SetCinsiyet('E');
            o1.SetBolumu("Bilgisayar Mühendisliği");
            o1.SetDogumTarihi(new DateTime(1979, 2, 19));
            o1.SetAdres("Atakent Mah. Halkalı, Küçükçeknece, İSTANBUL");



            Console.WriteLine(o1.ProfilGoster());

            //Console.WriteLine(o1.GetOgrenciSec());
            //Console.WriteLine(o1.DogumGunu());

            //Ogrenci3 o3 = new Ogrenci3();
            //o3.OgrenciNo = 12345;

            //Console.WriteLine(o3.OgrenciNo);
            Console.ReadKey();
        }

    }
   

    
}

