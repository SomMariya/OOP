using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public struct Info
    {
        public string Name;
        public string Surname;
        public Info(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
    }
    public class Student
    {
        public Info Data;
        public Student(Info Data)
        {
            this.Data = Data;
        }
    }
}