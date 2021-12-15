using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai2
{
    internal class Tester
    {
        private List<HinhHoc> dsh;

        public Tester()
        {
            dsh = new List<HinhHoc>();

            dsh.Add(new HinhTron());
            dsh.Add(new HinhVuong());
        }

        public void DrawAll()
        {
            foreach (HinhHoc h in dsh)
            {
                h.Draw();
            }
        }
    }
}
