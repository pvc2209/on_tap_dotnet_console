using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            QuanLyNhanVien quanLy = new QuanLyNhanVien();

            quanLy.Nhap();
            quanLy.HienThi();

            Console.WriteLine("Danh sách nhân viên theo hệ số lương tăng dần là:");
            quanLy.SapXepTangDanTheoHeSoLuong();
            quanLy.HienThi();

            quanLy.LietKeNhanVienCoHeSoLuongCaoNhat();
        }
    }
}
