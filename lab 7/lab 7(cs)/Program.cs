using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
			MyList list = new MyList();

			Node Node1 = new Node();
			Node Node2 = new Node();
			Node Node3 = new Node();

			Node1.value = '#';
			Node2.value = '*';
			Node3.value = '*';

			list.AddLast(Node1);
			list.AddLast(Node2);
			list.AddLast(Node3);

			list.FindSymbol('*');
			list.DeleteAfterHash();
			list.FindSymbol('*');

		}
	}
}
