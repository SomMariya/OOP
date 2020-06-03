using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum SubjType
    {
        Math,
        Ukr,
        Prog,
        Eng,
        Hist,
        TheofAlg 
    }
    public class Subject
    {
        public string Name { get; }
        internal int LectionNum { get; }
        internal int PracticeNum { get; }

        internal bool written = false;
        public Subject(int Name, bool MainSubject)
        {
            this.Name = Enum.GetName(typeof(SubjType), Name);
            if(MainSubject)
                LectionNum = 2;
            else
                LectionNum = 1;
            PracticeNum = 1;
        }
    }
}
