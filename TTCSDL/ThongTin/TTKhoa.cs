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
        DataTable dt = new DataTable();

        private void dataDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DeTai1_Load(object sender, EventArgs e)
        {
            modify = new Modify();

            try
            {
                dt = modify.Table("SELECT MAKHOA as 'Mã khoa', TENKHOA as 'Tên khoa', DIACHI as 'Địa chỉ', SDT as 'Số điện thoại', CHUNHIEM as 'Chủ nhiệm khoa' FROM KHOA");
                dataDT.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDsBm_Click(object sender, EventArgs e)
        {
            TTBoMon boMon = new TTBoMon(txtMaKhoa.Text);
            boMon.ShowDialog();
        }

        private void dataDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDT.Rows.Count > 1)
            {
                txtMaKhoa.Text = dataDT.SelectedRows[0].Cells[0].Value.ToString();
                txtTenKhoa.Text = dataDT.SelectedRows[0].Cells[1].Value.ToString();
                txtDiaChi.Text = dataDT.SelectedRows[0].Cells[2].Value.ToString();
                txtSDT.Text = dataDT.SelectedRows[0].Cells[3].Value.ToString();
                txtChuNhiem.Text = dataDT.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
