using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            TienDien tienDienMoi = new TienDienMoi("A", "Phu Tho", 10, 210, 100);

            Console.WriteLine($"Tiền điện: {tienDienMoi.TinhTienDien()}");
        }
    }
}
