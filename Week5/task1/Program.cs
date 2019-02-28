using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace task1
{
    public class complex
    {
        public int a;//a real number
        public int b;//imaginary 
        public complex()
        {

        }
        public void PrintInfo()
        {
            Console.WriteLine(string.Format("{0}+{1}i", a, b));
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            F1();
        }
        private static void F2()
        {
            FileStream fs = new FileStream("complex.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(complex));
            complex c = xs.Deserialize(fs) as complex;
            c.PrintInfo();
            fs.Close();
        }
        private static void F1()
        {
            complex c = new complex();
            c.a = 5;
            c.b = 6;
            c.PrintInfo();

            FileStream fs = new FileStream("complex.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(complex));

            xs.Serialize(fs, c);
            fs.Close();
        }
    }
}
