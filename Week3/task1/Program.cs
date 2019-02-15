using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FarManager
{

    class Layer
    {
        public int ix = 0; //индекс
        public FileSystemInfo[] content;
        public Layer(FileSystemInfo[] content)
        {
            this.content = content;
        }
        public void Color(bool mode)//задаем переменную булеан чтобы окошко создать 
        {
            if (mode == true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                for (int i = 0; i < content.Length; i++)//проходимся фориком до конца надписи(содиржимое)
                {
                    if (i == ix)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    if (content[i].GetType() == typeof(DirectoryInfo))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;//если надпись приняла тип папки то окрашиваем в желтую 
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;//если это не папка то белая 
                    }
                    Console.WriteLine(content[i].Name);
                }
            }
            else
            {
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\Lenovo\Documents\Физика рус");//прописываем путь 
                Stack<Layer> history = new Stack<Layer>();//создаем стэк 
                history.Push(new Layer(directoryInfo.GetFileSystemInfos()));//закидываем в стэк
                bool escape = false;
                bool mode = true;
                while (!escape)
                {
                    history.Peek().Color(mode);
                    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();//читает нажатую клавишу консоли
                    switch (consoleKeyInfo.Key)//оператор выбора по клавшие консоли
                    {
                        case ConsoleKey.Backspace:
                            mode = true;
                            history.Pop();
                            break;
                        case ConsoleKey.Enter:
                            int x = history.Peek().ix;
                            FileSystemInfo fileSystemInfo = history.Peek().content[x];//проверяет до конца ли прочитали содиржимое 
                            if (fileSystemInfo.GetType() == typeof(DirectoryInfo))
                            {
                                FileSystemInfo[] content = (fileSystemInfo as DirectoryInfo).GetFileSystemInfos();
                                history.Push(new Layer(content));//если там есть содержание то в стэк кидается и открывается
                            }
                            else
                            {
                                mode = false;
                                FileStream fs = new FileStream(fileSystemInfo.FullName, FileMode.Open, FileAccess.Read);
                                StreamReader sr = new StreamReader(fs);//создаем переменную которая будет читать из переменной фс в опрделенной кодировке 
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                Console.WriteLine(sr.ReadToEnd());
                                fs.Close();
                                sr.Close();
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            if (history.Peek().ix - 1 < 0)
                            {
                                history.Peek().ix = history.Peek().content.Length - 1;//если индекс до конца прочел то он в начало идет 
                            }
                            else
                                history.Peek().ix--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (history.Peek().ix + 1 >= history.Peek().content.Length)
                            {
                                history.Peek().ix = 0;//если если больше или равно строке то присваевыем ноль 
                            }
                            else
                                history.Peek().ix++;//в обратном случае индекс умножается 
                            break;
                        case ConsoleKey.Delete:
                            int x2 = history.Peek().ix;//создаем переменную для удаления 
                            FileSystemInfo fileSystemInfo2 = history.Peek().content[x2];
                            history.Peek().ix--;
                            if (fileSystemInfo2.GetType() == typeof(DirectoryInfo))
                            {
                                DirectoryInfo dirInfo = fileSystemInfo2 as DirectoryInfo;
                                Directory.Delete(fileSystemInfo2.FullName);//удаляем папку если строка выбрана 
                                history.Peek().content = dirInfo.Parent.GetFileSystemInfos();
                            }
                            else
                            {
                                FileInfo fileInfo = fileSystemInfo2 as FileInfo;
                                File.Delete(fileSystemInfo2.FullName);
                                history.Peek().content = fileInfo.Directory.GetFileSystemInfos();
                            }
                            break;
                        case ConsoleKey.F2://клавиша для переименования 

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            string name = Console.ReadLine();
                            int x3 = history.Peek().ix;//новая переменная для переименования 
                            FileSystemInfo fileSystemInfo3 = history.Peek().content[x3];
                            if (fileSystemInfo3.GetType() == typeof(DirectoryInfo))
                            {
                                DirectoryInfo dirInfo = fileSystemInfo3 as DirectoryInfo;
                                Directory.Move(fileSystemInfo3.FullName, dirInfo.Parent + "/" + name);
                                history.Peek().content = dirInfo.Parent.GetFileSystemInfos();
                            }
                            else
                            {
                                FileInfo fileInfo = fileSystemInfo3 as FileInfo;
                                File.Move(fileSystemInfo3.FullName, fileInfo.Directory + "/" + name);
                                history.Peek().content = fileInfo.Directory.GetFileSystemInfos();
                            }
                            break;
                        case ConsoleKey.Escape:
                            escape = true;
                            break;
                    }
                }
            }
        }
    }
}