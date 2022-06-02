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
    public partial class ChuyenNganh : Form
    {
        public ChuyenNganh()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void dataCQL_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataCQL.Rows.Count > 1)
            {
                txtMaCap.Text = dataCQL.SelectedRows[0].Cells[0].Value.ToString();
                txtTenCap.Text = dataCQL.SelectedRows[0].Cells[1].Value.ToString();
                txtMoTa.Text = dataCQL.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void ChuyenNganh_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataCQL.DataSource = modify.Table("Select * from CHUYENNGANH");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
