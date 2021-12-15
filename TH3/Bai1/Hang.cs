using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Hang
    {
        public String MaSo { get; set; }

        public String Ten { get; set; }

        public double Gia { get; set; }

        public int SoLuong { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập mã số hàng: ");
            MaSo = Console.ReadLine();

            Console.Write("Nhập tên hàng: ");
            Ten = Console.ReadLine();

            do
            {
                Console.Write("Nhập giá: ");
                Gia = Helper.ReadDouble();

                if (Gia < 0)
                {
                    Console.WriteLine("Giá không hợp lệ!");
                }
            } while (Gia < 0);

            do
            {
                Console.Write("Nhập số lượng: ");
                SoLuong = Helper.ReadInt();

                if (SoLuong <= 0)
                {
                    Console.WriteLine("Số lượng không hợp lệ!");
                }
            } while (SoLuong <= 0);
        }

        public void HienThi()
        {
            Console.WriteLine($"Mã hàng: {MaSo}");
            Console.WriteLine($"Tên hàng: {Ten}");
            Console.WriteLine($"Giá: {Gia}");
            Console.WriteLine($"Số lượng: {SoLuong}");
            Console.WriteLine($"Tổng giá trị: {Gia * SoLuong}");
        }
    }
}
