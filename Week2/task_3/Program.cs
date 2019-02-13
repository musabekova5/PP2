using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void PrintInfo(FileSystemInfo sm, int a) // создаю функцию
        {
            string s = new string(' ', a);
            Console.WriteLine(s + sm.Name);

            if (sm.GetType() == typeof(DirectoryInfo)) // если файл является папкой
            {
                FileSystemInfo[] arr = ((DirectoryInfo)sm).GetFileSystemInfos(); // иду дальше
                for (int i = 0; i < arr.Length; ++i)
                {
                    PrintInfo(arr[i], a + 3); // вывожу и делаю отступ
                }
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Lenovo\Desktop\PP2"); // указываю необходимую папку
            PrintInfo(d, 0); // вызываю функцию 
        }
    }
}
