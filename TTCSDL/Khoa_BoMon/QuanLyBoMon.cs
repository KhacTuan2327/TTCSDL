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
    public partial class QuanLyBoMon : Form
    {
        public QuanLyBoMon()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        BoMon bomon; 

        private void QuanLyBoMon_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            // Hiện bảng
            try
            {
                databomon.DataSource = modify.Table("Select * from BOMON");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetValuesTextBox()
        {
            string mabm = this.txtmabm.Text;
            string tenbm = this.txttenbm.Text;
            string diachi = this.txtdiachi.Text;
            string makhoa = this.txtmakhoa.Text;
            string sdt = this.txtsodienthoai.Text;
            string macn = this.txtmacn.Text;
            string tencn = this.txttencn.Text;
            bomon = new BoMon(mabm, tenbm, diachi, makhoa, sdt, macn, tencn);
        }



        private void databomon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txtmabm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmachunhiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmacn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }
    }
}
