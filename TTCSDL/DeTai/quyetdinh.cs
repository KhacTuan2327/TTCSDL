using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL
{
    class quyetdinh
    {
        private string id;
        private string name;
        private string nd;
        private string ngaybh;
        private string madt;

        public quyetdinh()
        {
        }

        public quyetdinh(string id, string name, string nd, string ngaybh, string madt)
        {
            this.id = id;
            this.name = name;
            this.nd = nd;
            this.ngaybh = ngaybh;
            this.madt = madt;
        }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Nd { get => nd; set => nd = value; }
        public string Ngaybh { get => ngaybh; set => ngaybh = value; }
        public string Madt { get => madt; set => madt = value; }
    }
}
