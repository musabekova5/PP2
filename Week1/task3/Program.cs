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
            int n = int.Parse(Console.ReadLine());//ввод количества чисел в массиве
            int[] a = new int[n];//массив

            string[] nums = Console.ReadLine().Split(new char[] { ',', ';', '#', ' ' });//чтоб символы принимать

            
            for (int i = 0; i < nums.Length; ++i)
            {
                Console.Write(nums[i] + " " + nums[i] + " ");//дупликаты делает и выводит
            }
        }
    }
}
