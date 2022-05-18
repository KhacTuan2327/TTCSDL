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
    public partial class ThongTin : Form
    {
        public ThongTin()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(ChildForm);
            panelBody.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }


        private void btnCapQL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TTCapQL());
            btnCapQL.BackColor = Color.CadetBlue;
        }

        private void btnDeTai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeTai1());
            btnDeTai.BackColor = Color.CadetBlue;
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TTTieuBan());
            btnTB.BackColor = Color.CadetBlue;
        }

        private void ThongTin_Load(object sender, EventArgs e)
        {
            btnDeTai_Click(sender, e);
        }

        private void btnDeTai_Leave(object sender, EventArgs e)
        {
            btnDeTai.BackColor = Color.Teal;
        }

        private void btnCapQL_Leave(object sender, EventArgs e)
        {
            btnCapQL.BackColor = Color.Teal;
        }

        private void guna2Button1_Leave(object sender, EventArgs e)
        {
            guna2Button1.BackColor = Color.Teal;
        }
    }
}
