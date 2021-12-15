using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class TamGiac
    {
        public double A { get; set; }

        public double B { get; set; }

        public double C { get; set; }

        public void Nhap()
        {
            do
            {
                do
                {
                    Console.Write("Nhập cạnh A: ");
                    A = Helper.ReadDouble();

                    if (A <= 0)
                    {
                        Console.WriteLine("Độ dài không hợp lệ!");
                    }
                } while (A <= 0);


                do
                {
                    Console.Write("Nhập cạnh B: ");
                    B = Helper.ReadDouble();

                    if (B <= 0)
                    {
                        Console.WriteLine("Độ dài không hợp lệ!");
                    }
                } while (B <= 0);

                do
                {
                    Console.Write("Nhập cạnh C: ");
                    C = Helper.ReadDouble();

                    if (C <= 0)
                    {
                        Console.WriteLine("Độ dài không hợp lệ!");
                    }
                } while (C <= 0);

                if (!LaTamGiacThuong())
                {
                    Console.WriteLine("3 cạnh không tạo thành 1 tam giác!");
                }

            } while (!LaTamGiacThuong());
            
        }

        public void In()
        {
            Console.WriteLine($"Tam giác (A, B, C) : ({A}, {B}, {C})");
        }

        public double TinhChuVi()
        {
            return A + B + C;
        }

        public double TinhDienTich()
        {
            double p = TinhChuVi() / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool LaTamGiacThuong()
        {
            if (A + B > C && A + C > B && B + C > A)
            {
                return true;
            }
            return false;
        }

        public bool LaTamGiacCan()
        {
            if (LaTamGiacThuong())
            {
                if (A == B || A == C || B == C)
                {
                    return true;
                }
            }

            return false;
        }

        public bool LaTamGiacDeu()
        {
            if (LaTamGiacThuong())
            {
                if (A == B && B == C)
                {
                    return true;
                }
            }

            return false;
        }

        public bool LaTamGiacVuong()
        {
            if (LaTamGiacThuong())
            {
                if (A * A + B * B == C * C || A * A + C * C == B * B 
                    || B * B + C * C == A * A)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
