using System;
using System.IO;

namespace Week4OOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //SayiYaz(2, 1, 100);



            /*Console.Write("Renk harfini giriniz: ");
            char renk = char.Parse(Console.ReadLine().ToUpper());

            // selection statement
            switch (renk)
            {
                case 'K':
                case 'R':
                    Console.WriteLine("Kırmızı");
                    break;
                case 'Y':
                case 'G':
                    Console.WriteLine("Yeşil");
                    break;
                case 'S':
                case 'B':
                    Console.WriteLine("Siyah");
                    break;
                default:
                    break;
            }*/

            /*Console.Write("Cinsiyet Bilgisi Giriniz: ");
            char cinsiyet = char.Parse(Console.ReadLine().ToUpper());

            string sonuc = "";

            sonuc = (cinsiyet == 'E' || cinsiyet == 'M') ? "Erkek" : (cinsiyet=='F'||cinsiyet=='K')?"Kadın":"Hatalı girdi!...";


            

            Console.WriteLine(sonuc);*/


            //Loops***********************

            //sayaç tabanlı
            /*
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine(  i );
            }

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }*/



            //int i = 50;
            //for (;  i>= 10; i--)
            //{
            //    Console.WriteLine(i);
            //}


            Random random = new Random();
            //infinty sonsuz döngü
            //for (;;)
            //{
            //    var val = random.Next(0, 150);
            //    Console.WriteLine(val);
            //    if (val == 100)
            //        break;
            //}

            //for (int j = 1; j <= 10; j++)
            //{
            //    for (int i = 1; i <= 100; i++)
            //    {
            //        if (i % 7 == 0)
            //            break;

            //        Console.WriteLine(i);
            //    }
            //}

            //counter based loop
            //int c = 1;
            //while (c<=100)
            //{
            //    Console.WriteLine(random.Next());
            //    c++;

            //}

            //sentinel based loop
            //while (conn.IsOpen())
            //{
            //    do something.....
            //}

            //do
            //{
            //    //.......
            //} while (boolean);

            //while (boolean)
            //{
            //    //.....
            //}


            //while (true)
            //{
            //    Console.Write("Enter Number: ");
            //    int res = int.Parse(Console.ReadLine());
            //    if (res == -1)
            //        break;
            //}


            //SayiYazRec(100);

            //label loop
            //    int i = 0;
            //burayaGel:
            //    Console.WriteLine(i);
            //    i++;
            //    if (i <= 10)
            //        goto burayaGel;

            //for (int i = 0; i < 10; i=i+1)
            //{

            //}

            int i = 0;
           while (i<=100)
            {
                Console.WriteLine(i);
               // i++;//post increment
                ++i;//pre increment
            //    i += 1;
            //    i = i + 1;

            //    i *= 2;
            //    i /= 4;

            //    i %= 5;

            //    i = 3;
            }

            //int n = 5;
            //int i = 1;
            //int fac = 1;
            //while (i<=n)
            //{
            //    fac *= i;
            //    i++;
            //}
            //Console.WriteLine(fac);
            /*
            foreach (var item in Directory.GetFiles(Environment.CurrentDirectory))
            {
                Console.WriteLine(item);
            }

            int[] number = { 1,2,3,4,5};

            foreach (var item in number)
            {
                Console.WriteLine(item);
            }*/



            Console.Read();

        }

        static void SayiYazRec(int son)
        {

            if (son <= 0)
                return;

            SayiYazRec(son - 1);

            Console.WriteLine(son);


        }

        //Control statements if
        //metot tekcift = 1  tek sayılar, tekcift=2 çift sayıları yazacak
        static void SayiYaz(int tekcift, int bas, int bit)
        {

            if (tekcift == 1)
            {
                for (int i = bas; i <= bit; i++)
                {
                    if (i % 2 != 0)
                        Console.WriteLine(i);
                }
            }
            else if (tekcift == 2)
            {
                for (int i = bas; i <= bit; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Hatalı girdi!");
            }
        }


    }
}

