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
    public partial class NhanSu_User : Form
    {
        string makhoa = "", quyen = "";
        Modify modify = new Modify();
        public NhanSu_User()
        {
            InitializeComponent();
        }

        private void NhanSu_User_Load(object sender, EventArgs e)
        {
            modify = new Modify();

            try
            {
                dataDeTai.DataSource = modify.Table("HT_CB");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataDeTai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string gt;
            if (dataDeTai.Rows.Count > 1)
            {
                txtmacb.Text = dataDeTai.SelectedRows[0].Cells[0].Value.ToString();
                txttencb.Text = dataDeTai.SelectedRows[0].Cells[1].Value.ToString();
                gt = dataDeTai.SelectedRows[0].Cells[3].Value.ToString();
                if (gt == "Nam")
                {
                    rdoNam.Checked = true;
                    rdoNu.Checked = false;
                }
                else
                {
                    rdoNu.Checked = true;
                    rdoNam.Checked = false;
                }
                NgaySinh.Text = dataDeTai.SelectedRows[0].Cells[2].Value.ToString();
                txtcapbac.Text = dataDeTai.SelectedRows[0].Cells[4].Value.ToString();
                txtchucvu.Text = dataDeTai.SelectedRows[0].Cells[5].Value.ToString();
                txtsdt.Text = dataDeTai.SelectedRows[0].Cells[6].Value.ToString();
                txtbomon.Text = dataDeTai.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        public NhanSu_User(string makhoa, string quyen)
        {
            InitializeComponent();
            this.makhoa = makhoa;
            this.quyen = quyen;
        }
    }
}
