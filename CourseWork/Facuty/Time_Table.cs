using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public struct Lection_Info
    {
        public int lesson_num;
        public Group group;
        public DayOfWeek day;
        public string subject;
        public Lection_Info(string subject, DayOfWeek day, int lesson_num, Group group)
        {
            this.lesson_num = lesson_num;
            this.group = group;
            this.day = day;
            this.subject = subject;
        }
    }
    


}
