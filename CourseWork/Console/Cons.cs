using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace course_2
{
    static class Cons
    {
        static public Group ChooseGroup(Specialty sp, string str)
        {
            if (str == sp.GetGroup(0).Groupname) return sp.GetGroup(0);
            if (str == sp.GetGroup(1).Groupname) return sp.GetGroup(1);
            else return sp.GetGroup(2);
        }
        static public void OutputStudents(Group group)
        {
            if(group.GetStudents().Count == 0)
                Console.WriteLine("No students yet!");
            foreach (var s in group.GetStudents())
                Console.WriteLine(s.Data.Name + " " + s.Data.Surname);
        }
        static public void OutputSchaduleGroup(Group gr)
        {
            for (int i = 0; i < gr.Schedule.GetLength(0); i++)
            {
                for (int j = 0; j < gr.Schedule.GetLength(1); j++)
                {
                    if (j == 0) Console.Write("{0, -3}", gr.Schedule[i, j]);
                    else
                        Console.Write("{0, -20}|", gr.Schedule[i, j]);
                }
                Console.Write("\n");
            }
        }
        static public void Switch1Case1(Specialty specialty1,Faculty fac)
        {
            Console.WriteLine("What exactly are you interested in?\n1)Schadule\t\t2)Show all groups\n3)Replace group\t\t4)Remove specilty");
            bool flag = true;
            while (flag)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        SpecialtySchedule schadule = new SpecialtySchedule(specialty1);
                        schadule.schedule_event += Program.SchaduleHandler;
                        schadule.SpecialtyScheduleLections(); Console.WriteLine("For which group?");
                        OutputSchaduleGroup(ChooseGroup(specialty1, Console.ReadLine()));
                        flag = false; break;
                    case "2":
                        foreach (var group in specialty1.GetAllGroups())
                            Console.WriteLine(group.Groupname);
                        flag = false; break;
                    case "3":
                        Console.WriteLine("Enter group, you want to replace and new on:");
                        specialty1.ReplaceGroup(ChooseGroup(specialty1, Console.ReadLine()), new Group(Console.ReadLine()));
                        flag = false; break;
                    case "4":
                        Console.WriteLine("Enter name of specialty, you`d like to remove");
                        fac.Remove_specialty += Program.FacultyHandler1;
                        fac.RemoveSpecialty(Console.ReadLine());
                        flag = false; break;
                    default:
                        Console.WriteLine("This variant isn't right. Enter another one");
                        break;
                }
            }
        }
        static public void Switch1Case2(Specialty specialty1)
        {
            Console.WriteLine("Enter group name"); Group gr = ChooseGroup(specialty1, Console.ReadLine());
            Console.WriteLine("What exactly are you interested in?\n1) Show students\t\t2) Add students\n3) Sort students\t\t4) Remove student");
            bool flag = true;
            while (flag)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        OutputStudents(gr);
                        flag = false; break;
                    case "2":
                        Console.WriteLine("Enter how many you want to add(and enter them names):");
                        int num = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < num; i++)
                        {
                            gr.AddStudent(Console.ReadLine(), Console.ReadLine());
                        }
                        flag = false; break;
                    case "3":
                        gr.SortStudents();
                        OutputStudents(gr);
                        flag = false; break;
                    case "4":
                        Console.WriteLine("Enter name and surname of student, you`d like to remove");
                        gr.RemoveStudent(Console.ReadLine(),Console.ReadLine());
                        gr.Remove_student += Program.GroupHandler;
                        flag = false; break;
                    default:
                        Console.WriteLine("This variant isn't right. Enter another one");
                        break;
                }
            }
        }
        static public void Switch1Case3(Faculty fac)
        {
            Console.WriteLine("\n1) Do you want to add audiences?\n2) Print the list of all audiences\n3) Remove audience");
            bool flag1 = true;
            while (flag1)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Enter how many you want to add(and enter them names):");
                        int j = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < j; i++)
                            fac.AddAudience(Console.ReadLine());
                        flag1 = false; break;
                    case "2":
                        foreach (var aud in fac.GetAudiences())
                            Console.WriteLine(aud.Number);
                        flag1 = false; break;
                    case "3":
                        Console.WriteLine("Enter number of audience:");
                        fac.Remove_audience += Program.FacultyHandler2;
                        fac.RemoveAudience(Console.ReadLine());
                        flag1 = false; break;
                    default:
                        Console.WriteLine("This variant isn't right. Enter another one");
                        break;
                }
            }
        }
        static public void Switch1Case4(Specialty specialty1)
        {
            Console.WriteLine("1) Do you want to add teachers on your specialty?\t2)To print the list of all teachers\t3) To replace teacher?");
            bool flag = true;
            while (flag)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("How many you want to add?");int i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Write name, subject(0 - Math, 1 - Ukr, 2 - Prog, 3 - Eng, 4 - Hist, 5 - TheofAlg)\nand status(0 - teacher, 1 -  Senior_Lecturer, 2 - Professor");
                        for (int j = 0; j < i; j++)
                        {
                            specialty1.AddTeacher(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                        }
                        flag = false; break;
                    case "2":
                        foreach (var t in specialty1.GetTeachers())
                            Console.WriteLine(t.Name + " " + (t.SubjectName)+ " "+ t.GetStatus());
                        flag = false; break;
                    case "3":
                        Console.WriteLine("Enter name of teacher, you want to replace\nand then enter info of second teacher (name, subject, status)");
                        string str = Console.ReadLine();
                        string str1 = Console.ReadLine();
                        int n = Convert.ToInt32(Console.ReadLine());
                        int s = Convert.ToInt32(Console.ReadLine());
                        specialty1.ReplaceTeacher(str, new Teacher(str1, new Subject(n, true), s));
                        flag = false; break;
                    default:
                        Console.WriteLine("This variant isn't right. Enter another one");
                        break;
                }
            }


        }
    }
}




        
