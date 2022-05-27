using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL
{
    internal class Khoa
    {
        private string id;
        private string name;
        private string address;
        private string boss;
        private string phone;

        public Khoa()
        {
        }

        public Khoa(string id, string name, string address, string boss, string phone)
        {
            this.Id = id;
            this.name = name;
            this.address = address;
            this.boss = boss;
            this.phone = phone;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Boss { get => boss; set => boss = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}