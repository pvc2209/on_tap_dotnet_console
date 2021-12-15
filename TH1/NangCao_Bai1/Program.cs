using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai1
{
    internal class Program
    {
        public static double readDouble()
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
            Console.Write("Nhập đơn giá của mặt hàng: ");
            double donGia = readDouble();

            Console.Write("Nhập số lượng bán của mặt hàng: ");
            int soLuong = ReadInt();

            double thanhTien = donGia * soLuong;

            double giamGia = 0;
            if (thanhTien > 100)
            {
                giamGia = 0.03 * thanhTien;
            }

            double tongTienTra = thanhTien - giamGia;

            Console.WriteLine($"Tổng số tiền phải trả: {tongTienTra}");
        }
    }
}
