using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace projectt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 0;


            while (i < 3)
            {
                Console.WriteLine("---Hoşgeldiniz---");
                Veriler.sira[i] = 0;
              
                Console.Write("Araç Türü:");
          
                Veriler.aracturu[i] = Console.ReadLine();
                
                Console.Write("Plaka Giriniz:");
                Veriler.plaka[i] = Console.ReadLine();
                Veriler.sira[i] = i + 1;
                Console.WriteLine($"Sıranız:{i+1}");
                DateTime bugun = DateTime.Now;
                string x = bugun.Hour + ":" + bugun.Minute + ":" + bugun.Second;
                Veriler.zaman[i] = x;
                Console.WriteLine("Saat:" + x);
                i++;

                

           

            }
           
            try
            {
                Console.Write("Kullanıcı Adı:");
                string kullaniciadi = Console.ReadLine();
                Console.WriteLine("Şifre:");
                string sifre = Console.ReadLine();
                if(Admin.Getadı()!= kullaniciadi && Admin.GetSifre() != sifre)
                {
                    throw new Hatam();
                }
                Goster.DiziGoster(Veriler.plaka);
                Goster.DiziGoster(Veriler.zaman);
                Console.WriteLine();
                int admingiris;
                Sorgula.Sorgu(admingiris = int.Parse(Console.ReadLine()));
                

            }
            catch(Hatam Hata)
            {
                Console.WriteLine(Hata.Message);
            }
            Console.WriteLine("İyi Günler...");
           
            
        }
    }

    static public class Veriler
    {   
        static public int[] sira = new int[3];
        static public string[] plaka = new string[3];
        static public string[] aracturu = new string[3];
        static public string[] zaman = new string[3];
        



    }
    static public class Goster
    {
        static public void DiziGoster<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + "    ");
            }
            Console.WriteLine();
        }
    }
    static public class Sorgula
        {
            static public void Sorgu(int deg)
            {
            int t = deg-1;
            Console.Write(Veriler.plaka[t]+" ");
            Console.WriteLine(Veriler.aracturu[t]);
            }

        }
     static public class Admin
    {
        static private string adı = "admin";
        static private string sifre = "otopark";

        static public string Getadı()
        {
            return adı;
        }
        static   public string GetSifre()
        {
            return sifre;
        }


    }
    public class Hatam : Exception
    {
        public Hatam()
        {
            Console.WriteLine("Kullanıcı ve Şifre Geçersiz...");
        }

        public Hatam(string message) : base(message)
        {
            
        }

        public Hatam(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Hatam(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        
    }

}
