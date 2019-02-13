using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
       

        static void Main(string[] args)
        {
           
           
            string path = @"C:\Users\Lenovo\Desktop\stayed";
            string fn= "test.txt";//название файла
           string pathy = Path.Combine(path, fn);// путь где будет изначальный файл
             
    
            string path1 = @"C:\Users\Lenovo\Desktop\moving";
            string pathy1 = Path.Combine(path1, fn);// путь куда он скопируется

            using (FileStream fs = new FileStream(pathy, FileMode.CreateNew, FileAccess.Write)) // создаю документ
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write("rdtfyguhij");
                }
            }

            System.IO.File.Copy(pathy, pathy1, true); // копирую документ в path1
            System.IO.File.Delete(pathy); // удаляю изначальный документ

        }

           
          
           
        }


       
        }
    

