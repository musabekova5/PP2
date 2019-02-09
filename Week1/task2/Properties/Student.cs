using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2.Properties
{
    class Student
    {
        string name = null;
        public string Name
        {
            get //accessor
            {
                return name;
            }
            set //mutator
            {
                name = value;
            }
        }
        public string ID = null;
        public int year;

        #region constructor
        public Student()
        {

        }
        public Student(string name, string ID, int year)
        {
            Name = name;
            this.ID = ID;
            this.year = year;
        }
        public Student(string name, string a)
        {
            Name = name;
            ID = a;

        }
        #endregion
        public void PrintInfo()
        {
            Console.WriteLine(Name + " " + ID + " " + year);
        }
    }
}
