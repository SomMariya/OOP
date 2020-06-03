using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Audience
    {
        public string Number { get; }
        internal bool Occupied;
        public Audience(string number)
        {
            Number = number;
        }
    }
}
