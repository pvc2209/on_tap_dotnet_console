using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{

    internal class Program
    {
        private const int MAX = 100;

        private static double ReadDouble()
        {
            double value = 0;
            bool valid = false;
            do
            {
                try
                {
                    value = double.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Giá trị không hợp lệ!");
                    Console.Write("Nhập lại: ");
                    valid = false;
                }
            } while (valid == false);


            return value;
        }
        private static int ReadInt()
        {
            int value = 0;
            bool valid = false;
            do
            {
                try
                {
                    value = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Giá trị không hợp lệ!");
                    Console.Write("Nhập lại: ");
                    valid = false;
                }
            } while (valid == false);


            return value;
        }

        private static void NhapMang(int[] a, ref int n)
        {

            do
            {
                Console.Write("Nhap n = ");
                n = ReadInt();

                if (n <= 0 || n > MAX)
                {
                    Console.WriteLine("n khong hop le!");
                }

            } while (n <= 0 || n > MAX);

            for (int i = 0; i < n; ++i)
            {
                Console.Write($"Nhap a[{i}] = ");
                a[i] = ReadInt();
            }
        }

        private static void XuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; ++i)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }

        private static void LietKetDuong(int[] a, int n)
        {
            Console.Write("Cac phan tu duong trong mang: ");
            for (int i = 0; i < n; ++i)
            {
                if (a[i] > 0)
                {
                    Console.Write($"{a[i]} ");
                }
            }
            Console.WriteLine();
        }

        private static void LietKetLeViTriChan(int[] a, int n)
        {
            Console.Write("Cac phan tu le o vi tri chan: ");
            for (int i = 0; i < n; i += 2)
            {
                if (a[i] % 2 != 0)
                {
                    Console.Write($"{a[i]} ");
                }
            }
            Console.WriteLine();
        }

        private static bool KiemTraNguyenTo(int n)
        {
            int sqrtn = (int)Math.Sqrt(n);

            for (int i = 2; i <= sqrtn; ++i)
            {
                if (i % 2 == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool KiemTraChinhPhuong(int n)
        {
            return Math.Sqrt(n) * Math.Sqrt(n) == n;
        }

        private static bool KiemTraHoanHao(int n)
        {
            int tong = 0;

            for (int i = 1; i <= n / 2; ++i)
            {
                if (n % i == 0)
                {
                    tong += i;
                }
            }

            return tong == n;
        }


        private static void LietKetNguyenTo(int[] a, int n)
        {
            Console.Write("Các số nguyên tố trong mảng: ");
            for (int i = 0; i < n; ++i)
            {
                if (KiemTraNguyenTo(a[i]))
                {
                    Console.Write($"{a[i]} ");
                }
            }
            Console.WriteLine();
        }

        private static void LietKetChinhPhuong(int[] a, int n)
        {
            Console.Write("Các số chính phương trong mảng: ");
            for (int i = 0; i < n; ++i)
            {
                if (KiemTraChinhPhuong(a[i]))
                {
                    Console.Write($"{a[i]} ");
                }
            }
            Console.WriteLine();
        }

        private static void LietKetHoanhao(int[] a, int n)
        {
            Console.Write("Các số hoàn hảo trong mảng: ");
            for (int i = 0; i < n; ++i)
            {
                if (KiemTraHoanHao(a[i]))
                {
                    Console.Write($"{a[i]} ");
                }
            }
            Console.WriteLine();
        }

        private static int TimMin(int[] a, int n)
        {
            int min = a[0];

            for (int i = 1; i < n; ++i)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            return min;
        }

        private static int TimMax(int[] a, int n)
        {
            int max = a[0];

            for (int i = 1; i < n; ++i)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }

        private static void XoaPhanTu(int[] a, ref int n, int index)
        {
            for (int i = index; i < n - 1; ++i)
            {
                a[i] = a[i + 1];
            }

            n--;
        }

        private static void XoaPhanTuX(int[] a, ref int n, int x)
        {
            for (int i = 0; i < n; ++i)
            {
                if (a[i] == x)
                {
                    XoaPhanTu(a, ref n, i);
                }
            }
        }

        private static void SapXepTangDan(int[] a, int n)
        {
            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (a[j] < a[i])
                    {
                        (a[i], a[j]) = (a[j], a[i]);
                    }
                }
            }
        }

        private static void SapXepGiamDan(int[] a, int n)
        {
            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (a[j] > a[i])
                    {
                        (a[i], a[j]) = (a[j], a[i]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] a = new int[MAX];
            int n = 0;

            NhapMang(a, ref n);
            XuatMang(a, n);

            // 1.
            LietKetDuong(a, n);

            // 2.
            LietKetLeViTriChan(a, n);

            // 3.
            LietKetNguyenTo(a, n);
            LietKetChinhPhuong(a, n);
            LietKetHoanhao(a, n);

            // 4.
            Console.WriteLine($"Số nhỏ nhất trong mảng: {TimMin(a, n)}");
            Console.WriteLine($"Số lớn nhất trong mảng: {TimMax(a, n)}");

            // 5.
            XoaPhanTu(a, ref n, 2);
            XuatMang(a, n);

            // 6.
            XoaPhanTuX(a, ref n, 8);
            XuatMang(a, n);

            // 7.
            SapXepTangDan(a, n);
            XuatMang(a, n);

            SapXepGiamDan(a, n);
            XuatMang(a, n);
        }
    }
}
