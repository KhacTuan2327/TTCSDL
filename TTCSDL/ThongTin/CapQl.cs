using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL
{
    class CapQl
    {
        private string maCap;
        private string tenCap;
        private string moTa;
        public CapQl()
        {

        }

        public CapQl(string maCap, string tenCap, string moTa)
        {
            this.maCap = maCap;
            this.tenCap = tenCap;
            this.moTa = moTa;
        }

        public string MaCap { get => maCap; set => maCap = value; }
        public string TenCap { get => tenCap; set => tenCap = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
