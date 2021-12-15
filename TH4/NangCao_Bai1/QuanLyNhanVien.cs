using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai1
{
    internal class QuanLyNhanVien
    {
        private List<NhanVien> dsnv;

        public QuanLyNhanVien()
        {
            dsnv = new List<NhanVien>();
        }

        public void Nhap()
        {
            int n = 0;
            do
            {
                Console.Write("Nhập số lượng nhân viên: ");
                n = Helper.ReadInt();

                if (n <= 0)
                {
                    Console.WriteLine("Số lượng không hợp lệ!");
                }
            } while (n <= 0);

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine($"Nhập thông tin nhân viên thứ {i + 1}:");
                NhanVien nhanVien = new NhanVien();
                nhanVien.Nhap();

                dsnv.Add(nhanVien);

                Console.WriteLine();
            }
        }

        public void HienThi()
        {
            for (int i = 0; i < dsnv.Count; ++i)
            {
                Console.WriteLine($"Thông tin nhân viên thứ {i + 1}:");
                dsnv[i].HienThi();
                Console.WriteLine();
            }
        }

        public void SapXepTangDanTheoHeSoLuong()
        {
            for (int i = 0; i < dsnv.Count - 1; ++i)
            {
                for (int j = i + 1; j < dsnv.Count; ++j)
                {
                    if (dsnv[j].HeSoLuong < dsnv[i].HeSoLuong)
                    {
                        NhanVien temp = dsnv[j];
                        dsnv[j] = dsnv[i];
                        dsnv[i] = temp;
                    }
                }
            }
        }

        public void LietKeNhanVienCoHeSoLuongCaoNhat()
        {
            if (dsnv.Count == 0)
            {
                Console.WriteLine("Không có nhân viên");
                return;
            }

            NhanVien result = dsnv[0];

            for (int i = 1; i < dsnv.Count; ++i)
            {
                if (dsnv[i].HeSoLuong > result.HeSoLuong)
                {
                    result = dsnv[i];
                }
            }

            Console.WriteLine("Nhân viên có hệ số lương cao nhất là:");
            result.HienThi();
            Console.WriteLine();
        }
    }
}
