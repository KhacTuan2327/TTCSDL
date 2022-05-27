using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL
{
    internal class detai
    {
        private string madt;
        private string tendt;
        private string kinhphi;
        private string ngaydangky;
        private string nam;
        private string tieuban;
        private string nganh;
        private string capql;
        private string chudt;
        private string trangthai;
        private string ketqua;

        public detai()
        {
        }

        public detai(string madt, string tendt, string kinhphi, string ngaydangky, string nam, string tieuban, string nganh, string capql, string chudt, string trangthai, string ketqua)
        {
            this.madt = madt;
            this.tendt = tendt;
            this.kinhphi = kinhphi;
            this.ngaydangky = ngaydangky;
            this.nam = nam;
            this.tieuban = tieuban;
            this.nganh = nganh;
            this.capql = capql;
            this.chudt = chudt;
            this.trangthai = trangthai;
            this.ketqua = ketqua;
        }

        public string Madt { get => madt; set => madt = value; }
        public string Tendt { get => tendt; set => tendt = value; }
        public string Kinhphi { get => kinhphi; set => kinhphi = value; }
        public string Ngaydangky { get => ngaydangky; set => ngaydangky = value; }
        public string Nam { get => nam; set => nam = value; }
        public string Tieuban { get => tieuban; set => tieuban = value; }
        public string Nganh { get => nganh; set => nganh = value; }
        public string Capql { get => capql; set => capql = value; }
        public string Chudt { get => chudt; set => chudt = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string Ketqua { get => ketqua; set => ketqua = value; }
    }
}