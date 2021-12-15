using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangCao_Bai2
{
    // const: Can't be changed anywhere.
    // Constants are static by default

    // readonly: This value can only be changed in the constructor.
    // Can't be changed in normal functions.
    internal class TienDien
    {
        public const int DON_GIA = 1240;

        protected string hoTenChuHo;
        protected string diaChi;
        protected int congToThangTruoc;
        protected int congToThangNay;

        public TienDien()
        {
            hoTenChuHo = "Unknown";
            diaChi = "Unknown";
            congToThangTruoc = 0;
            congToThangNay = 0;
        }

        public TienDien(string hoTenChoHo, string diaChi, int congToThangTruoc,
            int congToThangNay)
        {
            this.hoTenChuHo = hoTenChoHo;
            this.diaChi = diaChi;
            this.congToThangTruoc = congToThangTruoc;
            this.congToThangNay = congToThangNay;
        }

        public int TinhSoDien()
        {
            return congToThangNay - congToThangTruoc;
        }

        public virtual int TinhTienDien()
        {
            return TinhSoDien() * TienDien.DON_GIA;
        }

    }
}
