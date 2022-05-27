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

        private void dataDeTai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDeTai.Rows.Count > 1)
            {
                txtmadt.Text = dataDeTai.SelectedRows[0].Cells[0].Value.ToString();
                txttendt.Text = dataDeTai.SelectedRows[0].Cells[1].Value.ToString();
                txtcndt.Text = dataDeTai.SelectedRows[0].Cells[2].Value.ToString();
                txtcapql.Text = dataDeTai.SelectedRows[0].Cells[3].Value.ToString();
                txtcn.Text = dataDeTai.SelectedRows[0].Cells[4].Value.ToString();
                txttb.Text = dataDeTai.SelectedRows[0].Cells[5].Value.ToString();
                ngaydk.Text = dataDeTai.SelectedRows[0].Cells[6].Value.ToString();
                txtnamth.Text = dataDeTai.SelectedRows[0].Cells[7].Value.ToString();
                txtkp.Text = dataDeTai.SelectedRows[0].Cells[8].Value.ToString();
                txttt.Text = dataDeTai.SelectedRows[0].Cells[9].Value.ToString();
                txtkq.Text = dataDeTai.SelectedRows[0].Cells[10].Value.ToString();
            }
        }
    }
}
