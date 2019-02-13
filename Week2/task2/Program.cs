using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = System.IO.File.ReadAllText(@"C:/Users/Lenovo/Desktop/read.txt");//считывает содиржимое файла
            string[] p = line.Split(new char[] { ' ', ',' });//разделяю элементы строки 
            string prime = "";
            for (int i = 0; i < p.Length; i++)//начинается проверка на простое число 
            {
                int cnt = 0;
                int b = int.Parse(p[i]); //присваиваю элемент
                for (int j = 1; j < b; j++)

                {
                    if (b % j == 0)
                        cnt++;
                }
                if (b == 1)
                {
                    continue;
                }
                if (cnt <= 1)
                {
                    prime += b;
                    prime += " ";
                }
            }
            System.IO.File.WriteAllText(@"C:/Users/Lenovo/Desktop/output.txt", prime);//вывожу ответ на отдельный файл 

        }
    }
}
        
    

