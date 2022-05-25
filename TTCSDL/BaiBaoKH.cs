using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCSDL
{
    public partial class BaiBaoKH : Form
    {
        string madt;
        public BaiBaoKH()
        {
            InitializeComponent();
        }
        public BaiBaoKH(string madt)
        {
            InitializeComponent();
            this.madt = madt;
        }

        private void BaiBaoKH_Load(object sender, EventArgs e)
        {

        }
    }
}
