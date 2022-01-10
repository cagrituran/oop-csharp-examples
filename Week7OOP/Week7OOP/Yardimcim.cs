using System;
namespace Week7OOP
{
    //extension methods
    public static class Yardimcim
    {
        //extension method
        public static void MYaz(this int[,] arr)
        {
            int m = arr.GetLength(0);
            int n = arr.GetLength(1);


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        //extension method
        public static void MYaz(this int[] arr)
        {
            int m = arr.Length;
            for (int i = 0; i < m; i++)
                Console.Write($"{arr[i]} ");

            Console.WriteLine();
            Console.WriteLine();
        }
        //extension method
        public static void MYaz(this int arr)
        {

            Console.WriteLine(arr);

            Console.WriteLine();
            Console.WriteLine();
        }
        //extension method
        public static int[,] MTopla(this int[,] A, int[,] B)
        {
            int ma = A.GetLength(0);
            int na = A.GetLength(1);
            int mb = B.GetLength(0);
            int nb = B.GetLength(1);

            if (ma != mb || na != nb)
                throw new Exception("Boyutlar uyumsuz!...");

            int[,] top = new int[ma, na];

            for (int i = 0; i < ma; i++)
            {
                for (int j = 0; j < na; j++)
                {
                    top[i, j] = A[i, j] + B[i, j];
                }
            }

            return top;

        }
        //extension method
        public static int[,] MTranspoze(this int[,] A)
        {
            int m = A.GetLength(0);
            int n = A.GetLength(1);

            int[,] trans = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    trans[i, j] = A[j, i];
                }

            }

            return trans;

        }

    }
}
