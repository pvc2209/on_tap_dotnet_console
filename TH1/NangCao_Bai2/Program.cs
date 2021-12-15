using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai2
{
    internal class Program
    {
        static int TieuThu(int soDien, int bacA, int bacB)
        {
            if (soDien < bacA)
            {
                return 0;
            }

            if (soDien > bacB)
            {
                return bacB - bacA + 1;
            }

            return soDien - bacA + 1;
        }

        static int TinhTienDien(int soDien)
        {
            if (soDien <= 0)
            {
                return 0;
            }

            var tienDien = 5 * TieuThu(soDien, 1, 100) +
                           7 * TieuThu(soDien, 101, 150) +
                           10 * TieuThu(soDien, 151, 200) +
                           15 * TieuThu(soDien, 201, 300) +
                           20 * TieuThu(soDien, 301, int.MaxValue);

            return tienDien;
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
            Console.Write("Nhập số điện: ");

            var soDien = ReadInt();

            Console.WriteLine($"Tiền điện: {TinhTienDien(soDien)}");
        }
    }
}
