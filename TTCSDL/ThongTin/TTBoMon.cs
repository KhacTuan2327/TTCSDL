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
    public partial class TTBoMon : Form
    {
        public TTBoMon()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        string makhoa = "";

        public TTBoMon(string makhoa)
        {
            InitializeComponent();
            this.makhoa = makhoa;
        }

        private void dataDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TTBoMon_Load(object sender, EventArgs e)
        {
            modify = new Modify();

            try
            {
                dataDT.DataSource = modify.Table("SELECT MABM as 'Mã bộ môn', TENBM as 'Tên bộ môn', DIACHI as 'Địa chỉ',  SDT as 'Số điện thoại', CHUNHIEMBM as 'Chủ nhiệm bộ môn' FROM BOMON where MAKHOA = N'" + makhoa+"'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDT.Rows.Count > 1)
            {
                txtMaBoMon.Text = dataDT.SelectedRows[0].Cells[0].Value.ToString();
                txtTenBoMon.Text = dataDT.SelectedRows[0].Cells[1].Value.ToString();
                txtDiaChi.Text = dataDT.SelectedRows[0].Cells[2].Value.ToString();
                txtSDT.Text = dataDT.SelectedRows[0].Cells[3].Value.ToString();
                txtChuNhiem.Text = dataDT.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
