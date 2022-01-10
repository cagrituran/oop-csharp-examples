using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11OOP
{
    //String ve char arasındaki fark
    class Program1
    {
        static void Main(string[] args)
        {
            //Immutable 
            string s1 = "aydın";
            //s1 = "mehmet";
            string s2 = s1;
            s2 = "aydın1";


            Console.WriteLine(s1);
            Console.WriteLine(s2);

            A a1 = new A { x = 1 };

            A a2 = (A)a1.Clone();

            a2.x = 2;
            Console.WriteLine(a1.x);

            //Console.WriteLine(a1==a2);

            //Console.WriteLine(s1 == s2);




            //Console.WriteLine(s1.CompareTo(s2));

            //A a1 = new A();
            //A a2 = new A();

            //a1.x = 1;
            //a2.x = 1;

            //Console.WriteLine(a1==a2);
            //Console.WriteLine(a1.CompareTo(a1)); 

            ////Mutable
            //char[] c1 = { 'a', 'y', 'd', 'ı', 'n' };

            //c1[0] = 'z';


            Console.Read();

        }

        class A : IComparable, ICloneable
        {
            public int x;

            public object Clone()
            {
                return new A { x = this.x };
            }

            public int CompareTo(object obj)
            {
                return ((A)obj).x == this.x ? 0 : -1;
            }

            //public static bool operator ==(A a, A b)
            //{
            //    return a.x==b.x;
            //}
            //public static bool operator !=(A a, A b)
            //{
            //    return a.x!=b.x;
            //}
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            //string s1 = "Aydın";
            //s1[1] = 'a';

            //s1=s1.Insert(1, "s");

            //for (int i = 0; i < s1.Length; i++)
            //{
            //    Console.WriteLine(s1[i]);
            //}

            //string uname = "root";
            //string pwd = "123";

            //comehere:

            //Console.Write("UName: ");
            //string UName = Console.ReadLine();
            //Console.Write("Password: ");
            //string Password = Console.ReadLine();

            //if (UName.Equals(uname,StringComparison.OrdinalIgnoreCase)&&Password.Equals(pwd))
            //{
            //    Console.WriteLine("Welcome");
            //}
            //else
            //{

            //    Console.Clear(); 
            //    Console.WriteLine("Un authorized user. Try again!");
            //    goto comehere;
            //}

            string s1 = "US President Donald Trump has said he could work with anybody in No 10 - nine days ahead of a general election. Speaking on a three-day visit to the UK, Mr Trump said he would stay out of the election, that he was a fan of Brexit and he thought PM Boris Johnson was very capable. Mr Trump is in the UK for a Nato summit being held in Watford on Wednesday. He will attend a reception hosted by the Queen at Buckingham Palace later, where protests are expected. The US president was speaking during a breakfast meeting with Nato Secretary General Jens Stoltenberg at the US ambassador's residence in London. During a press conference Mr Trump also said: The US wanted absolutely nothing to do with the NHS, when asked if it would form any part of future trade talks. He added: Never even thought about it, honestly. He himself was a very easy person to work with The US was trying to work something out with the family of teenager Harry Dunn French President Emmanuel Macron was very disrespectful for suggesting Nato was brain dead The US president's comments came moments after he told reporters that he was staying out of the election on 12 December because I don't want to complicate it. President Trump is visiting the UK to attend a Nato summit commemorating the 70th anniversary of the transatlantic organisation. Scotland Yard has said road closures will be in place in central London during the summit. He is due to have separate talks with German Chancellor Angela Merkel and French President Emmanuel Macron. The Queen will host a reception for world leaders, including Mr Trump, at Buckingham Palace later. Protesters are expected to gather outside the palace ahead of the event on Tuesday evening. The friends and family of teenage motorcyclist Harry Dunn are expected to be among them.Mr Dunn's death led to a diplomatic row between the US and UK after a suspect over his death returned to America, claiming diplomatic immunity. A spokesman for Mr Dunn's family said they will join demonstrations in order to make our feelings known to Mr Trump. 'Respect and politeness labour leader Jeremy Corbyn has called for Mr Trump to be treated with respect and politeness during his visit. Ahead of the visit, Mr Corbyn wrote to Mr Trump, demanding assurances that the NHS will be off the table in any post-Brexit US-UK trade talks.However, Mr Johnson said the claims were nonsense and the NHS would not be part of any such trade discussions. Meanwhile, Mr Johnson has told the Sun newspaper that Mr Corbyn wants to disband Nato and accused the Labour leader of being naive to the risk of terrorism. Labour's manifesto says that, in government, it would maintain a commitment to Nato. A spokesman for the party said that Mr Corbyn will do whatever is necessary and effective to keep the British people safe.";

            var shift = -300;
            string enc = "";
            foreach (var item in s1)
            {
                enc += (char)(item + shift);
            }
            Console.WriteLine(enc);

            string dec = "";
            foreach (var item in enc)
            {
                dec += (char)(item - shift);
            }

            Console.WriteLine(dec);

            //List<string> kelimeler = new List<string>();

            // foreach (var item in s1.Split(' '))
            // {
            //     var tmp = "";

            //     if (item.Trim()!="")
            //     {
            //         tmp = item
            //                 .Replace(".", "")
            //                 .Replace(",", "")
            //                 .Replace("'", "")
            //                 .Replace("-", "")
            //                 .Replace(" ", "");

            //         kelimeler.Add(tmp);

            //     }    
            // }

            // kelimeler.Sort();
            // var essiz= kelimeler.Distinct();

            // Dictionary<string, int> freq = new  Dictionary<string, int>();


            // foreach (var item in essiz)
            //     freq[item] = kelimeler.Count(p => p == item);

            // var tmp2 = freq.OrderByDescending(p=>p.Value);

            // foreach (var item in tmp2)
            // {
            //     Console.WriteLine($"{item.Value}---->{item.Key}");
            // }
            //Console.WriteLine(s1.Count(p=>p=='a' || p=='A'));
            //Console.WriteLine(s1.Where(p=>p=='a').ToArray());


            //Console.WriteLine(s1.ToLower());
            //string str1 = "uzmanım.net ile hayat çok güzel";
            //string str2, str3;

            //// Türkçe kültür ile
            //str2 = str1.ToUpper(new CultureInfo("tr-TR", false));

            //// İngilizce - ABD ile
            //str3 = str1.ToUpper(new CultureInfo("en-US", false));

            //Console.WriteLine(str2);
            //Console.WriteLine(str3);


            Console.ReadLine();

            //Console.WriteLine(s1.ToUpper(new CultureInfo("tr-TR", true)));


            //Console.WriteLine(s1.TrimStart());
            //Console.WriteLine(s1.TrimEnd());
            //Console.WriteLine(s1.Trim());
            //Console.WriteLine(s1.Substring(50));
            //Console.WriteLine(s1.Substring(0,49));
            //string filename = @"c:\\ho.ada.sdasd\asdasd.asdasme\files\pdf";


            //var tmp1 = filename.Split('.');
            //Console.WriteLine(tmp1[tmp1.Length-1]);

            // Console.WriteLine(filename.Substring( filename.LastIndexOf('.')+1,3));
            //Console.WriteLine(s1.LastIndexOf('c'));
            // Console.WriteLine(s1[287]);
            // Console.WriteLine(s1.IndexOf('C',6,200));
            //Console.WriteLine(s1.IndexOf("WArranted", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(s1.StartsWith("Soft"));
            //Console.WriteLine(s1.EndsWith("on."));



            Console.Read();
        }
    }

    //StringBuilder class
    class Program3
    {
        static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder(0, 500);

            sb1.Append("Dünya");
            StringBuilder sb2 = sb1;

            sb2[0] = 'Z';

            sb1.Remove(0, 1);

            sb1.Replace("ü", "u");
            // sb2.Append("s");


            Console.WriteLine(sb1);
            Console.WriteLine(sb2);
            //Console.WriteLine(sb1==sb2);

            Console.Read();
        }
    }


    //Char methods
    class Program4
    {
        static void Main(string[] args)
        {
            string rawdata = "Aydın      Seçer ' ,! ; Merhaba, @, - / NAsılsın?";

            string filtered = "";
            char newval = '1';
            char oldval = '1';
            foreach (var item in rawdata)
            {

                if (Char.IsLetterOrDigit(item) || item == ' ')
                {
                    newval = item;
                    if (!(newval == oldval&&item==' '))
                    {
                        oldval = item;
                        filtered += item;
                    }
                }
            }
           // filtered = filtered.Replace("  ", " ");

            Console.WriteLine(filtered);


            Console.ReadLine();
        }
    }
}
