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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
            label9.Text = "Để thêm thành viên của đề tài mới đăng ký\nbạn chỉ cần thay đổi mã cán bộ thành mã của\ncán bộ cần thêm và nhấn nút Thêm thành viên";
        }
        Modify modify = new Modify();
        detai dt;
        string kq = " ";
        private void DeleteTextBoxs()
        {
            txtmadt.Text = "";
            txttendt.Text = "";
            txtkinhphi.Text = "";
            txtchudt.Text = "";
            txtnam.Text = "";
            txtnganh.Text = "";
            txttt.Text = "";
            timedk.Value = DateTime.Now;
            txttieuban.Text = "";
            txtcapql.Text = "";
        }

        private bool CheckTextBoxes()
        {
            //if (txtmadt.Text == "") { MessageBox.Show("Vui lòng nhập Mã Đề tài!"); return false; }
            if (txttendt.Text == "") { MessageBox.Show("Vui lòng nhập Tên Đề tài!"); return false; }
            if (txtnganh.Text == "") { MessageBox.Show("Vui lòng nhập Mã ngành!"); return false; }
            if (txtchudt.Text == "") { MessageBox.Show("Vui lòng nhập Chủ Nhiệm!"); return false; }
            return true;
        }

        private void GetValuesTextBox()
        {
            string madt = this.txtmadt.Text;
            string tendt = this.txttendt.Text;
            string kinhphi = this.txtkinhphi.Text;
            string chudt = this.txtchudt.Text;
            string nam = this.txtnam.Text;
            string ketqua = this.kq;
            string nganh = this.txtnganh.Text;
            string trangthai = this.txttt.Text;
            string ngaydangky = this.timedk.Text;
            string tieuban = this.txttieuban.Text;
            string capql = this.txtcapql.Text;
            dt = new detai(madt, tendt, kinhphi, ngaydangky, nam, tieuban, nganh, capql, chudt, trangthai, ketqua);
        }

        private void btnAddDT_Click(object sender, EventArgs e)
        {
            timedk.Value = DateTime.Now;
            string vaitro = "Chủ đề tài";
            if (CheckTextBoxes())
            {
                GetValuesTextBox();
                string query = "INSERT INTO DETAI VALUES ('', N'" + dt.Tendt + "', '" + dt.Kinhphi + "', '" + dt.Ngaydangky + "', '" + dt.Nam + "', '" + dt.Tieuban + "', '" + dt.Nganh + "', '" + dt.Capql + "', '" + dt.Chudt + "', N'" + dt.Trangthai + "', N'" + dt.Ketqua + "')";
                string querytg = "INSERT INTO THAMGIA VALUES('" + dt.Chudt + "','" + dt.Madt + "',N'" + vaitro + "','" + 0 + "')";
                try
                {
                    if (MessageBox.Show("Bạn có muốn đăng ký đề tài mới không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        try
                        {
                            modify.Command(querytg);
                            MessageBox.Show("Đề tài của bạn đã được đăng ký thành công và chờ quản trị Khoa phê duyệt!");
                            DangKy_Load(sender, e);
                        }
                        catch(Exception ex)
                        {
                            //MessageBox.Show("Cán bộ hiện không có trong danh sách, vui lòng kiểm tra lại hoặc truy cập quyền admin để thêm cán bộ!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm vào: " + ex.Message);
                }
            }
        }

        private void btnthemtv_Click(object sender, EventArgs e)
        {
            string vaitro = "Thành viên";
            GetValuesTextBox();
            string querytg = "INSERT INTO THAMGIA VALUES('" + dt.Chudt + "','" + dt.Madt + "',N'" + vaitro + "','" + 0 + "')";
            try
            {
                if (MessageBox.Show("Bạn có muốn thêm thành viên cho đề tài mới không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    modify.Command(querytg);
                    MessageBox.Show("Thêm thành viên cho đề tài thành công!");
                    DeleteTextBoxs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cán bộ hiện không có trong danh sách hoặc đề tài chưa được đăng ký, vui lòng kiểm tra lại!");
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            // Hiện bảng
            try
            {
                dataDeTai.DataSource = modify.Table("DK_DT");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataDeTai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDeTai.Rows.Count > 1)
            {
                txtmadt.Text = dataDeTai.SelectedRows[0].Cells[0].Value.ToString();
                txttendt.Text = dataDeTai.SelectedRows[0].Cells[1].Value.ToString();
                txtchudt.Text = dataDeTai.SelectedRows[0].Cells[8].Value.ToString();
                txttieuban.SelectedItem = dataDeTai.SelectedRows[0].Cells[5].Value.ToString();
                txtcapql.SelectedItem = dataDeTai.SelectedRows[0].Cells[7].Value.ToString();
                txtnganh.SelectedItem = dataDeTai.SelectedRows[0].Cells[6].Value.ToString();
                timedk.Text = dataDeTai.SelectedRows[0].Cells[3].Value.ToString();
                txtnam.Text = dataDeTai.SelectedRows[0].Cells[4].Value.ToString();
                txttt.Text = dataDeTai.SelectedRows[0].Cells[9].Value.ToString();
                txtkinhphi.Text = dataDeTai.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
    }
}
