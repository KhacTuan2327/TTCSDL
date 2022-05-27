using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL
{
    class baibao
    {
        private string mabb;
        private string tenbb;
        private string tacgia;
        private string ngaydang;
        private string macn;
        private string madt;

        public baibao()
        {
        }

        public baibao(string mabb, string tenbb, string tacgia, string ngaydang, string macn, string madt)
        {
            this.mabb = mabb;
            this.tenbb = tenbb;
            this.Tacgia = tacgia;
            this.Ngaydang = ngaydang;
            this.Macn = macn;
            this.Madt = madt;
        }

        public string Mabb { get => mabb; set => mabb = value; }
        public string Tenbb { get => tenbb; set => tenbb = value; }
        public string Tacgia { get => tacgia; set => tacgia = value; }
        public string Ngaydang { get => ngaydang; set => ngaydang = value; }
        public string Macn { get => macn; set => macn = value; }
        public string Madt { get => madt; set => madt = value; }
    }
}
