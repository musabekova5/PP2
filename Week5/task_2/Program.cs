using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static task_2.Mark;

namespace task_2
{
    public class Mark
    {
        public int p;
        public Mark()
        {

        }
        public Mark(int p)
        {
            this.p = p;
        }
        public string GettLetter()
        {
            if (p >= 95)
                return "A";
            if (p >= 90 && p < 95)
                return "-A";
            if (p >= 85 && p < 90)
                return "B+";
            if (p >= 80 && p < 85)
                return "B";
            if (p >= 75 && p < 80)
                return "B-";
            if (p >= 70 && p < 75)
                return "C+";
            if (p >= 65 && p < 70)
                return "C";
            if (p >= 60 && p < 65)
                return "C-";
            if (p >= 55 && p < 60)
                return "D+";
            if (p >= 50 && p < 55)
                return "D";
            return "F";
        }
        public override string ToString()
        {
            return GettLetter();
        }
        public class Marklist
        {
            public List<Mark> Marks;
            public Marklist()
            {
                Marks = new List<Mark>();
            }
            public void Save(Marklist M)
            {
                FileStream fs = new FileStream("marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                XmlSerializer xs = new XmlSerializer(typeof(Marklist));
                xs.Serialize(fs, M);
                fs.Close();
            }
            public void Show()
            {
                FileStream fs = new FileStream("marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                XmlSerializer xs = new XmlSerializer(typeof(Marklist));
                Marklist M = xs.Deserialize(fs) as Marklist;
                for(int i=0; i < M.Marks.Count; i++)
                {
                    Console.WriteLine(M.Marks[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mark m1 = new Mark(55);
            Mark m2 = new Mark(96);
            Mark m3 = new Mark(70);
            Marklist M = new Marklist();
            M.Marks.Add(m1);
            M.Marks.Add(m2);
            M.Marks.Add(m3);
            M.Save(M);
            M.Show();
            //Console.ReadKey();
        }
    }
}
