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
    public partial class TTDeTai_TB : Form
    {
        string matb;
        Modify modify = new Modify();
        public TTDeTai_TB()
        {
            InitializeComponent();
        }
        public TTDeTai_TB(string matb)
        {
            InitializeComponent();
            this.matb = matb;
        }

        private void TTDeTai_TB_Load(object sender, EventArgs e)
        {
            modify = new Modify();

            try
            {
                dataDT.DataSource = modify.Table("DT_TB'" + matb + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDT.Rows.Count > 1)
            {
                txtMaTV.Text = dataDT.SelectedRows[0].Cells[0].Value.ToString();
                txtTenTV.Text = dataDT.SelectedRows[0].Cells[1].Value.ToString();
                txtCT.Text = dataDT.SelectedRows[0].Cells[2].Value.ToString();
                txtHocVi.Text = dataDT.SelectedRows[0].Cells[3].Value.ToString();
                txTcb.Text = dataDT.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
