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
        private string chudt;
        private string nam;
        private string tiendo;
        private string tennganh;
        private string trangthai;
        private string ngaydangky;
        private string capql;
        private string tieuban;

        public detai()
        {
        }

        public detai(string madt, string tendt, string kinhphi, string ngaydangky, string nam, string tiendo, string trangthai, string tieuban, string tennganh, string capql, string chudt)
        {
            this.madt = madt;
            this.tendt = tendt;
            this.kinhphi = kinhphi;
            this.chudt = chudt;
            this.nam = nam;
            this.tiendo = tiendo;
            this.tennganh = tennganh;
            this.trangthai = trangthai;
            this.ngaydangky = ngaydangky;
            this.capql = capql;
            this.tieuban = tieuban;
        }

        public string Madt { get => madt; set => madt = value; }
        public string Tendt { get => tendt; set => tendt = value; }
        public string Kinhphi { get => kinhphi; set => kinhphi = value; }
        public string Chudt { get => chudt; set => chudt = value; }
        public string Nam { get => nam; set => nam = value; }
        public string Tiendo { get => tiendo; set => tiendo = value; }
        public string Tennganh { get => tennganh; set => tennganh = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string Ngaydangky { get => ngaydangky; set => ngaydangky = value; }
        public string Capql { get => capql; set => capql = value; }
        public string Tieuban { get => tieuban; set => tieuban = value; }
    }
}
