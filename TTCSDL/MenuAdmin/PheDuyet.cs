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
    public partial class PheDuyet : Form
    {
        public PheDuyet()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        private void PheDuyet_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            menuTTItem.Visible = false;
            // Hiện bảng
            try
            {
                dataDeTai.DataSource = modify.Table("tt_detai_pd");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrangThai.Text == "Tất cả")
            {
                dataDeTai.DataSource = modify.Table("tt_detai_pd");
            }
            else if (cmbTrangThai.Text == "Đã duyệt")
            {
                dataDeTai.DataSource = modify.Table("tt_detai_dapd");
            }
            else if (cmbTrangThai.Text == "Chưa duyệt")
            {
                dataDeTai.DataSource = modify.Table("tt_detai_chuapd");
            }
        }

        private void dataDeTai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDeTai.Rows.Count > 1)
            {
                txtmadt.Text = dataDeTai.SelectedRows[0].Cells[0].Value.ToString();
                txtTenDT.Text = dataDeTai.SelectedRows[0].Cells[1].Value.ToString();
                txtChuDT.Text = dataDeTai.SelectedRows[0].Cells[2].Value.ToString();
                timedk.Text = dataDeTai.SelectedRows[0].Cells[3].Value.ToString();
                txtCNganh.Text = dataDeTai.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            menuTTItem.Visible = true;
        }

        private void btnTT_Leave(object sender, EventArgs e)
        {
            /*menuTTItem.Visible = false;*/
        }

        private void btnNsTg_Click(object sender, EventArgs e)
        {
            TTThanhVien_PD tTThanhVien_PD = new TTThanhVien_PD(txtmadt.Text);
            tTThanhVien_PD.ShowDialog();
        }

        private void btnDt_Click(object sender, EventArgs e)
        {
            TTDeTai_PD tTDeTai_PD = new TTDeTai_PD(txtmadt.Text);
            tTDeTai_PD.ShowDialog();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if(cmbTrangThai.Text == "Đã duyệt")
            {
                MessageBox.Show("Đề tài đã được duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(cmbTrangThai.Text == "Tất cả")
            {
                MessageBox.Show("Vui lòng lọc những đề tài chưa duyệt trước!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(cmbTrangThai.Text == "Chưa duyệt")
            {
                if (MessageBox.Show("Bạn muốn duyệt đề tài này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    modify.Command("pheduyet'"+txtmadt.Text+"'");
                    MessageBox.Show("Phê duyệt đề tài thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
