using System;

//çok boyutlu diziler
namespace Week7OOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            int[] arr1 = { 1, 2, 3 };


            int[,] arr2 =
            {
                    { 1, 2, 5 },
                    { 2, 3, 6 },
                    { 3, 3, 7 },
                    { 3, 4, 6 }
            };

            int[,] arr3 = new int[3, 2];

            arr3[0, 0] = 1;
            arr3[0, 1] = 2;
            arr3[1, 0] = 2;
            arr3[1, 1] = 3;
            arr3[2, 0] = 3;
            arr3[2, 1] = 4;

            //MYaz(arr1);
            //MYaz(arr2);
            //MYaz(arr3);

            //arr1.MYaz();
            //arr3.MYaz();

            //arr2.MTopla(arr2).MYaz();

            //arr2.MYaz();

            //arr2.MTranspoze().MTranspoze().MYaz();

            //jagged arrays =düzensiz diziler

            int[][] arr4 =
            {
                new int[]{1,2,5},
                new int[]{1,2,3,4,5,6,7},
                new int[]{1},
                new int[]{1,3},
                new int[]{1,4,5,5,6},
                new int[]{1,5,4,3,56,43,7,3,2,4,45},

            };

            for (int i = 0; i < arr4.GetLength(0); i++)
            {
                for (int j = 0; j < arr4[i].GetLength(0); j++)
                {
                    Console.Write($"{arr4[i][j]} ");
                }

                Console.WriteLine();
            }
        }




        //static int[] MCarp(int[,] A, int[,] B)
        //{
        //    int ma = A.GetLength(0);
        //    int na = A.GetLength(1);
        //    int mb = B.GetLength(0);
        //    int nb = B.GetLength(1);



        //    int[,] carpim = new int[ma, nb];

        //    for (int i = 0; i < ma; i++)
        //    {
        //        for (int j = 0; j < nb; j++)
        //        {
        //            int pt = 0;

        //            for (int k = 0; k < na; k++)
        //            {
        //                for (int l = 0; l < mb; l++)
        //                {
        //                    pt+= A[k, l] * B[l, k];
        //                }
        //            }

        //            carpim[i, j] = pt;

        //        }
        //    }



    }



}
