using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i, j, p, cnt=0;
            int[] arr = new int[n];

            //Console.Write("Enter array elements :");
            string[] nums = Console.ReadLine().Split(new char[] { ',', ';', '#', ' ' });

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(nums[i]);
            }

           // Console.Write("All Prime List is :");

            for (i = 0; i < arr.Length; i++)
            {
                j = 2;
                p = 1;
                while (j < arr[i])
                {

                    if (arr[i] % j == 0)
                    {
                        p = 0;
                        break;
                        
                    }
                    j++;
                }
                if (arr[i] == 1)
                {
                    continue;
                }
                    if (p == 1)
                   {
                     cnt++;    
                      Console.Write(arr[i] + " ");
                }
                   
            }


        }
    }
    
}
