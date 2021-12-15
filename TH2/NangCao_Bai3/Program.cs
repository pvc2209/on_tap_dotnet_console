using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai3
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
                    a[i, j] = ReadInt();
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

        private static void NhanMaTran(int[,] a, int m, int n, int[,] b, int p, int q)
        {
            // Để nhân ma trận,
            // số lượng cột trong ma trận thứ nhất
            // phải bằng số lượng hàng trong ma trận thứ hai
            if (n != p)
            {
                Console.WriteLine("Không thể nhân 2 ma trân!");
                Console.WriteLine("Số lượng cột của ma trận A != Số lượng hàng của ma trận B");
                return;
            }

            int[,] c = new int[m, q];

            // https://www.youtube.com/watch?v=ySo2819l0HE
            // Cij = (hàng i của A) nhân vô hướng (cột j của B)

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < q; ++j)
                {
                    int sum = 0;
                    for (int k = 0; k < n; ++k)
                    {
                        sum += a[i, k] * b[k, j];
                    }
                    c[i, j] = sum;
                }
            }

            Console.WriteLine("\nMa trận C:");
            XuatMaTran(c, m, q);
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[,] a = new int[MAX, MAX];

            int m, n; // m hang, n cot

            NhapMaTran(a, out m, out n);
            XuatMaTran(a, m, n);

            int[,] b = new int[MAX, MAX];

            int p, q; // p hang, q cot

            NhapMaTran(b, out p, out q);
            XuatMaTran(b, p, q);

            NhanMaTran(a, m, n, b, p, q);
        }
    }
}
