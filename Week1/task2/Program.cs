﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_2.Properties;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Samal", "18BD117379", 0); //задаем параметры
            st.PrintInfo();
            Student s = new Student("Samal", "18BD117379");//параметры без года обучения
            s.year = st.year + 1;//добавление года обучения 
            s.PrintInfo();
        }
    }
}
