using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int ga = 0; ga <= 36; ++ga)
            {
                int cho = 36 - ga;

                if (ga * 2 + cho * 4 == 100)
                {
                    Console.WriteLine($"Gà = {ga}, Chó = {cho}");
                }
            }
        }
    }
}
