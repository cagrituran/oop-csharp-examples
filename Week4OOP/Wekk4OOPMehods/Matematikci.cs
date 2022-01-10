using System;
namespace Wekk4OOPMehods
{
   
    public class Matematikci
    {


        public Matematikci()
        {
            cnt++;
            cnt2++;
        }

        public static int Faktoriyel(int n)
        {
            if (n == 0)
                return 1;

            return n * Faktoriyel(n - 1);

        }

        int a = 5;
        public static int b = 5;

        public static int cnt=0;
        public int cnt2 = 0;


        public int GetCnt()
        {
            return cnt;
        }
        public int GetCnt2()
        {
            return cnt2;
        }


    }
}
