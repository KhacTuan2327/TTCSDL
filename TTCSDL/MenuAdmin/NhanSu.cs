using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace TTCSDL
{
    public partial class NhanSu : Form
    {
        public NhanSu()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        nhansu Nhansu;

        private void NhanSu_Load(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            try
            {
                datanhansu.DataSource = modify.Table("Select MACB as 'Mã cán bộ', TENCB as 'Họ và tên', NGAYSINH as 'Ngày sinh', GIOITINH as 'Giới tính', CAPBAC as 'Cấp bậc', CHUCVU as 'Chức vụ', SĐT as 'Số điện thoại', MABM as 'Mã bộ môn' from CANBO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void export2Excel(DataGridView g, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                export2Excel(datanhansu, saveFileDialog1.FileName);
            }
        }

        private void addPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFile.FileName;
            }
        }
        private void DeleteTextBoxs()
        {
            txtmacanbo.Text = "";
            txttencanbo.Text = "";
            txtcapbac.Text = "";
            txtchucvu.Text = "";
            txtPhone.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            txtPhone.Text = "";
            txtmabm.Text = "";
            NgaySinh.Value = DateTime.Now;
        }
        private bool CheckTextBoxes()
        {
            if (txtmacanbo.Text == "") { MessageBox.Show("Vui lòng nhập Mã cán bộ!"); return false; }
            if (txttencanbo.Text == "") { MessageBox.Show("Vui lòng nhập Tên cán bộ!"); return false; }
            if (txtcapbac.Text == "") { MessageBox.Show("Vui lòng nhập cấp bậc!"); return false; }
            if (txtchucvu.Text == "") { MessageBox.Show("Vui lòng nhập chức vụ!"); return false; }
            if (txtPhone.Text == "") { MessageBox.Show("Vui lòng nhập Số Điện Thoại!"); return false; }
            if (txtmabm.Text == "") { MessageBox.Show("Vui lòng nhập Mã bộ môn!"); return false; }
            if (rdoNam.Checked == false && rdoNu.Checked == false) { MessageBox.Show("Vui lòng nhập giới tính!"); return false; }
            return true;
        }
        private void GetValuesTextBox()
        {
            string id = this.txtmacanbo.Text;
            string name = this.txttencanbo.Text;
            string cb = this.txtcapbac.Text;
            string cv = this.txtchucvu.Text;
            string sdt = this.txtPhone.Text;
            string mabm = this.txtmabm.Text;
            string ns = this.NgaySinh.Text;
            string a;
            if (rdoNam.Checked == true)
            {
                a = rdoNam.Text;
            }
            else
            {
                a = rdoNu.Text;
            }
            string gt = a;
            Nhansu = new nhansu(id, name, ns, gt, cb, cv, sdt, mabm);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBox();
                string query = "INSERT INTO CANBO VALUES (N'" + Nhansu.Id + "', N' " + Nhansu.Name + "',N'" + Nhansu.Ns + "',N'" + Nhansu.Gt + "',N'" + Nhansu.Cb + "',N'" + Nhansu.Cv + "',N'" + Nhansu.Sdt + "',N'" + Nhansu.Mabm + "')";

                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm vào không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm thành công!");
                        NhanSu_Load(sender, e);
                        DeleteTextBoxs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm vào: " + ex.Message);
                }
            }
        }

        private void datanhansu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datanhansu.Rows.Count > 1)
            {
                txtmacanbo.Text = datanhansu.SelectedRows[0].Cells[0].Value.ToString();
                txttencanbo.Text = datanhansu.SelectedRows[0].Cells[1].Value.ToString();
                //string str;
                //DateTime.ParseExact(str, NgaySinh, null);

                NgaySinh.Text = datanhansu.SelectedRows[0].Cells[2].Value.ToString();

                string gt;
                if (rdoNam.Checked == true)
                {
                    gt = rdoNam.Text;
                }
                else
                {
                    gt = rdoNu.Text;
                }

                gt = datanhansu.SelectedRows[0].Cells[3].Value.ToString();
                if(gt == "Nam")
                {
                    rdoNam.Checked = true;
                    rdoNu.Checked = false;
                }
                else
                {
                    rdoNu.Checked = true;
                    rdoNam.Checked = false;
                }
                txtcapbac.Text = datanhansu.SelectedRows[0].Cells[4].Value.ToString();
                txtchucvu.Text = datanhansu.SelectedRows[0].Cells[5].Value.ToString();
                txtPhone.Text = datanhansu.SelectedRows[0].Cells[6].Value.ToString();
                txtmabm.Text = datanhansu.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (datanhansu.Rows.Count > 1)
            {
                string choose = datanhansu.SelectedRows[0].Cells[0].Value.ToString();
                string query = "XOA_CANBO";
                query += "'" + choose + "'";

                try //insert into khoa value ('khoa.Id', "N'Khoa.name'"
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa thành công!");
                        NhanSu_Load(sender, e);
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
            //MACB AS 'Mã cán bộ' N' " + Nhansu.Id + "',TENCB AS 'Họ và tên' N' " + Nhansu.Name + "', NGAYSINH AS 'Ngày sinh' N'" + Nhansu.Ns + "',GIOITINH AS 'Giới tính' N'" + Nhansu.Gt + "',CAPBAC AS 'Cấp bậc' N'" + Nhansu.Cb + "', CHUCVU AS 'Cấp bậc' N'" + Nhansu.Cv + "',SĐT AS 'Số điện thoại' N'" + Nhansu.Tgtg + "',THOIGIANTHAMGIA AS 'Thời gian tham gia' N'" + Nhansu.Sdt + "',MABM AS 'Mã bộ môn' N'" + Nhansu.Mabm + "'
            if (datanhansu.Rows.Count > 1)
            {
                string choose = datanhansu.SelectedRows[0].Cells[0].Value.ToString();
                string query = "UPDATE CANBO SET TENCB = N'" + Nhansu.Name + " ', NGAYSINH = N'" + Nhansu.Ns + " ', GIOITINH = N' " + Nhansu.Gt + "', CAPBAC = N'" + Nhansu.Cb + "', CHUCVU = N'" + Nhansu.Cv + "',SĐT = N'" + Nhansu.Sdt + "',MABM = N'" + Nhansu.Mabm + "'";
                query += "Where MACB = N'" + choose + " '";

                try //insert into khoa value ('khoa.Id', "N'Khoa.name'"
                {
                    if (MessageBox.Show("Bạn có muốn lưu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Lưu thành công!");
                        NhanSu_Load(sender, e);
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
