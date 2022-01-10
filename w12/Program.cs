using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Week12OOPGelisim
{
    //INPUT OUTPUT  System.IO
    class Program1
    {
        static void Main(string[] args)
        {
            // StringWriter sw = new StringWriter();
            //TextWriter tw = StreamWriter();

            var path = @"D:\test.dat";

            //FileStream fs = File.Create(path);
            //fs.Close();


            //StreamWriter sw = new StreamWriter(path);
            //sw.WriteLine("Hello World");
            //sw.WriteLine("How are you");
            //sw.Close();


            //StreamReader sr = new StreamReader(path);
            //int data = 0;

            //while ((data = sr.Read()) != -1)
            //{
            //    Console.WriteLine((char)data);
            //}

            //sr.Close();

            /*
            FileStream fs = new FileStream(path,FileMode.Create, FileAccess.Write);
            string data = "Hello world";


            byte[] info = new UTF8Encoding(true).GetBytes(data);
            fs.Write(info, 0, info.Length);
            
            
            fs.Flush();

            fs.Close();

            FileStream fs2 = new FileStream(path,FileMode.Open, FileAccess.Read);

            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            while (fs2.Read(b, 0, b.Length) > 0)
            {
                Console.WriteLine(temp.GetString(b));
            }

            fs2.Close();*/

            var di = Directory.CreateDirectory(@"D:\MyFolder");
            var fullPath = Path.Combine(di.FullName, "file1.dat");
            // File.Create(fullPath);
            File.WriteAllText(fullPath, "Hello how are you?....");


            Console.WriteLine(File.ReadAllText(fullPath));

            foreach (var item in DriveInfo.GetDrives())
            {
                Console.WriteLine(item.Name + " " + item.DriveType);
            }

            //foreach (var item in Directory.GetDirectories(@"D:\YTULIVE", "*",SearchOption.AllDirectories))
            //{
            //    Console.WriteLine(item);
            //}
            int cnt = 0;
            //foreach (var item in Directory.GetFiles(@"D:\YTULIVE", "*.*", SearchOption.AllDirectories))
            //{
            //    Console.WriteLine(item);
            //    cnt++;
            //}


            foreach (var item in Directory.GetFiles(@"D:\YTULIVE", "*.*", SearchOption.AllDirectories))
            {
                FileInfo fi = new FileInfo(item);
                //                if (fi.Extension==".xml")
                //                {
                //Console.WriteLine(item);
                //                cnt++;
                //                }
                if (fi.CreationTime.Year == 2019 && fi.CreationTime.Month == 10)
                {
                    Console.WriteLine(item);
                    cnt++;
                }



            }

            // DirectoryInfo di = new DirectoryInfo();

            Console.WriteLine(cnt + " Adet dosya bulundu...");

            Console.Read();
        }
    }

    //Generic Methods and Icomparable interface
    class Program2
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            double[] arr2 = { 1.9, 2, 3, 4, 5.2 };
            char[] arr3 = { 'A', 'y', 'd', 'ı', 'n' };

            //DiziGoster(arr1);
            //DiziGoster(arr2);
            //DiziGoster(arr3);

            // Console.WriteLine(Max("Ali","züleyha","zeliha"));
            Kisi k1 = new Kisi { Yas = 1 };
            Kisi k2 = new Kisi { Yas = 3 };
            Kisi k3 = new Kisi { Yas = 19 };


            Console.WriteLine(Max(k1, k2, k3));
            Console.ReadLine();
        }
        class Kisi : IComparable<Kisi>
        {
            public string AdiSoyadi { get; set; }
            public int Yas { get; set; }

            public int CompareTo(Kisi other)
            {
                if (this.Yas > other.Yas)
                    return 1;
                else if (this.Yas < other.Yas)
                    return -1;
                else
                    return 0;
            }

            public override string ToString()
            {
                return Yas.ToString();
            }
        }
        public static T Max<T>(T x, T y, T z) where T : IComparable<T>
        {
            var max = x;
            if (y.CompareTo(max) > 0)
                max = y;
            if (z.CompareTo(max) > 0)
                max = z;

            return max;


        }

        //static T Topla<T>(T x1, T x2) where T : IComparable<T>
        //{

        //        return x1.CompareTo() + Convert.ToInt32(x2);

        //}

        static void DiziGoster<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        //static void DiziGoster(int [] arr)
        //{
        //    foreach (var item in arr)
        //    {
        //        Console.Write(item +" ");
        //    }
        //    Console.WriteLine();
        //}
        //static void DiziGoster(double[] arr)
        //{
        //    foreach (var item in arr)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}
        //static void DiziGoster(char[] arr)
        //{
        //    foreach (var item in arr)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}
    }

    //collections
    class Program3
    {
        static void Main(string[] args)
        {
            //object[] obj = {1,"asdasd",2.3,new Program1() };
            object[] obj = { 1, 2, 4 };

            //Array.Sort(obj);

            ArrayList lst = new ArrayList();
            //lst.Add(1);
            //lst.Add("Ayşe");
            //lst.Add(Math.PI);
            //lst.Sort();
            Hashtable hashtable = new Hashtable();
            hashtable.Add("aydin", 38);

            Stack stack = new Stack();
            stack.Push("dsadas");
            stack.Pop();

            Queue queue = new Queue();
            queue.Enqueue("sdasd");
            queue.Dequeue();
            queue.Peek();

            SortedList sl = new SortedList();







            Console.Read();





        }
    }

    //generic classes
    class Program4
    {
        static void Main(string[] args)
        {
            BenimListem<int> benimListem = new BenimListem<int>(5);

            benimListem.Add(1);
            benimListem.Add(2);
            benimListem.Add(3);
            benimListem.Add(4);
            benimListem.Add(5);
            //  benimListem.Add(5);
            // benimListem.PrintList();
            benimListem[0] = 101;

            benimListem.PrintList();

            Console.WriteLine(benimListem[3]);

            //foreach (var item in benimListem)
            //{
            //    Console.WriteLine(item);
            //}
            Console.Read();


        }
    }

    class BenimListem<T> 
    {
        private int Size = 0;
        private int inx = 0;
        private T[] list;
        public BenimListem(int Size)
        {
            this.Size = Size;
            list = new T[Size];
        }

        public void Add(T t)
        {
            if (inx<Size)
            {
                list[inx] = t;
                inx++;
            }
            else
            {
                throw new Exception("Index out of bound!");
            }

        }
        public void Remove(T t)
        {
            if (inx > 0)
                inx--;
            else
                throw new Exception("Index out of bound!");
        }

        public void PrintList()
        {
            for (int i = 0; i < inx; i++)
                Console.WriteLine(list[i]);
        }

        //public IEnumerator<T> GetEnumerator()
        //{
        //    return this.GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    foreach (var e in list)
        //        yield return e;
        //}

        public T this[int i]
        {
            get { return list[i]; }
            set { list[i] = value; }
        }
    }


    //system.generic.collections
    class Program5
    {
        static void Main(string[] args)
        {
            
            List<A> lst = new List<A>();

            lst.Add(new A());
            lst.Add(new A());

            //  lst.Sort();

            Dictionary<string, int> dct = new Dictionary<string, int>();
            dct["ali"] = 34;

            LinkedList<double> llst = new LinkedList<double>();


            Stack<int> stk = new Stack<int>();


            Queue<string> queue = new Queue<string>();
            queue.Enqueue("wqe");


            SortedList<string, double> slist = new SortedList<string, double>();




        }

        class A:IComparable<A>
        {
            public int ID { get; set; }

            public int CompareTo(A other)
            {
                throw new NotImplementedException();
            }
        }
    }


}
