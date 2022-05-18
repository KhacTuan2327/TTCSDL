using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL
{
    class TieuBan
    {
        private string maTB;
        private string tenTB;
        private string diaChi;
        private string truongTB;
        private string linhVuc;
        private string sdt;
        public TieuBan()
        {
        }

        public TieuBan(string maTB, string tenTB, string diaChi, string truongTB, string linhVuc, string sdt)
        {
            this.maTB = maTB;
            this.tenTB = tenTB;
            this.diaChi = diaChi;
            this.truongTB = truongTB;
            this.linhVuc = linhVuc;
            this.sdt = sdt;
        }

        public string MaTB { get => maTB; set => maTB = value; }
        public string TenTB { get => tenTB; set => tenTB = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string TruongTB { get => truongTB; set => truongTB = value; }
        public string LinhVuc { get => linhVuc; set => linhVuc = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
