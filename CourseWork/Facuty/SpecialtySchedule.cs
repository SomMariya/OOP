using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Satturday,
        Sunday
    }
    public class SpecialtySchedule
    {
        public delegate void ScheduleEvent(object sender, string e);
        public event ScheduleEvent schedule_event = null;

        private string[,] Schedule = new string[5, 6];
        private Specialty specialty;
        
        public SpecialtySchedule(Specialty specialty)
        {
            this.specialty = specialty;

            int j = 0;
            for (int i = 1; i < 6; i++)
            {
                Schedule[0, i] = Enum.GetName(typeof(WeekDays), j); j++;
            }
            for (int i = 1; i < 5; i++)
            {
                Schedule[i, 0] = ($"{i}");
            }
        }

        public void SpecialtyScheduleLections()
        {
            int lectionnum;
            foreach (var subject in specialty.GetSubjects())
            {
                lectionnum = subject.LectionNum;
                while (lectionnum > 0)
                {
                    foreach (var teacher in specialty.GetTeachers())
                    {
                        if (subject.Name == teacher.SubjectName)
                        {
                            if (teacher.LectionNum > 0)
                            {
                                int n, m;
                                (n, m) = Check();
                                if ((n, m) != (-1, -1))
                                {
                                    Schedule[n, m] = ($"{subject.Name}(lec,{specialty.audiences[m].Number}){teacher.Name}");
                                    lectionnum--; break;
                                }
                            }
                        }
                    }
                }
            }
            Group1Schedule(); Group2Schedule(); Group3Schedule();
            schedule_event?.Invoke(this, specialty.Name);
        }
        private void Group1Schedule()
        {
            int practicenum; string[,] Schedule1 = new string[5, 6];
            
            Array.Copy(Schedule, Schedule1, Schedule.Length);

            foreach (var subject in specialty.GetSubjects())
            {
                practicenum = subject.PracticeNum;
                while (practicenum > 0)
                {
                    foreach (var teacher in specialty.GetTeachers())
                    {
                        if (subject.Name == teacher.SubjectName)
                        {
                            if (teacher.PrakticeNum > 0)
                            {
                                foreach (var aud in specialty.audiences)
                                {
                                    if (!aud.Occupied)
                                    {
                                        int n, m; (n, m) = Check2(Schedule1);
                                        if ((n, m) != (-1, -1))
                                        {
                                            Schedule1[n, m] = ($"{subject.Name}(lab,{aud.Number}){teacher.Name}");
                                            aud.Occupied = true; practicenum--; break;
                                        }
                                        else
                                            throw new FormatException(message: "Something went wrong");
                                    }
                                }
                            }
                        }
                        if (practicenum == 0) break;
                    }
                }
            }
            foreach (var aud in specialty.audiences) aud.Occupied = false;

            for (int i = 1; i < Schedule1.GetLength(0); i++)
                for (int j = 1; j < Schedule1.GetLength(1); j++)
                    if (Schedule1[i, j] == null) Schedule1[i, j] = "--";

            specialty.GetGroup(0).Schedule = Schedule1;
        }
        private void Group2Schedule()
        {
            int practicenum; string[,] Schedule2 = new string[5, 6];
            Array.Copy(Schedule, Schedule2, Schedule.Length);

            for (int i = specialty.GetSubjects().Count - 1; i >= 0; i--)
            {
                practicenum = specialty.GetSubject(i).PracticeNum;
                while (practicenum > 0)
                {
                    foreach (var teacher in specialty.GetTeachers())
                    {
                        if (specialty.GetSubject(i).Name == teacher.SubjectName)
                        {
                            if (teacher.PrakticeNum > 0)
                            {
                                foreach (var aud in specialty.audiences)
                                {
                                    if (!aud.Occupied)
                                    {
                                        int n, m; (n, m) = Check2(Schedule2);
                                        if ((n, m) != (-1, -1))
                                        {
                                            Schedule2[n, m] = ($"{specialty.GetSubject(i).Name}(lab,{aud.Number}){teacher.Name}");
                                            aud.Occupied = true; practicenum--; break;
                                        }
                                        else
                                            throw new FormatException(message: "Something went wrong");
                                    }
                                }
                            }
                        }
                        if (practicenum == 0) break;
                    }
                }
            }
            foreach (var aud in specialty.audiences) aud.Occupied = false;

            for (int i = 1; i < Schedule2.GetLength(0); i++)
                for (int j = 1; j < Schedule2.GetLength(1); j++)
                    if (Schedule2[i, j] == null) Schedule2[i, j] = "--";

            specialty.GetGroup(1).Schedule = Schedule2;
        }
        private void Group3Schedule()
        {
            int practicenum; string[,] Schedule3 = new string[5, 6];
            Array.Copy(Schedule, Schedule3, Schedule.Length);

            for (int i = specialty.GetSubjects().Count - 1; i >= 0; i--)
            {
                practicenum = specialty.GetSubject(i).PracticeNum;
                while (practicenum > 0)
                {
                    foreach (var teacher in specialty.GetTeachers())
                    {
                        if (specialty.GetSubject(i).Name == teacher.SubjectName)
                        {
                            if (teacher.PrakticeNum > 0)
                            {
                                foreach (var aud in specialty.audiences)
                                {
                                    if (!aud.Occupied)
                                    {
                                        int n, m; (n, m) = Check3(Schedule3);
                                        if ((n, m) != (-1, -1))
                                        {
                                            Schedule3[n, m] = ($"{specialty.GetSubject(i).Name}(lab,{aud.Number}){teacher.Name}");
                                            aud.Occupied = true; practicenum--; break;

                                        }
                                        else
                                            throw new FormatException(message: "Something went wrong");
                                    }
                                }
                            }
                        }
                        if (practicenum == 0) break;
                    }
                }
            }
            foreach (var aud in specialty.audiences) aud.Occupied = false;

            for (int i = 1; i < Schedule3.GetLength(0); i++)
                for (int j = 1; j < Schedule3.GetLength(1); j++)
                    if (Schedule3[i, j] == null) Schedule3[i, j] = "--";

            specialty.GetGroup(2).Schedule = Schedule3;
        }
        private (int, int) Check3(string[,] Schedule1)
        {
            for (int j = 1; j < Schedule1.GetLength(1); j++)
                if (Schedule1[4, j] == null) return (4, j);
            return (-1, -1);
        }
        private (int, int) Check2(string[,] Schedule1)
        {
            for (int i = 1; i < Schedule1.GetLength(0); i++)
                for (int j = 1; j < Schedule1.GetLength(1); j++)
                    if (Schedule1[i, j] == null) return (i, j);

            return (-1, -1);
        }
        private (int, int) Check()
        {
            for (int i = 1; i < Schedule.GetLength(0); i += 1)
                for (int j = 1; j < Schedule.GetLength(1); j += 2)
                    if (Schedule[i, j] == null) return (i, j);

            return (-1, -1);
        }
    }
}

 