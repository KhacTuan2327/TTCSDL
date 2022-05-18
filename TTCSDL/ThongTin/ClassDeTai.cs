using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL
{
    class ClassDeTai
    {
        private string maDT;
        private string tenDT;
        private string kinhphi;
        private string ngayDK;
        private string nam;
        private string maTB;
        private string maNganh;
        private string maCap;
        private string maCB;
        private string trangThai;
        public ClassDeTai()
        {

        }
        public ClassDeTai(string maDT, string tenDT, string kinhphi, string ngayDK, string nam, string maTB, string maNganh, string maCap, string maCB, string trangThai)
        {
            this.maDT = maDT;
            this.tenDT = tenDT;
            this.kinhphi = kinhphi;
            this.ngayDK = ngayDK;
            this.nam = nam;
            this.maTB = maTB;
            this.maNganh = maNganh;
            this.maCap = maCap;
            this.maCB = maCB;
            this.trangThai = trangThai;
        }

        public string MaDT { get => maDT; set => maDT = value; }
        public string TenDT { get => tenDT; set => tenDT = value; }
        public string Kinhphi { get => kinhphi; set => kinhphi = value; }
        public string NgayDK { get => ngayDK; set => ngayDK = value; }
        public string Nam { get => nam; set => nam = value; }
        public string MaTB { get => maTB; set => maTB = value; }
        public string MaNganh { get => maNganh; set => maNganh = value; }
        public string MaCap { get => maCap; set => maCap = value; }
        public string MaCB { get => maCB; set => maCB = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
