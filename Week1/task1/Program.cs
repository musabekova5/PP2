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
            int n = int.Parse(Console.ReadLine());//ввод переменной, сколько чисел будет в массиве
            int i, j, p, cnt=0;// переменные интежер 
            int[] arr = new int[n];//массив 

            
            string[] nums = Console.ReadLine().Split(new char[] { ',', ';', '#', ' ' });//чтоб учитывать символы как запятая 

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(nums[i]);//замена на интежер от стринга
            }

       

            for (i = 0; i < arr.Length; i++)
            {
                j = 2;
                p = 1;
                while (j < arr[i])//начинается условие проверки на простое число 
                {

                    if (arr[i] % j == 0)
                    {
                        p = 0;
                        break;
                        
                    }
                    j++;
                }
                if (arr[i] == 1)//пропускаем 1 так как не является простым числом 
                {
                    continue;
                }
                    if (p == 1)
                   {
                     cnt++;    
                      Console.Write(arr[i] + " ");//выводим просытые числа на экран 
                }
                   
            }


        }
    }
    
}
