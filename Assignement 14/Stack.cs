using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_14
{
    internal class Stack
    {
        private Node top;
        public void Push(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = top; 
            top = newNode; 
            Console.WriteLine($"{data} pushed into stack.");
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow! Cannot pop.");
                return;
            }

            Console.WriteLine($"{top.Data} popped from stack.");
            top = top.Next; 
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.WriteLine("Stack elements (top to bottom):");
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
