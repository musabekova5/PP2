using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2.Properties
{
    class Student
    {
        string name = null;// пока что даем ноль 
        public string Name
        {
            get //аксессор
            {
                return name;
            }
            set //мутатор
            {
                name = value;
            }
        }
        public string ID = null;
        public int year;

        #region constructor
        public Student()//создаем конструктор по умолчанию сначала 
        {

        }
        public Student(string name, string ID, int year)//конструктор пользовательский
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
        public void PrintInfo()//выводим
        {
            Console.WriteLine(Name + " " + ID + " " + year);
        }
    }
}
