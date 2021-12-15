using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        private const int MAX = 100;

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

        private static void NhapMaTran(int[,] a, out int m, out int n)
        {
            do
            {
                Console.Write("Nhap m = ");
                m = ReadInt();

                if (m <= 0 || m > MAX)
                {
                    Console.WriteLine("m khong hop le!");
                }

            } while (m <= 0 || m > MAX);

            do
            {
                Console.Write("Nhap n = ");
                n = ReadInt();

                if (n <= 0 || n > MAX)
                {
                    Console.WriteLine("n khong hop le!");
                }

            } while (n <= 0 || n > MAX);


            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write($"Nhap a[{i}, {j}] = ");
                    a[i,j] = ReadInt();
                }
            }
        }

        private static void XuatMaTran(int[,] a, int m, int n)
        {
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static int TinhTongDong(int[,] a, int n, int dong)
        {
            int tong = 0;

            for (int i = 0; i < n; ++i)
            {
                tong += a[dong, i];
            }

            return tong;
        }

        private static int TinhTongCot(int[,] a, int m, int cot)
        {
            int tong = 0;

            for (int i = 0; i < m; ++i)
            {
                tong += a[i, cot];
            }

            return tong;
        }

        private static int TinhTongDuongCheoChinh(int[,] a, int m, int n)
        {
            int tong = 0;

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == j)
                    {
                        tong += a[i, j];
                    }
                }
            }

            return tong;
        }

        private static void TimMaTranChuyenVi(int[,] a, int m, int n)
        {
            int[,] b = new int[n, m];

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    b[j, i] = a[i, j];
                }
            }

            Console.WriteLine("Ma tran chuyen vi la:");
            XuatMaTran(b, n, m);
        }

        private static void SapXepMangTangDan(int[] a, int n)
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

        private static void SapXepMangGiamDan(int[] a, int n)
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

        private static void SapXepTangDan(int[,] a, int m, int n)
        {
            int[] temp = new int[m * n];
            int k = 0;

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    temp[k++] = a[i, j];
                }
            }

            SapXepMangTangDan(temp, k);

            k = 0;
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    a[i, j] = temp[k++];
                }
            }
        }

        private static void SapXepGiamDan(int[,] a, int m, int n)
        {
            int[] temp = new int[m * n];
            int k = 0;

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    temp[k++] = a[i, j];
                }
            }

            SapXepMangGiamDan(temp, k);

            k = 0;
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    a[i, j] = temp[k++];
                }
            }
        }

        static void Main(string[] args)
        {
            int[,] a = new int[MAX, MAX];

            int m, n; // m hang, n cot

            NhapMaTran(a, out m, out n);

            XuatMaTran(a, m, n);

            Console.WriteLine($"Tong cac phan tu tren dong 1 la: {TinhTongDong(a, n, dong: 1)}");

            Console.WriteLine($"Tong cac phan tu tren cot 1 la: {TinhTongCot(a, m, cot: 1)}");

            Console.WriteLine($"Tong cac phan tu duong cheo chinh la: {TinhTongDuongCheoChinh(a, m, n)}");

            TimMaTranChuyenVi(a, m, n);

            Console.WriteLine("Ma tran sau khi sap xep tang dan:");
            SapXepTangDan(a, m, n);
            XuatMaTran(a, m, n);

            Console.WriteLine("Ma tran sau khi sap xep giam dan:");
            SapXepGiamDan(a, m, n);
            XuatMaTran(a, m, n);
        }
    }
}
