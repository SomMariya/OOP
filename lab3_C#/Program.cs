using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp3
{
    class program
    {
        static void Main(string[] args)
        {
 
            Student students = new Student(3);
            students[1] = "Jane";
            students[2] = "Tom";
            students.output();
            Console.WriteLine(students.Num);

        }
    }

    













}