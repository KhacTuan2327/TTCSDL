using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL
{
    internal class nhansu
    {
        private string id;
        private string name;
        private string ns;
        private string gt;
        private string cb;
        private string cv;
        private string sdt;
        private string mabm;

        public nhansu()
        {
        }

        public nhansu(string id, string name, string ns, string gt, string cb, string cv, string sdt, string mabm)
        {
            this.id = id;
            this.name = name;
            this.ns = ns;
            this.gt = gt;
            this.cb = cb;
            this.cv = cv;
            this.sdt = sdt;
            this.mabm = mabm;
        }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Ns { get => ns; set => ns = value; }
        public string Cb { get => cb; set => cb = value; }
        public string Cv { get => cv; set => cv = value; }
        public string Gt { get => gt; set => gt = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Mabm { get => mabm; set => mabm = value; }
    }
}
