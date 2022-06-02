
using System;

namespace TTCSDL
{
    partial class ThongTin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnChuyenNganh = new Guna.UI2.WinForms.Guna2Button();
            this.btnTB = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapQL = new Guna.UI2.WinForms.Guna2Button();
            this.btncn = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnlNav = new Guna.UI2.WinForms.Guna2Panel();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Teal;
            this.panelLeft.BorderColor = System.Drawing.Color.White;
            this.panelLeft.BorderRadius = 1;
            this.panelLeft.BorderThickness = 3;
            this.panelLeft.Controls.Add(this.pnlNav);
            this.panelLeft.Controls.Add(this.btnChuyenNganh);
            this.panelLeft.Controls.Add(this.btnTB);
            this.panelLeft.Controls.Add(this.btnKhoa);
            this.panelLeft.Controls.Add(this.btnCapQL);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1560, 54);
            this.panelLeft.TabIndex = 0;
            // 
            // btnChuyenNganh
            // 
            this.btnChuyenNganh.BackColor = System.Drawing.Color.Turquoise;
            this.btnChuyenNganh.BorderRadius = 5;
            this.btnChuyenNganh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyenNganh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyenNganh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChuyenNganh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuyenNganh.FillColor = System.Drawing.Color.Teal;
            this.btnChuyenNganh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenNganh.ForeColor = System.Drawing.Color.White;
            this.btnChuyenNganh.Location = new System.Drawing.Point(685, 5);
            this.btnChuyenNganh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChuyenNganh.Name = "btnChuyenNganh";
            this.btnChuyenNganh.Size = new System.Drawing.Size(198, 39);
            this.btnChuyenNganh.TabIndex = 3;
            this.btnChuyenNganh.Text = "Chuyên ngành";
            this.btnChuyenNganh.Click += new System.EventHandler(this.btnChuyenNganh_Click);
            this.btnChuyenNganh.Leave += new System.EventHandler(this.btnChuyenNganh_Leave);
            // 
            // btnTB
            // 
            this.btnTB.BackColor = System.Drawing.Color.Turquoise;
            this.btnTB.BorderRadius = 5;
            this.btnTB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTB.FillColor = System.Drawing.Color.Teal;
            this.btnTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTB.ForeColor = System.Drawing.Color.White;
            this.btnTB.Location = new System.Drawing.Point(479, 5);
            this.btnTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTB.Name = "btnTB";
            this.btnTB.Size = new System.Drawing.Size(198, 39);
            this.btnTB.TabIndex = 2;
            this.btnTB.Text = "Tiểu Ban";
            this.btnTB.Click += new System.EventHandler(this.btnTB_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.BackColor = System.Drawing.Color.Turquoise;
            this.btnKhoa.BorderRadius = 5;
            this.btnKhoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhoa.FillColor = System.Drawing.Color.Teal;
            this.btnKhoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoa.ForeColor = System.Drawing.Color.White;
            this.btnKhoa.Location = new System.Drawing.Point(68, 8);
            this.btnKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.PressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnKhoa.Size = new System.Drawing.Size(198, 36);
            this.btnKhoa.TabIndex = 0;
            this.btnKhoa.Text = "Khoa";
            this.btnKhoa.Click += new System.EventHandler(this.btnDeTai_Click);
            this.btnKhoa.Leave += new System.EventHandler(this.btnDeTai_Leave);
            // 
            // btnCapQL
            // 
            this.btnCapQL.BackColor = System.Drawing.Color.Turquoise;
            this.btnCapQL.BorderRadius = 5;
            this.btnCapQL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapQL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapQL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapQL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapQL.FillColor = System.Drawing.Color.Teal;
            this.btnCapQL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapQL.ForeColor = System.Drawing.Color.White;
            this.btnCapQL.Location = new System.Drawing.Point(273, 5);
            this.btnCapQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapQL.Name = "btnCapQL";
            this.btnCapQL.Size = new System.Drawing.Size(198, 39);
            this.btnCapQL.TabIndex = 1;
            this.btnCapQL.Text = "Cấp Quản Lý";
            this.btnCapQL.Click += new System.EventHandler(this.btnCapQL_Click);
            this.btnCapQL.Leave += new System.EventHandler(this.btnCapQL_Leave);
            // 
            // btncn
            // 
            this.btncn.BackColor = System.Drawing.Color.White;
            this.btncn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncn.Location = new System.Drawing.Point(0, 54);
            this.btncn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncn.Name = "btncn";
            this.btncn.Size = new System.Drawing.Size(1560, 888);
            this.btncn.TabIndex = 2;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.White;
            this.pnlNav.Location = new System.Drawing.Point(68, 8);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(198, 6);
            this.pnlNav.TabIndex = 0;
            // 
            // ThongTin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1560, 942);
            this.Controls.Add(this.btncn);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThongTin";
            this.Text = "ThongTin";
            this.Load += new System.EventHandler(this.ThongTin_Load);
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelLeft;
        private Guna.UI2.WinForms.Guna2GradientPanel btncn;
        private Guna.UI2.WinForms.Guna2Button btnTB;
        private Guna.UI2.WinForms.Guna2Button btnCapQL;
        private Guna.UI2.WinForms.Guna2Button btnKhoa;
        private EventHandler thongTin_Load;

        public EventHandler GetThongTin_Load()
        {
            return thongTin_Load;
        }

        private void SetThongTin_Load(EventHandler value)
        {
            thongTin_Load = value;
        }
        private Guna.UI2.WinForms.Guna2Button btnChuyenNganh;
        private Guna.UI2.WinForms.Guna2Panel pnlNav;
    }
}