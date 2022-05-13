
namespace TTCSDL
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnPheDuyet = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnTke = new FontAwesome.Sharp.IconButton();
            this.btnNSu = new FontAwesome.Sharp.IconButton();
            this.btnDeTai = new FontAwesome.Sharp.IconButton();
            this.btnThongTin = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblLoad = new System.Windows.Forms.Label();
            this.pnlLoad = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnPheDuyet);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnTke);
            this.panel1.Controls.Add(this.btnNSu);
            this.panel1.Controls.Add(this.btnDeTai);
            this.panel1.Controls.Add(this.btnThongTin);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 768);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.White;
            this.pnlNav.Location = new System.Drawing.Point(0, 170);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 68);
            this.pnlNav.TabIndex = 1;
            // 
            // btnPheDuyet
            // 
            this.btnPheDuyet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPheDuyet.FlatAppearance.BorderSize = 0;
            this.btnPheDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPheDuyet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPheDuyet.ForeColor = System.Drawing.Color.White;
            this.btnPheDuyet.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnPheDuyet.IconColor = System.Drawing.Color.White;
            this.btnPheDuyet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPheDuyet.IconSize = 40;
            this.btnPheDuyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPheDuyet.Location = new System.Drawing.Point(0, 510);
            this.btnPheDuyet.Name = "btnPheDuyet";
            this.btnPheDuyet.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPheDuyet.Size = new System.Drawing.Size(219, 68);
            this.btnPheDuyet.TabIndex = 8;
            this.btnPheDuyet.Text = "Phê duyệt";
            this.btnPheDuyet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPheDuyet.UseVisualStyleBackColor = true;
            this.btnPheDuyet.Click += new System.EventHandler(this.btnPheDuyet_Click);
            this.btnPheDuyet.Leave += new System.EventHandler(this.btnPheDuyet_Leave);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 40;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 700);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(219, 68);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.Leave += new System.EventHandler(this.btnLogout_Leave);
            // 
            // btnTke
            // 
            this.btnTke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTke.FlatAppearance.BorderSize = 0;
            this.btnTke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTke.ForeColor = System.Drawing.Color.White;
            this.btnTke.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnTke.IconColor = System.Drawing.Color.White;
            this.btnTke.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTke.IconSize = 40;
            this.btnTke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTke.Location = new System.Drawing.Point(0, 442);
            this.btnTke.Name = "btnTke";
            this.btnTke.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTke.Size = new System.Drawing.Size(219, 68);
            this.btnTke.TabIndex = 6;
            this.btnTke.Text = "Thống kê";
            this.btnTke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTke.UseVisualStyleBackColor = true;
            this.btnTke.Click += new System.EventHandler(this.btnTke_Click);
            this.btnTke.Leave += new System.EventHandler(this.btnTke_Leave);
            // 
            // btnNSu
            // 
            this.btnNSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNSu.FlatAppearance.BorderSize = 0;
            this.btnNSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNSu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNSu.ForeColor = System.Drawing.Color.White;
            this.btnNSu.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnNSu.IconColor = System.Drawing.Color.White;
            this.btnNSu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNSu.IconSize = 40;
            this.btnNSu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNSu.Location = new System.Drawing.Point(0, 374);
            this.btnNSu.Name = "btnNSu";
            this.btnNSu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNSu.Size = new System.Drawing.Size(219, 68);
            this.btnNSu.TabIndex = 5;
            this.btnNSu.Text = "Nhân sự";
            this.btnNSu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNSu.UseVisualStyleBackColor = true;
            this.btnNSu.Click += new System.EventHandler(this.btnNSu_Click);
            this.btnNSu.Leave += new System.EventHandler(this.btnNSu_Leave);
            // 
            // btnDeTai
            // 
            this.btnDeTai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeTai.FlatAppearance.BorderSize = 0;
            this.btnDeTai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeTai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeTai.ForeColor = System.Drawing.Color.White;
            this.btnDeTai.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.btnDeTai.IconColor = System.Drawing.Color.White;
            this.btnDeTai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeTai.IconSize = 40;
            this.btnDeTai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeTai.Location = new System.Drawing.Point(0, 306);
            this.btnDeTai.Name = "btnDeTai";
            this.btnDeTai.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDeTai.Size = new System.Drawing.Size(219, 68);
            this.btnDeTai.TabIndex = 4;
            this.btnDeTai.Text = "Đề tài   ";
            this.btnDeTai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeTai.UseVisualStyleBackColor = true;
            this.btnDeTai.Click += new System.EventHandler(this.btnDeTai_Click);
            this.btnDeTai.Leave += new System.EventHandler(this.btnDeTai_Leave);
            // 
            // btnThongTin
            // 
            this.btnThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongTin.FlatAppearance.BorderSize = 0;
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.White;
            this.btnThongTin.IconChar = FontAwesome.Sharp.IconChar.Swatchbook;
            this.btnThongTin.IconColor = System.Drawing.Color.White;
            this.btnThongTin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongTin.IconSize = 40;
            this.btnThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTin.Location = new System.Drawing.Point(0, 238);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnThongTin.Size = new System.Drawing.Size(219, 68);
            this.btnThongTin.TabIndex = 3;
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongTin.UseVisualStyleBackColor = true;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            this.btnThongTin.Leave += new System.EventHandler(this.btnThongTin_Leave);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Teal;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 40;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 170);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(219, 68);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.Leave += new System.EventHandler(this.btnHome_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 170);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(219, 170);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblLoad);
            this.panel3.Controls.Add(this.guna2ControlBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(219, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1362, 44);
            this.panel3.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Teal;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1299, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(63, 44);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.ForeColor = System.Drawing.Color.White;
            this.lblLoad.Location = new System.Drawing.Point(29, 9);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(101, 28);
            this.lblLoad.TabIndex = 1;
            this.lblLoad.Text = "Trang chủ";
            // 
            // pnlLoad
            // 
            this.pnlLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoad.Location = new System.Drawing.Point(219, 44);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.Size = new System.Drawing.Size(1362, 724);
            this.pnlLoad.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 44);
            this.panel4.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1581, 768);
            this.Controls.Add(this.pnlLoad);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 190);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnTke;
        private FontAwesome.Sharp.IconButton btnNSu;
        private FontAwesome.Sharp.IconButton btnDeTai;
        private FontAwesome.Sharp.IconButton btnThongTin;
        private FontAwesome.Sharp.IconButton btnPheDuyet;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Panel pnlLoad;
        private System.Windows.Forms.Panel panel4;
    }
}