using System;
namespace Wekk4OOPMehods
{
    public class SayisalLoto
    {


        public static void SayiDizisiUret()
        {
            int start = 1;
            int end = 49;
            int[] sonuc = new int[6];

            Random random = new Random();

            int tmp = 0;
            for (int i = 0; i < 6; i++)
            {
                tmp = random.Next(start, end);
                if (CakismaVarmi(sonuc, tmp))
                {
                    i--;
                    continue;
                }
                else
                {
                    sonuc[i] = tmp;
                }
                


            }

            Array.Sort(sonuc);


            foreach (var item in sonuc)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }

       static bool CakismaVarmi(int[] dizi, int sayi)
       {
            foreach (var item in dizi)
                if (item == sayi)
                    return true;

            return false;  
       }


        public void MesajVer(string M3,string m1 = "M1",int m2=0)
        {
            Console.WriteLine(M3);
            Console.WriteLine(m1);
            Console.WriteLine(m2);
        }

        public void TestMetot(int a,int b, int c)
        {

            Console.WriteLine((a+b)/c);
        }
    }
}
