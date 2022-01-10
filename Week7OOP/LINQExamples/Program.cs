using System;
using System.IO;
using System.Linq;
using System.Net;

namespace LINQExamples
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Language INtegrated Query


            int[] numbers = { 0, -3, 5, 4, 1, 9 };

            string[] names = { "Aydın", "Zeki", "Süleyman", "Halime", "Nurcan" };


            var data = from p in numbers
                       where p % 2 == 0
                       select p;

            var data2 = (from p in numbers
                         where p % 2 != 0
                         select p).Sum();


            var data3 = numbers
                        .Where(p => p % 2 == 0)
                        .OrderByDescending(p => p)
                        .Take(1);

            var data4 = numbers.Max(p => p % 2 == 0);

            //Console.WriteLine(data2);

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}

            var data5 = from p in Directory.GetLogicalDrives()
                        select p;




            //foreach (var item in data5)
            //{
            //    Console.WriteLine(item);
            //}



            //var files = (from p in Directory.GetFiles("/Users/asecer79/Google Drive/Girdiğim Dersler/_OgrenciPublicErisim/Yazılımlar","*",SearchOption.AllDirectories)
            //            select new FileInfo(p)).OrderByDescending(q=>q.Length);

            //foreach (var item in files)
            //{
            //    Console.WriteLine(item.Name + ": "+item.Length);
            //}


            //int cnt = 1;

            //foreach (var item in files)
            //{
            //    var inx = item.LastIndexOf('/');


            //    var fname = item.Substring(inx+1, item.Length - inx-1);


            //    FileInfo fileInfo = new FileInfo(item);
            //    Console.WriteLine(cnt++ +"-"+fname+ ": "+fileInfo.Length/1000000);
            //}




            WebRequest request = WebRequest.Create("https://gelisim.edu.tr/");

            var output = from p in new StreamReader(request.GetResponse().GetResponseStream()).ReadToEnd()
                         select p;


            foreach (var item in output)
            {
                if (char.IsDigit(item))
                {
                    Console.Write(item);
                }
                else
                {
                    Console.Write(" ");
                }
            }

        }
    }
}
