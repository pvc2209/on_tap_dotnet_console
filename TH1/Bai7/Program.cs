using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
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

        private static int tinhGiaiThua(int n)
        {
            if (n == 0) return 1;

            int giaiThua = 1;

            while (n > 0)
            {
                giaiThua *= n;
                n -= 1;
            }

            return giaiThua;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập n = ");

            int n = ReadInt();

            Console.WriteLine($"{n}! = {tinhGiaiThua(n)}");

        }
    }
}
