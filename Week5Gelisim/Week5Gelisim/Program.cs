using System;

namespace Week5Gelisim
{
    class Program
    {
        public static void Main(string[] args)
        {

            //var x = 123456789012345;
            //var y = 123456789012345;

            //Matematikci m1 = new Matematikci();

            ////Console.WriteLine(m1.Toplama(x,y));

            // m1.BilgiYaz("Aydın");
            // m1.BilgiYaz(35);

            AsiriYuklemeOrnek asiriYuklemeOrnek = new AsiriYuklemeOrnek();

            //Console.WriteLine("-----BilgiYazDetay()-------");
            //asiriYuklemeOrnek.BilgiYazDetay();

            //Console.WriteLine("-----BilgiYazDetay(string ad)-------");
            //asiriYuklemeOrnek.BilgiYazDetay("Aydın");



            //Console.WriteLine("-----BilgiYazDetay(string ad, string soyad)-------");
            //asiriYuklemeOrnek.BilgiYazDetay("Aydın","Seçer");


            //Console.WriteLine("-----BilgiYazDetay(string ad, string soyad, int yas)-------");
            //asiriYuklemeOrnek.BilgiYazDetay("Aydın", "Seçer",38);

            // asiriYuklemeOrnek.BilgiYazDetay();

            // ExpressionBodiedMethods.Islem(2, 3, 2);

            // ReferecesAndValueTypes.Yaz();
            ReferecesAndValueTypes.Yaz();
        }
    }

    class ReferecesAndValueTypes
    {
        //ref 
        static int x = 5;

        static void Katla(int x)
        {
            x = 2 * x;
        }

        static void Katla2(ref int tmp)
        {
            tmp = 2 * tmp;
        }

        public static void Yaz()
        {

            Console.WriteLine("x: " + x);
            Katla2(ref x);
            Console.WriteLine("x: " + x);

        }

        //out
        static int y;

        static void KatlaY(int y)
        {
            y = 2 * y;
        }

        static void Katla2Y(out int tmp)
        {
            tmp = 0;
            tmp= 2 * tmp;
        }

        public static void YazY()
        {

            Console.WriteLine("y: " + y);
            Katla2Y(out y);
            Console.WriteLine("y: " + y);

        }

    }

    class ExpressionBodiedMethods
    {

        public int KupAl(int x)
        {
            return x * x * x;
        }

        public static int KupAl2(int x) => x * x * x;


        public static void Islem(int x, int y, int islemtip)
        {

            if (islemtip == 1)
            {
                void Sum() => Console.WriteLine(x + y);

                Sum();
            }
            if (islemtip == 2)
            {
                void Diff() => Console.WriteLine(x - y);

                Diff();
            }
            if (islemtip == 3)
            {
                void Prod() => Console.WriteLine(x + y);

                Prod();
            }
            if (islemtip == 4)
            {
                void Div() => Console.WriteLine(x + y);

                Div();
            }
        }


    }

    class AsiriYuklemeOrnek
    {
        public void BilgiYazDetay()
        {
            string ad;
            string soyad;
            int yas = 0;

            Console.Write("Adınız: ");
            ad = Console.ReadLine();

            Console.Write("Soyadınız: ");
            soyad = Console.ReadLine();

            Console.Write("Yaşınız: ");
            yas = int.Parse(Console.ReadLine());

            Console.WriteLine("***************");

            string data = $"Adınız: {ad}\nSoyadınız: {soyad}\nYaşınız: {yas}";
            Console.WriteLine(data);
        }

        public void BilgiYazDetay(string ad)
        {

            string soyad;
            int yas = 0;

            Console.Write("Soyadınız: ");
            soyad = Console.ReadLine();

            Console.Write("Yaşınız: ");
            yas = int.Parse(Console.ReadLine());

            Console.WriteLine("***************");

            string data = $"Adınız: {ad}\nSoyadınız: {soyad}\nYaşınız: {yas}";
            Console.WriteLine(data);
        }
        public void BilgiYazDetay(string ad, string soyad)
        {


            int yas = 0;

            Console.Write("Yaşınız: ");
            yas = int.Parse(Console.ReadLine());

            Console.WriteLine("***************");

            string data = $"Adınız: {ad}\nSoyadınız: {soyad}\nYaşınız: {yas}";
            Console.WriteLine(data);
        }
        public void BilgiYazDetay(string ad, string soyad, int yas)
        {

            string data = $"Adınız: {ad}\nSoyadınız: {soyad}\nYaşınız: {yas}";

            Console.WriteLine(data);
        }

    }

    class Matematikci
    {



        public void BilgiYaz(string deger)
        {
            Console.WriteLine($"Adınız: {deger}");

        }
        public void BilgiYaz(int deger)
        {
            Console.WriteLine($"Yaşınız: {deger}");

        }

        public int Toplama(int x, int y)
        {

            return x + y;
        }


        public double Toplama(double x, double y)
        {

            return x + y;
        }

        public long Toplama(long x, long y)
        {

            return x + y;
        }
    }


}
