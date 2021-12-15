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
        public void NhapDanhSachSinhVien()
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

        private void SapXepDTBGiamDan()
        {
            for (int i = 0; i < dssv.Count - 1; ++i)
            {
                for (int j = i + 1; j < dssv.Count; ++j)
                {
                    if (dssv[j].DiemTrungBinh > dssv[i].DiemTrungBinh)
                    {
                        SinhVien temp = dssv[j];
                        dssv[j] = dssv[i];
                        dssv[i] = temp;
                    }
                }
            }
        }

        public void HienThi3SinhVienCoDiemTrungBinhCaoNhat()
        {
            SapXepDTBGiamDan();

            Console.WriteLine("3 sinh viên có điểm trung bình cao nhất là:");

            for (int i = 0; i < dssv.Count && i < 3; ++i)
            {
                dssv[i].HienThi();
                Console.WriteLine();
            }

            if (dssv.Count < 3)
            {
                Console.WriteLine("Số lượng sinh viên chỉ có {dssv.Count}");
            }
            else if (dssv.Count > 3)
            {
                Console.WriteLine("Các sinh viên có điểm trung bình bằng với người thứ 3 là:");

                int index = 3;

                while (index < dssv.Count)
                {
                    if (dssv[index].DiemTrungBinh == dssv[2].DiemTrungBinh)
                    {
                        dssv[index].HienThi();
                        Console.WriteLine();
                    }
                    ++index;
                }
            }
        }
    }
}
