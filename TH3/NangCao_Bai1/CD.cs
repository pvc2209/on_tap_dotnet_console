using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai1
{
    internal class CD
    {
        public string Name { get; set; }

        public String Type { get; set; }

        public int Price { get; set; }

        public void Input()
        {
            Console.Write("Enter CD Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter CD Type: ");
            Type = Console.ReadLine();

            do
            {
                Console.Write("Enter CD Price: ");
                Price = Helper.ReadInt();

                if (Price < 0)
                {
                    Console.WriteLine("Invalid Price...");
                }
            } while (Price < 0);
        }

        public void Display()
        {
            Console.WriteLine($"CD Name: {Name}");
            Console.WriteLine($"CD Type: {Type}");
            Console.WriteLine($"CD Price: {Price}K(VND)");
        }
    }
}
