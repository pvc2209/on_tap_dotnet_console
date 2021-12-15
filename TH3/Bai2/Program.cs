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
            quanLy.NhapDanhSachSinhVien();
            quanLy.HienThi();

            quanLy.HienThi3SinhVienCoDiemTrungBinhCaoNhat();
        }
    }
}
