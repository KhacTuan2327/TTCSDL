using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL
{
    internal class BoMon
    {
        private string id;
        private string name;
        private string address;
        private string boss;
        private string phone;
        private string idKhoa;
        private string idCBo;

        public BoMon()
        {
        }

        public BoMon(string id, string name, string address, string boss, string phone, string idKhoa, string idCBo)
        {
            this.Id = id;
            this.name = name;
            this.address = address;
            this.boss = boss;
            this.phone = phone;
            this.idKhoa = idKhoa;
            this.idCBo = idCBo;
        }

        public string Id { get => id; set => id = value; }
    }
}
