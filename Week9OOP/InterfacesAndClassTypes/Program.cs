using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndClassTypes
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Matematik : IMath
    {
        public double Bol(double a, double b)
        {
            return a / b;
        }

        public double Carp(double a, double b)
        {
            return a * b;
        }

        public double Cikar(double a, double b)
        {
            return a - b;
        }

        public double Topla(double a, double b)
        {
            return a + b;
        }
    }
    interface IMath
    {
        double Topla(double a, double b);
        double Cikar(double a, double b);
        double Carp(double a, double b);
        double Bol(double a, double b);
    }


    //Standart sınıf, Miras alınabilir, alabilir, instance alınabilir (new ile objesi oluşturulabilir).
    class Class1
    {
       // Class3 c = new Class3();

    }

    //Statik sınıf, Miras alamaz, alınamaz, new ile oluşturulamaz, private static yapıcı metodu olabilir, statik sınıfın tüm üyeleri statiktir.
    static class Class2
    {
        static int a;
        public static string b;

        static void f()
        {

        }

        public static int f2()
        {
            return 1;
        }

    }

  
    //Sealed sınıf, new ile türetilebilir, miras alınamaz
    sealed class Class3{
        

    }


    //Partial sınıf, parçalı sınıf
    partial class Islemler
    {
        int a = 4;
        void  Toplama(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }


    //Abstract, soyut sınıflar, Interface gibi davranabilir ayrıca sınıf gibi de davranabilir. New ile türetilemez, sadece miras alınır. abstract sınıfın abstract üyelerinin gövdesi olamaz. abstract olamyan üyerlerde gövde içerir

    abstract class MathHelper
    {
        const double PI=3.14;

        public virtual double GetPI()
        {
            return PI;
        }
       
        public abstract double Topla(int a, int b);
        public abstract double Cikar(int a, int b);
        public abstract double Carp(int a, int b);
        public abstract double Bol(int a, int b);

    }

    class Math2 : MathHelper
    {
        public override double Bol(int a, int b)
        {
            return GetPI();
        }

        public override double Carp(int a, int b)
        {
            throw new NotImplementedException();
        }

        public override double Cikar(int a, int b)
        {
            throw new NotImplementedException();
        }

        public override double Topla(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
