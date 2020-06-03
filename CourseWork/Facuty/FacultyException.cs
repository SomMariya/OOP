using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FacultyException : ArgumentException
    {
        public int  value{ get; }
        public FacultyException(string message): base(message)  { }
        public FacultyException(string message, int value): base(message)
        {
            this.value = value;
        }
    }
}
