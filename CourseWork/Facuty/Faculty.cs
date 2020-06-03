using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Faculty
    {
        public delegate void FacultyEvent(object sender, string e);
        public event FacultyEvent Remove_specialty;
        public event FacultyEvent Remove_audience;

        private List<Specialty> specialties = new List<Specialty>();
        private List<Audience> audiences = new List<Audience>();
        public string Name { get; }
        public Faculty(string Name)
        {
            this.Name = Name;
        }
        public Faculty(string Name,List<Specialty> specialties, List<Audience> audiences)
        {
            if (specialties.Count > 10)
                throw new FacultyException(message: $" The number of specialties exceeds the plan for this faculty{ Name}");

            this.specialties = specialties;
            this.audiences = audiences;
            this.Name = Name;
        }
        public Specialty AddSpecialty(string Name, List<Subject> Subjects, List<Teacher> Teachers)
        {
            foreach (var s in specialties)
                if (s.Name == Name)
                    throw new FacultyException(message: "Specilty with such name already exists!");
            Specialty specilty = new Specialty(Name, Subjects, Teachers, audiences);
            specialties.Add(specilty);
            return specilty;
        }
        public void RemoveSpecialty(string Name)
        {
            bool flag = true;
            foreach (var s in specialties)
            {
                if (s.Name == Name)
                {
                    flag = false; specialties.Remove(s);
                    Remove_specialty?.Invoke(this, s.Name);
                    break;
                }
            }
            if(flag)
                throw new FacultyException(message: "There is not such specilty on this faculty");
        }
        public void AddAudience(string Name)
        {
            foreach (var a in audiences)
            {
                if (a.Number == Name)
                {
                    throw new FacultyException(message: "There is audience with this name already");
                }
            }    
            audiences.Add(new Audience(Name));
        }
        public void RemoveAudience(string Number)
        {
            foreach (var a in audiences)
            {
                if (a.Number == Number)
                {
                    audiences.Remove(a);
                    Remove_audience?.Invoke(this, a.Number);
                    break;
                }
            }
        }
        public List<Audience> GetAudiences() { return audiences; }
    }
}

















