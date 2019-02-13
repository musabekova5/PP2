using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        private static string reverse(string p)
        {
           
            char[] s = p.ToCharArray();//перезагрузить в массив символов
            Array.Reverse(s);
            return new string(s);//перезагружает его в строку
        }
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader(@"C:/Users/Lenovo/Desktop/read.txt");//читает файл
            string p = r.ReadLine();//читает содиржимое, то есть все символы
            if (p.Equals(reverse(p)))//если р равно своему обратному
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

    }
}
