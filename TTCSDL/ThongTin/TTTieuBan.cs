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
    public partial class TTTieuBan : Form
    {
        public TTTieuBan()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void dataTB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataTB.Rows.Count > 1)
            {
                txtMaTB.Text = dataTB.SelectedRows[0].Cells[1].Value.ToString();
                txtTenTB.Text = dataTB.SelectedRows[0].Cells[2].Value.ToString();
                txtLinhVuc.Text = dataTB.SelectedRows[0].Cells[3].Value.ToString();
                txtSDT.Text = dataTB.SelectedRows[0].Cells[4].Value.ToString();
                txtTruongTB.Text = dataTB.SelectedRows[0].Cells[5].Value.ToString();
                txtSDT.Text = dataTB.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void TTTieuBan_Load(object sender, EventArgs e)
        {
            modify = new Modify();

            try
            {
                dataTB.DataSource = modify.Table("Select * from TIEUBAN");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
