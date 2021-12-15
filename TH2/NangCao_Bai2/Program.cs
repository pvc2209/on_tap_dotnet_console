using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai2
{
    internal class Program
    {
        private const int MAX = 100;

        private static int[,] bang = new int[MAX + 1, MAX + 1];

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
                Console.Write("Nhap so luong phan tu = ");
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

        private static void TimDayConChungDaiNhat(int[] a, int n, int[] b, int m)
        {
            // Tạo bảng phương án
            for (int i = 1; i <= m; ++i)
            {
                for (int j = 1; j <= n; ++j)
                {
                    if (a[j - 1] == b[i - 1])
                    {
                        bang[i, j] = bang[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        bang[i, j] = Math.Max(bang[i, j - 1], bang[i - 1, j]);
                    }
                }
            }

            // In ra bang danh dau
            for (int i = 0; i <= m; ++i)
            {
                for (int j = 0; j <= n; ++j)
                {
                    Console.Write($"{bang[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Do dai cua day con chung: {bang[m, n]}");

            // Tim day con chung tu bang phuong an
            int p = m;
            int q = n;
            List<int> result = new List<int>();

            while (bang[p, q] != 0)
            {
                if (a[q - 1] == b[p - 1])
                {
                    result.Insert(0, a[q - 1]);
                    --p;
                    --q;
                }
                else if (bang[p, q - 1] > bang[p - 1, q])
                {
                    --q;
                }
                else
                {
                    --p;
                }
            }

            Console.Write("Day con chung dai nhat la: ");
            foreach (var num in result)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] a = new int[MAX];
            int n = 0;

            NhapMang(a, ref n);
            XuatMang(a, n);

            int[] b = new int[MAX];
            int m = 0;

            NhapMang(b, ref m);
            XuatMang(b, m);

            TimDayConChungDaiNhat(a, n, b, m);
        }
    }
}
