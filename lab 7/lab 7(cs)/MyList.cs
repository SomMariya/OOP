using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    public class Node
    {
        public char value;
        public Node Next;
    }
    class MyList
    {
        private Node Head;
        
        public MyList()
        {
            Head = null;
        }
        private void AddFirst(Node NewNode)
        {
            NewNode.Next = Head;
            Head = NewNode;
        }

        private void AddAfter(Node p, Node NewNode)
        {
            NewNode.Next = p.Next;
            p.Next = NewNode;
        }

        public void AddLast(Node NewNode)
        {
            Node Current = Head;
            if (Head == null)
            {
                AddFirst(NewNode);
                return;
            }
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            AddAfter(Current, NewNode);
        }

        public int FindSymbol(char s)
        {
            int counter = 0;

            Node Current = Head;
            while (Current != null)
            {
                if (Current.value == s)
                    counter++;
                Current = Current.Next;
            }
            return counter;
        }

        private void DeleteNode(Node n)
        {
            Node Current = Head;
            if (Head == n)
            {
                Head = n.Next;
            }
            else
            {
                while (Current != null && Current.Next != n)
                {
                    Current = Current.Next;
                }
                if (Current == null)
                {
                    return;
                }
                Current.Next = n.Next;
            }
        }

        public void DeleteAfterHash()
        {
            Node Current = Head;
            if (FindSymbol('#') != 0)
            {
                while (Current.value != '#')
                {
                    Current = Current.Next;
                }
                while (Current.Next != null)
                {
                    DeleteNode(Current.Next);
                }
            }

        }
        ~MyList()
        {
            while (Head != null)
            {
                Head = Head.Next;
            }
        }
    }
}
