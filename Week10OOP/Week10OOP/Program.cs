using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Polymorphism via Inheritance
namespace Week10OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowMessage(new A());
            ShowMessage(new B());
            ShowMessage(new C());
            ShowMessage(new D());
            // ShowMessage(new E());

            Console.Read();

        }

        static void ShowMessage(A baseObject)
        {
            baseObject.DoSomething();
        }
    }

    class E
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("The Class E did something!");
        }
    }

    class A
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("The Class A did something!");
        }
    }
    class B : A
    {
        public override void DoSomething()
        {
            Console.WriteLine("The Class B did something!");
        }
    }
    class C : A
    {
        public override void DoSomething()
        {
            Console.WriteLine("The Class C did something!");
        }
    }

    class D : C
    {
        public override void DoSomething()
        {
            Console.WriteLine("The Class D did something!");
        }
    }

}

//Polymorphism via Abstract classes
namespace Week10OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //error
            // ShowMessage(new A());
            ShowMessage(new B());
            ShowMessage(new C());
            ShowMessage(new D());

            Console.Read();

        }

        static void ShowMessage(A baseObject)
        {
            baseObject.DoSomething();
            baseObject.DoSomething2();
        }
    }

    abstract class A
    {
        public abstract void DoSomething();

        public virtual void DoSomething2()
        {
            Console.WriteLine("The Class A did something!");
        }

    }

    class B : A
    {
        public override void DoSomething()
        {
            Console.WriteLine("The Class B did something!");
        }
        public override void DoSomething2()
        {
            Console.WriteLine("The Class B did something!");
        }
    }

    class C : A
    {
        public override void DoSomething()
        {
            Console.WriteLine("The Class C did something!");
        }
        public override void DoSomething2()
        {
            Console.WriteLine("The Class C did something!");
        }
    }

    class D : C
    {
        public override void DoSomething()
        {
            Console.WriteLine("The Class D did something!");
        }
        public override void DoSomething2()
        {
            Console.WriteLine("The Class D did something!");
        }
    }

}

//Polymorphism via Interfaces
namespace Week10OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IGetDb getDb = new MySQLDB();
            InserData(new OracleDB());
            InserData(new MySQLDB());
        }

        static void InserData(IGetDb getDb)
        {
            getDb.GetDb();
            getDb.SaveLog();
        }
    }

    interface IGetDb : ILogger
    {
        void GetDb();
    }
    interface ILogger
    {
        void SaveLog();
    }

    class OracleDB : IGetDb
    {
        public void GetDb()
        {
            Console.WriteLine("Oracle connection successfull.");
        }

        public void SaveLog()
        {
            Console.WriteLine("Oracle Log saved.");
        }
    }

    class MySQLDB : IGetDb
    {
        public void GetDb()
        {
            Console.WriteLine("MySQLDB connection successfull.");
        }

        public void SaveLog()
        {
            Console.WriteLine("MySQLDB Log saved.");
        }
    }
}


//Exception Handling
namespace Week10ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

          


            //string kullanciadi = Console.ReadLine();
            //if (kullanciadi!="root")
            //{
            //    throw new Exception("Yetkisiz kullanıcı");
                
            //}


            //try
            //{
            //    int a =Convert.ToInt32(Console.ReadLine());
            //    int b = Convert.ToInt32(Console.ReadLine());


            //    int sonuc = a / b;

            //    Console.WriteLine("a/b = " + sonuc);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    //saveLog(ex);
            //    Console.WriteLine(ex.Message);
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    //mutlaka gelinir.
            //}



            //Console.WriteLine("İşlem tamamlandı!");

            A test=null;

            test = test ?? new A();

            test?.F();



            Console.ReadLine();
        }
    }

    class A
    {
        public void F()
        {
            Console.WriteLine("Hello");
        }

    }

    class BenimHatam:Exception
    {
        public BenimHatam():base("Bu hata varsayılan hata")
        {

        }

        public BenimHatam(string ozelhata):base(ozelhata)
        {

        }

        public BenimHatam(string ozelhata, Exception inner):base(ozelhata,inner)
        {

        }
    }
}
