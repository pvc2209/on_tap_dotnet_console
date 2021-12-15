using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            TamGiac tg = new TamGiac();

            tg.Nhap();
            tg.In();

            
            Console.WriteLine($"Chu vi: {tg.TinhChuVi()}");
            Console.WriteLine($"Diện tích: {tg.TinhDienTich()}");

            if (tg.LaTamGiacCan())
            {
                Console.WriteLine("Tam giác đã nhập là tam giác cân");
            }

            if (tg.LaTamGiacDeu())
            {
                Console.WriteLine("Tam giác đã nhập là tam giác đều");
            }

            if (tg.LaTamGiacVuong())
            {
                Console.WriteLine("Tam giác đã nhập là tam giác vuông");
            }
        }
    }
}
