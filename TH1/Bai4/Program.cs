using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        private static bool kiemTraChinhPhuong(int n)
        {
            return Math.Sqrt(n) * Math.Sqrt(n) == n;
        }

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

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập n = ");

            int n = ReadInt();

            if (kiemTraChinhPhuong(n))
            {
                Console.WriteLine("n là số chính phương");
            }
            else
            {
                Console.WriteLine("n không phải là số chính phương");
            }
        }
    }
}
