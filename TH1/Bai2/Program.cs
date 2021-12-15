using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
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

            Console.Write("Nhập chiều dài = ");
            double dai = ReadDouble();

            Console.Write("Nhập chiều rộng = ");
            double rong = ReadDouble();

            Console.WriteLine($"Diện tich = {dai * rong}");
            Console.WriteLine($"Chu vi = {(dai + rong) * 2}");
        }
    }
}
