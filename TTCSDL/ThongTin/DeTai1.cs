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
    public partial class DeTai1 : Form
    {
        public DeTai1()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        DeTai1 detai;

        private void dataDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDT.Rows.Count > 1)
            {
                txtMaDT.Text = dataDT.SelectedRows[0].Cells[0].Value.ToString();
                txtTenDT.Text = dataDT.SelectedRows[0].Cells[1].Value.ToString();
                txtKinhPhi.Text = dataDT.SelectedRows[0].Cells[2].Value.ToString();
                txtNgay.Text = dataDT.SelectedRows[0].Cells[3].Value.ToString();
                txtNam.Text = dataDT.SelectedRows[0].Cells[4].Value.ToString();
                txtMaTB.Text = dataDT.SelectedRows[0].Cells[5].Value.ToString();
                txtMaNganh.Text = dataDT.SelectedRows[0].Cells[6].Value.ToString();
                txtMaCap.Text = dataDT.SelectedRows[0].Cells[7].Value.ToString();
                txtMaCB.Text = dataDT.SelectedRows[0].Cells[8].Value.ToString();
                txtTrangThai.Text = dataDT.SelectedRows[0].Cells[9].Value.ToString();
            }
        }

        private void DeTai1_Load(object sender, EventArgs e)
        {
            modify = new Modify();

            try
            {
                dataDT.DataSource = modify.Table("SELECT * FROM DETAI");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
