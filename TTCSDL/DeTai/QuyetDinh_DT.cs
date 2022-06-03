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
    public partial class QuyetDinh_DT : Form
    {
        string madt;
        Modify modify = new Modify();
        quyetdinh QD;
        public QuyetDinh_DT()
        {
            InitializeComponent();
        }
        public QuyetDinh_DT(string madt)
        {
            InitializeComponent();
            this.madt = madt;
        }

        private void dtDsbc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtDsbc.Rows.Count > 1)
            {
                txtmabc.Text = dtDsbc.SelectedRows[0].Cells[0].Value.ToString();
                txttd.Text = dtDsbc.SelectedRows[0].Cells[1].Value.ToString();
                txtnd.Text = dtDsbc.SelectedRows[0].Cells[2].Value.ToString();
                timebc.Text = dtDsbc.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void QuyetDinh_DT_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            // Hiện bảng
            try
            {
                dtDsbc.DataSource = modify.Table("QD_DT'" + madt + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            QD = new quyetdinh(mabc,  td, ndbc, ngaybc, madt);
        }

        private bool CheckTextBoxes()
        {
            if (txtnd.Text == "") { MessageBox.Show("Vui lòng nhập nội dung quyết định!"); return false; }
            if (txttd.Text == "") { MessageBox.Show("Vui lòng nhập tên quyết định!"); return false; }
            if (timebc.Value == DateTime.Now) { MessageBox.Show("Vui lòng nhập thời gian ban hành!"); return false; }
            return true;
        }

        private void btnAddDT_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBox();
                string query = "INSERT INTO QUYETDINH VALUES('',N'" + QD.Name + "','" + QD.Nd + "','" + QD.Ngaybh + "','" + QD.Madt + "')";
                //
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm vào không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm thành công!");
                        QuyetDinh_DT_Load(sender, e);
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
                string query = "XOA_QD '" + choose + "'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa thành công!");
                        QuyetDinh_DT_Load(sender, e);
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
                string query = "UPDATE QUYETDINH SET NOIDUNG = '" + QD.Nd + "',TENQD = '" + QD.Name + "',NGAYBANHANH = '" + QD.Ngaybh + "' WHERE MAQD = '" + choose + "'";
                try //insert into khoa value ('khoa.Id', "N'Khoa.name'"
                {
                    if (MessageBox.Show("Bạn có muốn lưu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Lưu thành công!");
                        QuyetDinh_DT_Load(sender, e);
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
