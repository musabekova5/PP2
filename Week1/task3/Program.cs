using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            string[] nums = Console.ReadLine().Split(new char[] { ',', ';', '#', ' ' });

            
            for (int i = 0; i < nums.Length; ++i)
            {
                Console.Write(nums[i] + " " + nums[i] + " ");
            }
        }
    }
}
