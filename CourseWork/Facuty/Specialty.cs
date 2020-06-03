using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{    
    public class Specialty : ISpecialty
    {
        public delegate void ScpecialtyEvent(object sender, string e);
        public event ScpecialtyEvent specialty_event;
        public string Name { get; internal set; }

        private List<Group> Groups = new List<Group>();
        private List<Teacher> Teachers = new List<Teacher>();
        private List<Subject> Subjects = new List<Subject>();
        internal List<Audience> audiences = new List<Audience>();

        public Specialty(string Name, List<Subject> Subjects, List<Teacher> Teachers, List<Audience> audiences)
        {
            if (Subjects.Count > 6)
                throw new FacultyException(message: $"The number of subjects exceeds the plan for this specialty{Name}");

            if (Check(Teachers, Subjects) != null)
                throw new FacultyException(message: $"There is not teacher of {Check(Teachers, Subjects)}");

            this.Name = Name; this.Subjects = Subjects; this.Teachers = Teachers; this.audiences = audiences;
        }

        private string Check(List<Teacher> Teachers, List<Subject> Subjects)
        {
            bool flag;
            foreach (var subject in Subjects)
            {
                flag = false;
                foreach (var teacher in Teachers)
                {
                    if (subject.Name == teacher.SubjectName)
                    {
                        flag = true; break;
                    }
                }
                if (!flag)
                {
                    return subject.Name;
                } 
            }
            return null;
        }
        public Group GetGroup(int num)
        {
            if (num < 0 && num > 3)
                throw new ArgumentException(message: "Incorrect number of group");
            return Groups[num];
        }

        public void ReplaceGroup(Group group1, Group group2)
        {
            for(int i = 0; i < Groups.Count; i++)
            {
                if (Groups[i] == group1)
                {
                    Groups[i] = group2;
                }
            }
        }
        public void ReplaceTeacher(string name, Teacher t2)
        {
            for (int i = 0; i < Teachers.Count; i++)
            {
                if (Teachers[i].Name == name)
                {
                    Teachers[i] = t2;
                    if(Check(Teachers, Subjects) != null)
                        throw new FacultyException(message: $"There is not teacher of{Check(Teachers, Subjects)}");

                }
            }
            specialty_event?.Invoke(this, t2.Name);
        }
        public void AddTeacher(string teachername, int subjname, int Status)
        {
            Teacher teacher = new Teacher(teachername, new Subject(subjname, false), Status);
            int count = 0;
            foreach (var teach in Teachers)
            {
                if (teach.SubjectName == teacher.SubjectName)
                {
                    count++;
                    if (count == 3)
                    {
                        throw new FacultyException(message: $"Too many teachers of this subject:{teacher.SubjectName}");
                    }
                }
            }
            Teachers.Add(teacher);
            specialty_event?.Invoke(this, teacher.Name);
        }
        public Group AddGroup(string Groupname)
        {
            if(Groups.Count >=3)
                throw new FacultyException(message: "Number of groups is limited (max = 3)");
            foreach(var group in Groups)
            {
                if (group.Groupname == Groupname)
                    throw new ArgumentException(message:"Group with this name already exists");
            }
            Group g = new Group(Groupname);
            Groups.Add(g);

            return g;
        }
        public List<Group> GetAllGroups() { return Groups; }
        public List<Teacher> GetTeachers() { return Teachers; }
        public List<Subject> GetSubjects() { return Subjects; }
        public Subject GetSubject(int i) { return Subjects[i]; }
    }
}
