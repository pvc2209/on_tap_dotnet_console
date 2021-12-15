using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class SinhVien
    {
        public string MSV { get; set; }

        public string HoTen { get; set; }

        public double DiemTrungBinh { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập mã số sinh viên: ");
            MSV = Console.ReadLine();

            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            do
            {
                Console.Write("Nhập điểm trung bình: ");
                DiemTrungBinh = Helper.ReadDouble();

                if (DiemTrungBinh < 0)
                {
                    Console.WriteLine("Điểm trung bình không hợp lệ!");
                }
            } while (DiemTrungBinh < 0);
        }

        public void HienThi()
        {
            Console.WriteLine($"Mã sinh viên: {MSV}");
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Điểm trung bình: {DiemTrungBinh}");
        }
    }
}
