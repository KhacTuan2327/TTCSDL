using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL
{
    internal class ForgotPassword
    {
        private string email;

        public ForgotPassword()
        {
        }

        public ForgotPassword(string email)
        {
            this.email = email;
        }

        public string Email { get => email; set => email = value; }
    }
}
