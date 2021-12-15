using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class QuanLySinhVien
    {
        private List<SinhVien> dssv = new List<SinhVien>();

        private bool KiemTraMaSinhVien(string msv)
        {
            foreach (SinhVien sv in dssv)
            {
                if (sv.MSV == msv)
                {
                    return false;
                }
            }

            return true;
        }

        public void NhapDanhSach()
        {
            int n = 0;
            do
            {
                Console.Write("Nhập số lượng sinh viên: ");
                n = Helper.ReadInt();

                if (n <= 0)
                {
                    Console.WriteLine("Số lượng không hợp lệ!");
                }
            } while (n <= 0);

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine($"Nhập thông tin sinh viên thứ {i + 1}:");
                SinhVien sinhVien = new SinhVien();
                sinhVien.Nhap();

                if (KiemTraMaSinhVien(sinhVien.MSV))
                {
                    dssv.Add(sinhVien);
                }
                else
                {
                    Console.WriteLine("Mã sinh viên bị trùng!");
                    --i;
                }
                Console.WriteLine();
            }
        }

        public void HienThi()
        {
            for (int i = 0; i < dssv.Count; ++i)
            {
                Console.WriteLine($"Thông tin sinh viên thứ {i + 1}:");
                dssv[i].HienThi();
                Console.WriteLine();
            }
        }

        public void HienThiDanhSachSinhVienCoDiemTrungBinhCao(double diem)
        {
            Console.WriteLine($"Danh sách sinh viên có điểm TB cao hơn {diem} la:");
            foreach (var sv in dssv)
            {
                if (sv.DiemTrungBinh > diem)
                {
                    Console.WriteLine($"Họ tên: {sv.HoTen}");
                    Console.WriteLine($"Chuyên ngành: {sv.ChuyenNganh}");
                    Console.WriteLine($"Điểm trung bình: {Math.Round(sv.DiemTrungBinh, 2)}");
                    Console.WriteLine();
                }
            }
        }

    }
}
