using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Student
    {
        private int col = 0;
        private string[] students;
        public Student(int len)
        {
            students = new string[len];
        }

        public string this[int index]
        {
            set
            {
                if ((index >= 0) && (index < students.Length))
                {
                    students[index] = value;
                }
            }
        }
        
        public int Num
        {
            get
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] != null)
                    { col++; }
                }
                return col;
            }
        }

        public void output()
        {
            for (int i = 0; i < students.GetLength(0); i++)
            {
                if (students[i] != null)
                {
                    Console.Write(students[i]);
                    Console.WriteLine();
                }
            }
        }
    }
}







/*
public string AddStudent()
{
    for (int i = 0; i < students.GetLength(0); i++)
    {
        if (students[i] == null)
        {
            students[i] = (i + 1) + ". " + surname + " " + name + " " + patr;
            return students[i];
        }
    }
    return null;
}*/