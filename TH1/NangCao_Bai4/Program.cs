using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai4
{
    internal class Program
    {
        public static int ReadInt()
        {
            int value = 0;
            bool valid = false;
            do
            {
                try
                {
                    value = int.Parse(Console.ReadLine());
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

            Console.Write("Nhập x = ");
            var x = ReadDouble();

            int n;
            do
            {
                Console.Write("Nhập n = ");
                n = ReadInt();

                if (n <= 0)
                {
                    Console.WriteLine("n phải lớn hơn 0");
                }

            } while (n <= 0);

            double tu = 1;
            double mau = 1;

            double s = 0;

            for (int i = 1; i <= n; ++i)
            {
                tu *= x;
                mau *= i;

                s += tu / mau;
            }

            Console.WriteLine($"S({x}, {n}) = {s}");
        }
    }
}
