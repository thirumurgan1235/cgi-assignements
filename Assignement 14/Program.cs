using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            stack.Display();

            stack.Pop();
            stack.Display();

            stack.Pop();
            stack.Pop();
            stack.Pop(); 
        }
    }
    }

