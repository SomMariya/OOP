using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace course_2
{
    class Program
    {
        public static void SchaduleHandler(object sender, string str) { Console.WriteLine($"Schedule is done for {str} specialty"); }
        public static void SpecialtyHandler(object sender, string str) { Console.WriteLine($"Teacher {str} is add"); }
        public static void FacultyHandler1(object sender, string str) { Console.WriteLine($"Specialty {str} was removed"); }
        public static void FacultyHandler2(object sender, string str) { Console.WriteLine($"Audience {str} was removed"); }
        public static void GroupHandler(object sender, string str) { Console.WriteLine($"Student {str} was removed"); }

        /////////////////////////////////////////////////////////////////////////////////////////

        static void Main(string[] args)
        {
            Faculty Fict = new Faculty("FICT");

            Fict.AddAudience("191"); Fict.AddAudience("192"); Fict.AddAudience("193"); Fict.AddAudience("194"); Fict.AddAudience("195"); Fict.AddAudience("196");
            Fict.AddAudience("291"); Fict.AddAudience("292"); Fict.AddAudience("293"); Fict.AddAudience("294"); Fict.AddAudience("295");
            Fict.AddAudience("391"); Fict.AddAudience("392"); Fict.AddAudience("394"); Fict.AddAudience("395"); Fict.AddAudience("396");
             
            List<Teacher> Teachers = new List<Teacher>();
            Teachers.Add(new Teacher("Nick", new Subject(0, true), 1)); Teachers.Add(new Teacher("Sam", new Subject(3, false), 2));
            Teachers.Add(new Teacher("Tom", new Subject(1, false), 2)); Teachers.Add(new Teacher("Sam", new Subject(4, false), 1));
            Teachers.Add(new Teacher("Jake", new Subject(2, true), 0)); Teachers.Add(new Teacher("Jake", new Subject(5, true), 0));

            try
            {
                bool flag1 = true;
                bool flag = true;
                Console.WriteLine(Fict.Name);

                while (flag1)
                {
                    Console.WriteLine("You have to create a specialty, enter num to continue:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter num of subjects, you want to add (max - 5 subjects)");
                    List<Subject> Subjects = new List<Subject>();
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter names of subjects (0 - Math, 1 - Ukr, 2 - Prog, 3 - Eng, 4 - Hist, 5 - TheofAlg)");

                    if (num > 0 && num < 6)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            
                            if (i % 2 == 0)
                            {
                                int n = Convert.ToInt32(Console.ReadLine());
                                foreach (var s in Subjects)
                                    if (s.Name == Enum.GetName(typeof(SubjType), n))
                                        throw new ArgumentException(message: "Subjects should not repeat!");
                                Subjects.Add(new Subject(n, true));
                            }
                            else
                            {
                                int r = Convert.ToInt32(Console.ReadLine());
                                foreach (var s in Subjects)
                                    if (s.Name == Enum.GetName(typeof(SubjType), r))
                                        throw new ArgumentException(message: "Subjects should not repeat!");
                                Subjects.Add(new Subject(r, false));
                            }
                        }
                    }
                    else
                        throw new ArgumentException(message:"Incorrect data!");
                    Specialty specialty1 = Fict.AddSpecialty(name, Subjects, Teachers);
                    specialty1.specialty_event += SpecialtyHandler;
                    Console.WriteLine("You also have to create groups(3), write the names:");
                    specialty1.AddGroup(Console.ReadLine()); specialty1.AddGroup(Console.ReadLine()); specialty1.AddGroup(Console.ReadLine());

                    while (flag)
                    {
                        Console.WriteLine("\nChoose the option:\n1) Specialty\t\t2) Information about groups\n3) Audiences\t\t4) Teachers\n5) Press it to exit");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Cons.Switch1Case1(specialty1,Fict);
                                break;
                            case "2":
                                Cons.Switch1Case2(specialty1);
                                break;
                            case "3":
                                Cons.Switch1Case3(Fict);
                                break;
                            case "4":
                                Cons.Switch1Case4(specialty1);
                                break;
                            case "5":
                                flag = false; break;
                            default:
                                Console.WriteLine("This variant isn't right. Enter another one");
                                break;
                        }
                        Console.WriteLine("\nDo you want to continue?\n1.Yes\t2.No");
                        if (Console.ReadLine() == "2")
                            break;
                    }
                    Console.WriteLine("\nDo you want to create one more specialty?\n1.Yes\t2.No");
                    if (Console.ReadLine() == "2")
                        break;
                }
            }
            catch(FacultyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
