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
    public partial class TTDeTai_PD : Form
    {
        string madt;
        public TTDeTai_PD()
        {
            InitializeComponent();
        }
        public TTDeTai_PD(string madt)
        {
            InitializeComponent();
            this.madt = madt;
        }
        Modify modify = new Modify();
        private void TTDeTai_PD_Load(object sender, EventArgs e)
        {
            dataDeTai.DataSource = modify.Table("Chitiet_DT'"+madt+"'");
        }
    }
}
