using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface ISpecialty
    {
        void ReplaceGroup(Group group1, Group group2);
        void AddTeacher(string teachername, int subjname, int Status);
        Group GetGroup(int num);
        Group AddGroup(string Groupname);
        List<Group> GetAllGroups();
        List<Teacher> GetTeachers();
        List<Subject> GetSubjects();
        Subject GetSubject(int i);
    }
}
