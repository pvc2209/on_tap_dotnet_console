using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    //Biết rằng mỗi sinh viên gồm có các thuộc tính sau:
    //mã sinh viên, Họ tên, ngày tháng năm sinh, Điểm toán,
    //điểm văn, điểm anh, chuyên ngành đào tạo

    internal class SinhVien
    {
        public string MSV { get; set; }

        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }

        public double DiemToan { get; set; }

        public double DiemVan { get; set; }

        public double DiemAnh { get; set; }

        public string ChuyenNganh { get; set; }

        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            MSV = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
            NgaySinh = Helper.ReadDateTime();

            Console.Write("Nhap diem toan: ");
            DiemToan = Helper.ReadDouble();

            Console.Write("Nhap diem van: ");
            DiemVan = Helper.ReadDouble();

            Console.Write("Nhap diem anh: ");
            DiemAnh = Helper.ReadDouble();

            Console.Write("Nhap chuyen nganh: ");
            ChuyenNganh = Console.ReadLine();
        }

        public double DiemTrungBinh
        {
            get
            {
                return Math.Round((DiemToan + DiemVan + DiemAnh) / 3, 3);
            }
        }

        public void HienThi()
        {
            Console.WriteLine($"Ma sinh vien: {MSV}");
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Ngay thang nam sinh: {NgaySinh.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Diem toan: {DiemToan}");
            Console.WriteLine($"Diem van: {DiemVan}");
            Console.WriteLine($"Diem anh: {DiemAnh}");
            Console.WriteLine($"Chuyen nganh: {ChuyenNganh}");
            Console.WriteLine($"Diem trung binh: {DiemTrungBinh}");
        }

        
    }
}
