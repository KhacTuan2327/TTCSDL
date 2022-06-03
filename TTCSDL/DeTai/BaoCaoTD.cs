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
    public partial class BaoCaoTD : Form
    {
        string madt;
        Modify modify = new Modify();
        baocao Baocao;
        public BaoCaoTD()
        {
            InitializeComponent();
        }
        public BaoCaoTD(string madt)
        {
            InitializeComponent();
            this.madt = madt;
        }

        private void dtDsbc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dtDsbc.Rows.Count > 1)
            {
                txtmabc.Text = dtDsbc.SelectedRows[0].Cells[0].Value.ToString();
                txtnd.Text = dtDsbc.SelectedRows[0].Cells[1].Value.ToString();
                txttd.Text = dtDsbc.SelectedRows[0].Cells[2].Value.ToString();
                timebc.Text = dtDsbc.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        private void DeleteTextBoxs()
        {
            txtmabc.Text = "";
            txtnd.Text = "";
            txttd.Text = "";
            timebc.Value = DateTime.Now;
        }

        private void GetValuesTextBox()
        {
            string mabc = this.txtmabc.Text;
            string ndbc = this.txtnd.Text;
            string td = this.txttd.Text;
            string ngaybc = this.timebc.Text;
            string madt = this.madt;
            Baocao = new baocao(mabc, ndbc, td, ngaybc, madt);
        }

        private bool CheckTextBoxes()
        {
            if (txtnd.Text == "") { MessageBox.Show("Vui lòng nhập nội dung báo cáo!"); return false; }
            if (txttd.Text == "") { MessageBox.Show("Vui lòng nhập tiến độ!"); return false; }
            if (timebc.Value == DateTime.Now) { MessageBox.Show("Vui lòng nhập thời gian báo cáo!"); return false; }
            return true;
        }

        private void btnAddBc_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBox();
                string query = "INSERT INTO BAOCAOTIENDO VALUES('',N'" + Baocao.Nd + "','" + Baocao.Tdo + "','" + Baocao.Ngaybc + "','" + Baocao.Madt + "')";
                //
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm vào không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm thành công!");
                        BaoCaoTD_Load(sender, e);
                        DeleteTextBoxs();
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm vào: " + ex.Message);
                }
            }
        }

        private void btnDltDT_Click(object sender, EventArgs e)
        {
            if (dtDsbc.Rows.Count > 1)
            {
                string choose = dtDsbc.SelectedRows[0].Cells[0].Value.ToString();
                string query = "XOA_BC '" + choose + "'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa thành công!");
                        BaoCaoTD_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtDsbc.Rows.Count > 1)
            {
                GetValuesTextBox();
                string choose = dtDsbc.SelectedRows[0].Cells[0].Value.ToString();
                string query = "UPDATE BAOCAOTIENDO SET NOIDUNG = '" + Baocao.Nd+ "',TIENDO = '" + Baocao.Tdo + "',NGAYBAOCAO = '" + Baocao.Ngaybc + "' WHERE MABC = '" + choose + "'";
                try //insert into khoa value ('khoa.Id', "N'Khoa.name'"
                {
                    if (MessageBox.Show("Bạn có muốn lưu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Lưu thành công!");
                        BaoCaoTD_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void BaoCaoTD_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            // Hiện bảng
            try
            {
                dtDsbc.DataSource = modify.Table("BC_DT'" + madt + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
