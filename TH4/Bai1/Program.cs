using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Display();

            var value = stack.Pop();
            Console.WriteLine($"Data vừa được pop: {value}");

            stack.Display();

            Console.ReadKey();
        }
    }
}
