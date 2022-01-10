using System;

namespace Wekk4OOPMehods
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");

            Matematikci m1 = new Matematikci();

            //Console.WriteLine(m1.a);
            //Console.WriteLine(Matematikci.b);
            Matematikci m2 = new Matematikci();
            Matematikci m3 = new Matematikci();
            Matematikci m4 = new Matematikci();


            Console.WriteLine("CNT:    Static: " + m1.GetCnt());
            Console.WriteLine("CNT:    Static: " + m1.GetCnt());
            Console.WriteLine("CNT:    Static: " + m2.GetCnt());
            Console.WriteLine("CNT:    Static: " + m3.GetCnt());
            Console.WriteLine("CNT:    Static: " + m4.GetCnt());

            Console.WriteLine("CNT2: Instance: " + m1.GetCnt2());
            Console.WriteLine("CNT2: Instance: " + m2.GetCnt2());
            Console.WriteLine("CNT2: Instance: " + m3.GetCnt2());
            Console.WriteLine("CNT2: Instance: " + m4.GetCnt2());*/


            //Console.WriteLine(Math.PI );

            //Console.WriteLine(Math.Sin(90*Math.PI/180));



            //Console.WriteLine(Matematikci.Faktoriyel(5));

            //for (int i = 0; i < 32; i++)
            //{
            //    SayisalLoto.SayiDizisiUret();
            //}

            SayisalLoto sayisalLoto = new SayisalLoto();

            sayisalLoto.MesajVer("TEST","adad");

            sayisalLoto.TestMetot(c: 5, b: 6, a: 6);


            Console.Read();


        }
    }


}
