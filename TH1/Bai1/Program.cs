using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        public static double ReadDouble()
        {
            double value = 0;
            bool valid = false;
            do
            {
                try
                {
                    value = double.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Giá trị không hợp lệ!");
                    Console.Write("Nhập lại: ");
                    valid = false;
                }
            } while (valid == false);


            return value;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double a = 0;
            Console.Write("Nhập a = ");
            do
            {
                a = ReadDouble();

                if (a == 0)
                {
                    Console.WriteLine("a phải khác 0");
                    Console.Write("Nhập lại: ");
                }
            } while (a == 0);


            Console.Write("Nhập b = ");
            double b = ReadDouble();

            Console.WriteLine($"x = {-b / a}");

        }
    }
}
