using System;

namespace Week5Arrays2
{
    class Program
    {
        public static void Main(string[] args)
        {

            //int[] x = {25, -2, 3, 1, 0, 100, -19, 56 };
            ////DiziYaz(x);
            ////DiziYaz(Sirala(x));
            ////DiziYaz(x);

            //int sonuc = Topla2(1,4,7,3,4,5,6,7);

            //Console.WriteLine(sonuc);



            //çok boyutlu diziler

            //int[,] matris = new int[, 3];

            int[,] matris  ={

                            {1,2,3},
                            {4,5,6}

                            };

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write($"{matris[i, j]}  ");
                }
                Console.WriteLine();
            }

        }




        static int Topla(int [] a)
        {
            int toplam = 0;
            foreach (var item in a)
            {
                toplam += item;
            }

            return toplam;
        }
        static int Topla2(params int[] a)
        {
            int toplam = 0;
            foreach (var item in a)
            {
                toplam += item;
            }

            return toplam;
        }

        static int[] Sirala( int[] a)
        {
            int temp; 
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    if (a[i]>a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }

            return a;
        }

        static void DiziYaz(int [] a)
        {
            foreach (var item in a)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
