using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main (string[] args)
        {
            //1 Задание

            //StringBuilder a = new StringBuilder("кол около колокола");
            //Console.WriteLine("Дана строка: {0}", a.ToString());
            //char b = 'о';
            //char c = 'а';
            //int k = 0;
            //int k2 = 0;
            //for (int x = 0; x < a.Length; x++)
            //{
            //    if (a[x] == b)
            //    {
            //        k++;
            //    }
            //    if (a[x] == c)
            //    {
            //        k2++;
            //    }
            //}
            //Console.WriteLine("Символ {0} содержиться в ней {1} раз", b, k);
            //Console.WriteLine("Символ {0} содержиться в ней {1} раз", c, k2);
            //Console.ReadKey();

            //2 Задание

            //{


            //    string str = "Вадим Горовой красава : Или не красава";
            //    int index = str.IndexOf(':');
            //    if (index >= 0)
            //        Console.WriteLine(str.Substring(0, index));
            //    else
            //        Console.WriteLine(str);

            //    Console.ReadLine();
            //}


            //3 Задание

            List<string> lst = "Вадим как вы относитесь к  мужчинам?".Split(' ').ToList();
            lst = lst.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(" ", lst));
            Console.ReadLine();

        }

    }  }   
