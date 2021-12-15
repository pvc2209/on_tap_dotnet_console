using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai2
{
    internal class TienDienMoi : TienDien
    {
        public const int DON_GIA_NGOAI_DINH_MUC = 1600;

        private int dinhMuc;

        public TienDienMoi(int dinhMuc)
        {
            this.dinhMuc = dinhMuc;
        }

        public TienDienMoi(string hoTenChoHo, string diaChi, 
            int congToThangTruoc, int congToThangNay, int dinhMuc) 
            : base(hoTenChoHo, diaChi, congToThangTruoc, congToThangNay)
        {
            this.dinhMuc = dinhMuc;
        }

        public override int TinhTienDien()
        {
            int soDien = TinhSoDien();

            if (soDien < dinhMuc)
            {
                return soDien * DON_GIA;
            }

            return dinhMuc * DON_GIA + (soDien - dinhMuc) * DON_GIA_NGOAI_DINH_MUC;
        }
    }
}
