using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace TTCSDL
{
    public partial class ThongTin : Form
    {
        public ThongTin()
        {
            InitializeComponent();
        }

        private void setBackColorMenuItem(Panel pnl, Guna2Button btn)
        {
            pnl.BackColor = Color.White;
            pnl.Width = btn.Width;
            pnl.Left = btn.Left;
            btn.BackColor = Color.CadetBlue;
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
            setBackColorMenuItem(pnlNav, btnCapQL);
        }

        private void btnDeTai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeTai1());
            setBackColorMenuItem(pnlNav, btnKhoa);
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TTTieuBan());
            setBackColorMenuItem(pnlNav, btnTB);
        }

        private void ThongTin_Load(object sender, EventArgs e)
        {
            btnDeTai_Click(sender, e);
        }

        private void btnDeTai_Leave(object sender, EventArgs e)
        {
            btnKhoa.BackColor = Color.Teal;
        }

        private void btnCapQL_Leave(object sender, EventArgs e)
        {
            btnCapQL.BackColor = Color.Teal;
        }

    }
}
