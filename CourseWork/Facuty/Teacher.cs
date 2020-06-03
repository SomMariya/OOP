using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassLibrary1
{
    public enum Status:int
    {
        Teacher, 
        Senior_Lecturer, 
        Professor
    }
    public class Teacher
    {
        public string Name { get; }
        public string SubjectName { get; }
        internal int LectionNum { get; }
        internal int PrakticeNum { get; }

        private Status Status;
        public Teacher(string Name, Subject Subject, int Status)
        {
            this.Name = Name;
            this.Status = (Status)Status;
            SubjectName = Subject.Name;

            if (this.Status == 0)
            {
                LectionNum = 3;
                PrakticeNum = 4;
            }  
            if (this.Status == (Status)1)
            {
                LectionNum = 2; 
                PrakticeNum = 3;
            }  
            else
            {
                LectionNum = 2;
                PrakticeNum = 3;
            }
        }
        internal void RaiseStatus(Status Status)
        {
            Status++;
            this.Status = Status;
        }
        public Status GetStatus()
        {
            return Status;
        }

    }
}



















 /* public void Schedule(Specialty specialty)
        {
            TeacherSchedule.Add(Name + "-------" + Lesson + "\n");
            TeacherSchedule.Add("Monday");
            if (type1)
                TeacherSchedule.Add(" 1. practice " + group1.Groupname);
            else
                TeacherSchedule.Add(" 1. lecture " + group1.Groupname);
            if (type2)
                TeacherSchedule.Add(" 2. practice " + group2.Groupname);
            else
                TeacherSchedule.Add(" 2. lecture " + group2.Groupname);
            if (type3)
                TeacherSchedule.Add(" 3. practice " + group3.Groupname);
            else
                TeacherSchedule.Add(" 3. lecture " + group3.Groupname);
            foreach (var s in TeacherSchedule)
                Console.WriteLine(s);
        }*/