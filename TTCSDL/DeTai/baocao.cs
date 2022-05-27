using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL
{
    class baocao
    {
        private string mabc;
        private string tdo;
        private string ngaybc;
        private string nd;
        private string madt;

        public baocao()
        {
        }

        public baocao(string mabc, string nd, string tdo, string ngaybc, string madt)
        {
            this.Mabc = mabc;
            this.Tdo = tdo;
            this.Ngaybc = ngaybc;
            this.Nd = nd;
            this.Madt = madt;
        }

        public string Mabc { get => mabc; set => mabc = value; }
        public string Tdo { get => tdo; set => tdo = value; }
        public string Ngaybc { get => ngaybc; set => ngaybc = value; }
        public string Nd { get => nd; set => nd = value; }
        public string Madt { get => madt; set => madt = value; }
    }
}
