using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class QuanLyKho
    {
        private List<Hang> dsmh = new List<Hang>();

        private bool KiemTraMaSoHang(string ma)
        {
            foreach (Hang hang in dsmh)
            {
                if (hang.MaSo == ma)
                {
                    return false;
                }
            }

            return true;
        }

        public void NhapHang()
        {
            int n = 0;
            do
            {
                Console.Write("Nhập số lượng hàng: ");
                n = Helper.ReadInt();

                if (n <= 0)
                {
                    Console.WriteLine("Số lượng không hợp lệ!");
                }
            } while (n <= 0);

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine($"Nhập thông tin mặt hàng thứ {i + 1}:");
                Hang hang = new Hang();
                hang.Nhap();

                if (KiemTraMaSoHang(hang.MaSo))
                {
                    dsmh.Add(hang);
                }
                else
                {
                    Console.WriteLine("Mã hàng bị trùng!");
                    --i;
                }
                Console.WriteLine();
            }
        }

        public void HienThi()
        {
            for (int i = 0; i < dsmh.Count; ++i)
            {
                Console.WriteLine($"Thông tin mặt hàng thứ {i + 1}:");
                dsmh[i].HienThi();
                Console.WriteLine();
            }
        }
    }
}
