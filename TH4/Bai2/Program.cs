using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            QuanLySinhVien quanLy = new QuanLySinhVien();
            quanLy.NhapDanhSach();
            quanLy.HienThi();
            quanLy.HienThiDanhSachSinhVienCoDiemTrungBinhCao(5.0);
        }
    }
}
