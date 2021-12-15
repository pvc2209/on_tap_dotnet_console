using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai1
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

        private static void DemPhanTuXuatHienNhieuNhat(int[] a, int n)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < n; ++i)
            {
                if (dict.ContainsKey(a[i]))
                {
                    dict[a[i]] += 1;
                }
                else
                {
                    dict[a[i]] = 1;
                }
            }

            int num = a[0];
            int maxCount = 1;
            bool flag = false;

            foreach (KeyValuePair<int, int> item in dict)
            {
                if (flag == false)
                {
                    num = item.Key;
                    maxCount = item.Value;
                    flag = true;
                }
                else
                {
                    if (item.Value > maxCount)
                    {
                        maxCount = item.Value;
                        num = item.Key;
                    }
                }
            }

            foreach(KeyValuePair<int, int> item in dict)
            {
                if (item.Value == maxCount)
                {
                    Console.WriteLine($"Phan tu {item.Value} xuat hien {maxCount} lan");
                }
            }
        }

        private static void TimLe(int[] a, int n)
        {
            int maxChan = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0 && a[i] > maxChan)
                {
                    maxChan = a[i];
                }
            }

            int minLe = int.MaxValue;
            bool flag = false;

            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0 && a[i] > maxChan && a[i] < minLe)
                {
                    minLe = a[i];
                    flag = true;
                }
            }

            if (flag)
            {
                Console.WriteLine($"So le nho nhat lon hon so chan lon nhat {maxChan} la: {minLe}");
            }
            else
            {
                Console.WriteLine("Khong co so le thoa man");
            }
        }

        private static void XoaPhanTu(int[] a, ref int n, int index)
        {
            for (int i = index; i < n - 1; ++i)
            {
                a[i] = a[i + 1];
            }

            n--;
        }

        private static void XoaTrung(int[] a, ref int n)
        {
            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (a[j] == a[i])
                    {
                        XoaPhanTu(a, ref n, j);
                        --j;
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

            // 1. Đếm số phần tử xuất hiện nhiều nhất trong mảng
            DemPhanTuXuatHienNhieuNhat(a, n);

            // 2. Tìm số lẻ nhỏ nhất lớn hơn mọi số chẵn có trong mảng
            TimLe(a, n);

            // 3. Xoá tất cả những phần tử trùng nhau trong dãy chỉ giữ lại một phần tử trong đó
            XoaTrung(a, ref n);
            XuatMang(a, n);
        }
    }
}
