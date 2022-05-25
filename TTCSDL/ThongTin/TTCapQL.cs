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
    public partial class TTCapQL : Form
    {
        public TTCapQL()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        CapQl cap;
        private void TTCapQL_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataCQL.DataSource = modify.Table("Select * from CAPQUANLY");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataCQL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataCQL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataCQL.Rows.Count > 1)
            {
                txtMaCap.Text = dataCQL.SelectedRows[0].Cells[0].Value.ToString();
                txtTenCap.Text = dataCQL.SelectedRows[0].Cells[1].Value.ToString();
                txtMoTa.Text = dataCQL.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
    }
}
