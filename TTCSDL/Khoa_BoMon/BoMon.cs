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
        private string phone;
        private string boss;
        private string idkhoa;
        private string bossid;

        public BoMon()
        {
        }

        public BoMon(string id, string name, string address, string phone, string boss, string idkhoa, string bossid)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.boss = boss;
            this.idkhoa = idkhoa;
            this.bossid = bossid;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Boss { get => boss; set => boss = value; }
        public string Idkhoa { get => idkhoa; set => idkhoa = value; }
        public string Bossid { get => bossid; set => bossid = value; }
    }
}
