using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai1
{
    internal class NhanVien
    {
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
        public double HeSoLuong { get; set; }
        public double LuongCoBan { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập quê quán: ");
            QueQuan = Console.ReadLine();

            Console.Write("Nhập hệ số lương: ");
            HeSoLuong = Helper.ReadDouble();

            Console.Write("Nhập lương cơ bản: ");
            LuongCoBan = Helper.ReadDouble();
        }

        public double Luong
        {
            get
            {
                return HeSoLuong * LuongCoBan;
            }
        }

        public void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}");

            Console.WriteLine($"Quê quán: {QueQuan}");

            Console.WriteLine($"Hệ số lương: {HeSoLuong}");

            Console.WriteLine($"Lương cơ bản: {LuongCoBan}");

            Console.WriteLine($"Lương: {Luong}");
        }
    }
}
