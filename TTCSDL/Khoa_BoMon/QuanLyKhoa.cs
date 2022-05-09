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
    public partial class QuanLyKhoa : Form
    {
        public QuanLyKhoa()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        Khoa khoa;


        private void QuanLyKhoa_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            // Hiện bảng
            try
            {
                dataKhoa.DataSource = modify.Table("Select * from KHOA");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTextBoxs()
        {
            txtmakhoa.Text = "";
            txttenkhoa.Text = "";
            txtdiachi.Text = "";
            txtchunhiem.Text = "";
            txtsdt.Text = "";
        }

        private bool CheckTextBoxes()
        {
            if(txtmakhoa.Text == "") { MessageBox.Show("Vui lòng nhập Mã Khoa!");return false; }
            if(txttenkhoa.Text == "") { MessageBox.Show("Vui lòng nhập Tên Khoa!");return false; }
            if (txtdiachi.Text == "") { MessageBox.Show("Vui lòng nhập Địa Chỉ!"); return false; }
            if (txtchunhiem.Text == "") { MessageBox.Show("Vui lòng nhập Chủ Nhiệm!"); return false; }
            if (txtsdt.Text == "") { MessageBox.Show("Vui lòng nhập Số Điện Thoại!"); return false; }
            return true;
        }

        private void GetValuesTextBox()
        {
            string id = this.txtmakhoa.Text;
            string name = this.txttenkhoa.Text;
            string address = this.txtdiachi.Text;
            string boss = this.txtchunhiem.Text;
            string phone = this.txtsdt.Text;
            khoa = new Khoa(id, name, address, boss, phone);
        }

       

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBox();
                string query = "INSERT INTO KHOA VALUES (N'" + khoa.Id + "', N' " + khoa.Name + "',N'" + khoa.Address + "',N'" + khoa.Boss + "',N'" +  khoa.Phone + "')";
                //string query = "insert into KHOA values (N'" + "'khoa.Id'" + ",N " + "khoa.Name", N'Hải Phòng', N'Trần Xuân Nam', 0123465433)
                try 
                {
                    if (MessageBox.Show("Bạn có muốn thêm vào không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm thành công!");
                        QuanLyKhoa_Load(sender, e);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi thêm vào: " + ex.Message);
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBox();
                string query = "UPDATE KHOA SET TENKHOA = N'" + khoa.Name + " ', DIACHI = N'" + khoa.Address + " ', CHUNHIEM = N' " + khoa.Boss + "', SĐT = N'" + khoa.Phone + "'";
                query += "Where MAKHOA = N'" + khoa.Id + " '";
                //string query = "insert into KHOA values (N'" + "'khoa.Id'" + ",N " + "khoa.Name", N'Hải Phòng', N'Trần Xuân Nam', 0123465433)
                try //insert into khoa value ('khoa.Id', "N'Khoa.name'"
                {
                    if (MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa thành công!");
                        QuanLyKhoa_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa: " + ex.Message);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(dataKhoa.Rows.Count > 1)
            {
                string choose = dataKhoa.SelectedRows[0].Cells[1].Value.ToString();
                string query = "DELETE KHOA ";
                query += "WHERE MAKHOA = '" + choose + "'";
               
                    try //insert into khoa value ('khoa.Id', "N'Khoa.name'"
                    {
                        if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            modify.Command(query);
                            MessageBox.Show("Xóa thành công!");
                            QuanLyKhoa_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa: " + ex.Message);
                    }
            }
            
        }

        private void dataKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Xử lý sự kiện hiện dữ liệu lên bảng
        private void dataKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataKhoa.Rows.Count > 1)
            {
                txtmakhoa.Text = dataKhoa.SelectedRows[0].Cells[1].Value.ToString();
                txttenkhoa.Text = dataKhoa.SelectedRows[0].Cells[2].Value.ToString();
                txtdiachi.Text = dataKhoa.SelectedRows[0].Cells[3].Value.ToString();
                txtchunhiem.Text = dataKhoa.SelectedRows[0].Cells[4].Value.ToString();
                txtsdt.Text = dataKhoa.SelectedRows[0].Cells[5].Value.ToString();
            }
        }


        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
