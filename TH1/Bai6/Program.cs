using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
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

        private static bool kiemTraNguyenTo(int n)
        {
            int sqrtn = (int)Math.Sqrt(n);

            for (var i = 2; i <= sqrtn; ++i)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập n = ");

            int n = ReadInt();

            if (kiemTraNguyenTo(n))
            {
                Console.WriteLine("n là số nguyên tố");
            }
            else
            {
                Console.WriteLine($"{n} không phải là số nguyên tố");
            }
        }
    }
}
