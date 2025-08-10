using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement14_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Insert(10);
            queue.Insert(20);
            queue.Insert(30);

            queue.Display();

            queue.Delete();
            queue.Display();

            queue.Delete();
            queue.Delete();
            queue.Delete(); 
        }
    }
    }
