using System;

//ARRAYS

namespace Week5Arrays
{
    class Program1
    {
        public static void Main(string[] args)
        {



            //c bir referans(pointer), c ilk elemanın adresini rutar.

            //c sabit uzunlukludur, fixed length

            /*

            int x = 5;
            int y = 77;


            int[] c = new int[3];
            int[] d;

            d = new int[3];

            double[] dbl;

            string s = "ali";

            char[] s2 = { 'a', 'l', 'i' };

            string[] isimler;

            Ogrenci[] ogrenciler = new Ogrenci[10];

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                ogrenciler[i].AdiSoyadi = "x";
                ogrenciler[i].Yas = 12;
            }
            */
            //intialization diziyi başlatma;


            //init 1
            int[] a1=new int[3];

            a1[0] = 1;
            a1[1] = 1;
            a1[2] = 1;

            //direct
            int[] a2 = { 1,2,3,4,577,0 };

            //Console.WriteLine(a2[4]);

            //for (int i = 0; i < a2.Length; i++)
            //{
            //    Console.WriteLine(a2[i]);
            //}

            //for (int i = a2.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(a2[i]);
            //}

            //int i = 0;
            //while (i<a2.Length)
            //{
            //    Console.WriteLine(a2[i]);
            //    i++;
            //}

            

            Array.Resize( ref a2, 4);

            foreach (var item in a2)
            {
                Console.WriteLine(item);
            }

        }


    }

    //method parametreleri olarak diziler
   

    class Ogrenci
    {

        public string AdiSoyadi  { get; set; }
        public int Yas { get; set; }
    }

}
