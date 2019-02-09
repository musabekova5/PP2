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
            int n = int.Parse(Console.ReadLine());
            string[ , ] a = new string[n, n];

           //string[] nums = Console.ReadLine().Split(new char[] { ' ', '*', '[', ']', ','});
            for (int i = 0; i<n; ++i)
            {
                for(int j=0; j<i+1; ++j)
                {
                    a[i, j] = "[*]";
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
