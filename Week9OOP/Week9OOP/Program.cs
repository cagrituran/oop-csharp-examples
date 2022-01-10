using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contact contact = new Contact();

           // Calisan c = new Calisan();

            //c.Kimsin();

            //Ogretmen o = new Ogretmen();

            //Birey b = new Birey();
            
            //b.AdSoyad = "asdasdasd";
            //Ogretmen o = new Ogretmen();

              A a = new A();

            D d = new D();

            Doktor i = new Doktor("Ali");
          
            Console.Read();
           
            
        }
    }


    class Insan
    {
        public string Isim { get; set; }
        public Insan(string isim)
        {
            Console.WriteLine(isim+" Base");
        }
    }

    class classA
    {
        public int a = 4;

        class classB:classA
        {

        }

        class Z:Ogretmen
        {

        }

    }

   
  

    class Doktor:Insan
    {
        public Doktor(string isim):base(isim)
        {
            Console.WriteLine(isim+"-Derived");
        }
    }


    class A
    {
        public A()
        {
            Console.WriteLine("public A() - A created");
        }
        public void f1()
        {

        }
    }

    class B:A
    {
        public B()
        {
            Console.WriteLine("public B() - B created");
        }
    }

    class C:B
    {
        public C()
        {
            Console.WriteLine("public C() - C created");
        }
    }

    class D:C
    {
        public D()
        {
            Console.WriteLine("public D() - D created");
        }
    }





    public class Birey
    {

        private protected string AdSoyad { get; set; }
        public int Yas { get; set; }
        internal char Cinsiyet { get; set; }
        public virtual void Kimsin()
        {
            Console.WriteLine("Ben bir bireyim");
        }

        public virtual void M1()
        {
            //1 .....
        }
    }

   public class Calisan:Birey
    {
        public decimal Maas { get; set; }
        public string GorevUnvani { get; set; }

        public override void Kimsin()
        {
            Console.WriteLine("Ben bir çalışanım");
        }

        public override void M1()
        {
         
           
            //1 .....
        }
    }

    public class Ogretmen:Calisan
    {
        public int Brans { get; set; }
        public override void Kimsin()
        {
            Console.WriteLine("Ben bir öğretmenim!");
        }
    }

    public class TemzilikGorevlisi:Calisan
    {

    }

    public class Ogrenci:Birey
    {
        public int Numara { get; set; }
        public string Bolum { get; set; }

        public override void Kimsin()
        {
            Console.WriteLine("Ben bir öğrenciyim");
            AdSoyad = "adasd";
        }
    }

    class Contact
    {
        public int a = 5;
        private int b = 6;
        internal int c = 4;
        protected int d = 6;
        protected internal int e;
        private protected int f = 3;


    }
}
