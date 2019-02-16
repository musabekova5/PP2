using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//вводим кол в массиве
            string[ , ] a = new string[n, n];// двойной массив 

           //string[] nums = Console.ReadLine().Split(new char[] { ' ', '*', '[', ']', ','});
            for (int i = 0; i<n; ++i)//по строкам
            {
                for(int j=0; j<i+1; ++j)//столбики в строке 
                {
                    a[i, j] = "[*]";//даем значение звездочки в квадрате 
                    Console.Write(a[i, j]);// вывод
                }
                Console.WriteLine();
            }
        }
    }
}
