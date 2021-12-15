using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        public const double pi = 3.14;

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

            Console.Write("Nhập bán kính hình tròn = ");
            var banKinh = ReadDouble();

            var chuVi = 2 * pi * banKinh;
            var dienTich = pi * banKinh * banKinh;

            Console.WriteLine($"Chu vi = {chuVi}");
            Console.WriteLine($"Diện tích = {dienTich}");
        }
    }
}
