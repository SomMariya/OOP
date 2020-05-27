using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class My_List
    {
        public delegate void Delegate2(object sender, int num);
        public event Delegate2 Cleared = null;
        
        private string[] list;

        public My_List(){}
        public My_List(string[] list)
        {
            this.list = list;
        }
        public string this[int index]
        {
            set
            {
                if (index >= 0)
                {
                    if (index >= list.Length)
                    {
                        int n = index + 1;
                        string[] newlist = new string[n];
                        for (int i = 0; i < list.Length; i++)
                        {
                            newlist[i] = list[i];
                        }
                        list = newlist;
                    }
                    list[index] = value;
                }
                else
                    throw new IndexOutOfRangeException(message: "Index out of range");
            }
        }
        public void Delete_Component(int index)
        {
            if (list[index] == null)
                throw new NullReferenceException(message: "The list is already empty");
            if (index >= list.Length)
                throw new IndexOutOfRangeException(message: "Index out of range");

            list[index] = null;

            if (Check() && Cleared != null)  
                Cleared(this, list.Length);
        }
        private bool Check()
        {
            int j = list.Length;

            for (int i = 0; i < list.Length; i++)
                if (list[i] == null)
                    j--;
            
            if (j == 0)
                return true;
            else
                return false;
        }
        public static void Handler(object owner, int num)
        {
            Console.WriteLine($"{owner}: the List is cleared ({num} elements)");
        }
    }
}
