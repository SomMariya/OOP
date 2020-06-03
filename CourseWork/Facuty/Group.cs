using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Group
    {
        public delegate void GroupEvent(object sender, string e);
        public event GroupEvent Remove_student;

        private List<Student> students = new List<Student>();
        public string Groupname { get; }
        public string[,] Schedule;
        public Group(string Groupname) 
        {
            this.Groupname = Groupname;
        }
        public Group(string Groupname, List<Student> students)
        {
            if (students.Count > 30)
                throw new FacultyException(message: $"Too many students in a group{Groupname}");
            this.students = students;
            this.Groupname = Groupname;
        }
        public void AddStudent(string name, string surname)
        {
            Student s = new Student(new Info(name, surname));
            students.Add(s);
        }
        public int StudentsNum()
        {
            return students.Count;
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        public void RemoveStudent(string name, string surname)
        {
            bool flag = true;
            foreach (var s in students)
            {
                if (s.Data.Name == name && s.Data.Surname == surname)
                {
                    students.Remove(s);
                    Remove_student?.Invoke(this, $"{s.Data.Name} {s.Data.Surname }");
                    flag = false;
                    break;
                }
            }
            if (flag)
                throw new ArgumentException(message: "There`s not such student in this group");

        }
        public void SortStudents()
        {
            var result = students.OrderBy(student => student.Data.Surname).ThenBy(student => student.Data.Name);
        }
    }
}
