using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp3
{
    class program
    {
        static void Main(string[] args)
        {
            Student table = new Student();
            table.Name= "Alex";
            Console.WriteLine(table[1]);
            table.Name = "Lera";
            table.n = 1;
            Console.WriteLine(table[2]);
            table.Name = "Sam";
            table.n = 0;
            Console.WriteLine(table[2]);

            Console.WriteLine(table.Num);
        }
    }

    class Student
    {
        private string name;
        private string surname;
        private int col = 0;
        public int n = 0;
        private string[] students = new string[30];
        public string Surname 
        { set
            { surname = value; }
        }
        public string Name
        { set
            { name = value; }
        }

        public string AddStudent()
        {
            for (int i = 0; i < students.GetLength(0); i++)
            {
                if (students[i] == null)
                {
                    students[i] = (i+1) + ". " + surname + " " + name;
                    return students[i];
                }
            }
            return null;
        }

        public void output()
        {
            for (int i = 0; i < students.GetLength(0); i++)
            {
                Console.Write(students[i]);
                Console.WriteLine();
            }
        }


        public string this [int index]
        {
            get
            {
                if(n==1)
                { 
                     Console.WriteLine(AddStudent());
                }
                if(n==0)
                {
                    index--;
                    students[index] = (index + 1) + ". " + name + " " + surname;
                   
                }
                return (students[index]);
            }  
        }

        public int Num
        {
            get
            {   
                for(int i=0;i<students.GetLength(0);i++)
                {
                    if(students[i]!=null)
                    {col++;}
                }
                return col;
            }
        }
    }













}