using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement14_task2
{
    internal class Queue
    {
        private Node front; 
        private Node rear;  
        public void Insert(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = null;

            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
            Console.WriteLine($"{data} inserted into queue.");
        }

        
        public void Delete()
        {
            if (front == null)
            {
                Console.WriteLine("Queue Underflow! Cannot delete.");
                return;
            }

            Console.WriteLine($"{front.Data} deleted from queue.");
            front = front.Next;

            if (front == null) 
            {
                rear = null;
            }
        }
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine("Queue elements (front to rear):");
            Node temp = front;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
