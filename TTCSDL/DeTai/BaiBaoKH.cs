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
        baibao Baibao;
        public BaiBaoKH()
        {
            InitializeComponent();
        }
        public BaiBaoKH(string madt)
        {
            InitializeComponent();
            this.madt = madt;
        }
        Modify modify = new Modify();
        private void BaiBaoKH_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            // Hiện bảng
            try
            {
                dtDsBaiBao.DataSource = modify.Table("BB_DT'" + madt + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtDsBaiBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtDsBaiBao.Rows.Count > 1)
            {
                txtMabb.Text = dtDsBaiBao.SelectedRows[0].Cells[0].Value.ToString();
                txttenbb.Text = dtDsBaiBao.SelectedRows[0].Cells[1].Value.ToString();
                txttacgia.Text = dtDsBaiBao.SelectedRows[0].Cells[4].Value.ToString();
                txtmanganh.SelectedItem = dtDsBaiBao.SelectedRows[0].Cells[2].Value.ToString();
                timedang.Text = dtDsBaiBao.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        private void DeleteTextBoxs()
        {
            txtMabb.Text = "";
            txttenbb.Text = "";
            txttacgia.Text = "";
            timedang.Value = DateTime.Now;
            txtmanganh.Text = "";
        }

        private void GetValuesTextBox()
        {
            string mabb = this.txtMabb.Text;
            string tenbb = this.txttenbb.Text;
            string tacgia = this.txttacgia.Text;
            string ngaydang = this.timedang.Text;
            string macn = this.txtmanganh.Text;
            string madt = this.madt;
            Baibao = new baibao(mabb, tenbb, tacgia, ngaydang, macn,madt);
        }

        private bool CheckTextBoxes()
        {
            //if (txtMabb.Text == "") { MessageBox.Show("Vui lòng nhập mã của bài báo!"); return false; }
            if (txttenbb.Text == "") { MessageBox.Show("Vui lòng nhập tên của bài báo!"); return false; }
            if (txttacgia.Text == "") { MessageBox.Show("Vui lòng nhập tác giả!"); return false; }
            if (timedang.Text == "") { MessageBox.Show("Vui lòng nhập thời gian đăng!"); return false; }
            if (txtmanganh.Text == "") { MessageBox.Show("Vui lòng nhập mã ngành!"); return false; }
            return true;
        }

        private void btnAddBB_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                //'" + Baibao.Mabb + "'
                GetValuesTextBox();
                string query = "INSERT INTO CONGTRINHNGHIENCUU VALUES ('',N'" + Baibao.Tenbb + "','" + Baibao.Macn + "','" + Baibao.Ngaydang + "',N'" + Baibao.Tacgia + "','" + Baibao.Madt + "')";
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm vào không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm thành công!");
                        BaiBaoKH_Load(sender, e);
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
            if (dtDsBaiBao.Rows.Count > 1)
            {
                string choose = dtDsBaiBao.SelectedRows[0].Cells[0].Value.ToString();
                string query = "XOA_BB '"+choose+"'";
                try 
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa thành công!");
                        BaiBaoKH_Load(sender, e);
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
            if (dtDsBaiBao.Rows.Count > 1)
            {
                GetValuesTextBox();
                string choose = dtDsBaiBao.SelectedRows[0].Cells[0].Value.ToString();
                string query = "UPDATE CONGTRINHNGHIENCUU SET TENBB = '" +Baibao.Tenbb + "',MANGANH = '" + Baibao.Macn + "',NGAYDANG = '" + Baibao.Ngaydang + "',TACGIA = '" + Baibao.Tacgia + "' WHERE MABB = '" + choose + "'";
                try //insert into khoa value ('khoa.Id', "N'Khoa.name'"
                {
                    if (MessageBox.Show("Bạn có muốn lưu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Lưu thành công!");
                        BaiBaoKH_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
