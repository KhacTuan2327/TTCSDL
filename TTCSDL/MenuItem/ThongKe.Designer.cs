
namespace TTCSDL
{
    partial class ThongKe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnChuyenNganh = new System.Windows.Forms.Button();
            this.panelCapQuanLy = new System.Windows.Forms.Panel();
            this.btnCS = new System.Windows.Forms.Button();
            this.btnHV = new System.Windows.Forms.Button();
            this.btnBo = new System.Windows.Forms.Button();
            this.btnNN = new System.Windows.Forms.Button();
            this.btnCapQuanLy = new System.Windows.Forms.Button();
            this.panelDonVi = new System.Windows.Forms.Panel();
            this.btnBoMon = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnDonVi = new System.Windows.Forms.Button();
            this.dataTK = new Guna.UI.WinForms.GunaDataGridView();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel_main.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelCapQuanLy.SuspendLayout();
            this.panelDonVi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.panelMenu);
            this.panel_main.Controls.Add(this.dataTK);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1362, 718);
            this.panel_main.TabIndex = 1;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnChuyenNganh);
            this.panelMenu.Controls.Add(this.panelCapQuanLy);
            this.panelMenu.Controls.Add(this.btnCapQuanLy);
            this.panelMenu.Controls.Add(this.panelDonVi);
            this.panelMenu.Controls.Add(this.btnDonVi);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(264, 718);
            this.panelMenu.TabIndex = 68;
            // 
            // btnChuyenNganh
            // 
            this.btnChuyenNganh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChuyenNganh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenNganh.ForeColor = System.Drawing.Color.Teal;
            this.btnChuyenNganh.Location = new System.Drawing.Point(0, 374);
            this.btnChuyenNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChuyenNganh.Name = "btnChuyenNganh";
            this.btnChuyenNganh.Size = new System.Drawing.Size(264, 58);
            this.btnChuyenNganh.TabIndex = 7;
            this.btnChuyenNganh.Text = "  Theo Chuyên Ngành";
            this.btnChuyenNganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuyenNganh.UseVisualStyleBackColor = true;
            this.btnChuyenNganh.Click += new System.EventHandler(this.btnChuyenNganh_Click);
            // 
            // panelCapQuanLy
            // 
            this.panelCapQuanLy.Controls.Add(this.btnCS);
            this.panelCapQuanLy.Controls.Add(this.btnHV);
            this.panelCapQuanLy.Controls.Add(this.btnBo);
            this.panelCapQuanLy.Controls.Add(this.btnNN);
            this.panelCapQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCapQuanLy.Location = new System.Drawing.Point(0, 202);
            this.panelCapQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCapQuanLy.Name = "panelCapQuanLy";
            this.panelCapQuanLy.Size = new System.Drawing.Size(264, 172);
            this.panelCapQuanLy.TabIndex = 6;
            // 
            // btnCS
            // 
            this.btnCS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCS.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCS.ForeColor = System.Drawing.Color.Teal;
            this.btnCS.Location = new System.Drawing.Point(0, 126);
            this.btnCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(264, 42);
            this.btnCS.TabIndex = 5;
            this.btnCS.Text = "      Cấp Cơ Sở";
            this.btnCS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCS.UseVisualStyleBackColor = true;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // btnHV
            // 
            this.btnHV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHV.ForeColor = System.Drawing.Color.Teal;
            this.btnHV.Location = new System.Drawing.Point(0, 84);
            this.btnHV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHV.Name = "btnHV";
            this.btnHV.Size = new System.Drawing.Size(264, 42);
            this.btnHV.TabIndex = 4;
            this.btnHV.Text = "      Cấp Học Viện";
            this.btnHV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHV.UseVisualStyleBackColor = true;
            this.btnHV.Click += new System.EventHandler(this.btnHV_Click);
            // 
            // btnBo
            // 
            this.btnBo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBo.ForeColor = System.Drawing.Color.Teal;
            this.btnBo.Location = new System.Drawing.Point(0, 42);
            this.btnBo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBo.Name = "btnBo";
            this.btnBo.Size = new System.Drawing.Size(264, 42);
            this.btnBo.TabIndex = 3;
            this.btnBo.Text = "      Cấp Bộ";
            this.btnBo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBo.UseVisualStyleBackColor = true;
            this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
            // 
            // btnNN
            // 
            this.btnNN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNN.ForeColor = System.Drawing.Color.Teal;
            this.btnNN.Location = new System.Drawing.Point(0, 0);
            this.btnNN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNN.Name = "btnNN";
            this.btnNN.Size = new System.Drawing.Size(264, 42);
            this.btnNN.TabIndex = 2;
            this.btnNN.Text = "      Cấp Nhà Nước";
            this.btnNN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNN.UseVisualStyleBackColor = true;
            this.btnNN.Click += new System.EventHandler(this.btnNN_Click);
            // 
            // btnCapQuanLy
            // 
            this.btnCapQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCapQuanLy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapQuanLy.ForeColor = System.Drawing.Color.Teal;
            this.btnCapQuanLy.Location = new System.Drawing.Point(0, 144);
            this.btnCapQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapQuanLy.Name = "btnCapQuanLy";
            this.btnCapQuanLy.Size = new System.Drawing.Size(264, 58);
            this.btnCapQuanLy.TabIndex = 5;
            this.btnCapQuanLy.Text = "  Theo Cấp Quản Lý";
            this.btnCapQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapQuanLy.UseVisualStyleBackColor = true;
            this.btnCapQuanLy.Click += new System.EventHandler(this.btnCapQuanLy_Click_2);
            // 
            // panelDonVi
            // 
            this.panelDonVi.Controls.Add(this.btnBoMon);
            this.panelDonVi.Controls.Add(this.btnKhoa);
            this.panelDonVi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDonVi.Location = new System.Drawing.Point(0, 58);
            this.panelDonVi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDonVi.Name = "panelDonVi";
            this.panelDonVi.Size = new System.Drawing.Size(264, 86);
            this.panelDonVi.TabIndex = 1;
            // 
            // btnBoMon
            // 
            this.btnBoMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBoMon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoMon.ForeColor = System.Drawing.Color.Teal;
            this.btnBoMon.Location = new System.Drawing.Point(0, 42);
            this.btnBoMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoMon.Name = "btnBoMon";
            this.btnBoMon.Size = new System.Drawing.Size(264, 42);
            this.btnBoMon.TabIndex = 3;
            this.btnBoMon.Text = "       Theo Bộ Môn";
            this.btnBoMon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoMon.UseVisualStyleBackColor = true;
            this.btnBoMon.Click += new System.EventHandler(this.btnBoMon_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoa.ForeColor = System.Drawing.Color.Teal;
            this.btnKhoa.Location = new System.Drawing.Point(0, 0);
            this.btnKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(264, 42);
            this.btnKhoa.TabIndex = 2;
            this.btnKhoa.Text = "       Theo Khoa";
            this.btnKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnDonVi
            // 
            this.btnDonVi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonVi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonVi.ForeColor = System.Drawing.Color.Teal;
            this.btnDonVi.Location = new System.Drawing.Point(0, 0);
            this.btnDonVi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDonVi.Name = "btnDonVi";
            this.btnDonVi.Size = new System.Drawing.Size(264, 58);
            this.btnDonVi.TabIndex = 4;
            this.btnDonVi.Text = "  Theo Đơn Vị Quản Lý";
            this.btnDonVi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonVi.UseVisualStyleBackColor = true;
            this.btnDonVi.Click += new System.EventHandler(this.btnDonVi_Click);
            // 
            // dataTK
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataTK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTK.BackgroundColor = System.Drawing.Color.White;
            this.dataTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTK.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTK.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTK.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataTK.EnableHeadersVisualStyles = false;
            this.dataTK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataTK.Location = new System.Drawing.Point(273, 0);
            this.dataTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTK.Name = "dataTK";
            this.dataTK.RowHeadersVisible = false;
            this.dataTK.RowHeadersWidth = 62;
            this.dataTK.RowTemplate.Height = 28;
            this.dataTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTK.Size = new System.Drawing.Size(1089, 718);
            this.dataTK.TabIndex = 64;
            this.dataTK.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataTK.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTK.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTK.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTK.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataTK.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTK.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataTK.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataTK.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataTK.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTK.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTK.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTK.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTK.ThemeStyle.HeaderStyle.Height = 32;
            this.dataTK.ThemeStyle.ReadOnly = false;
            this.dataTK.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTK.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTK.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTK.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTK.ThemeStyle.RowsStyle.Height = 28;
            this.dataTK.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTK.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTK_CellContentClick);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1362, 718);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.panel_main.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelCapQuanLy.ResumeLayout(false);
            this.panelDonVi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_main;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI.WinForms.GunaDataGridView dataTK;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnChuyenNganh;
        private System.Windows.Forms.Panel panelCapQuanLy;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button btnHV;
        private System.Windows.Forms.Button btnBo;
        private System.Windows.Forms.Button btnNN;
        private System.Windows.Forms.Button btnCapQuanLy;
        private System.Windows.Forms.Panel panelDonVi;
        private System.Windows.Forms.Button btnBoMon;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnDonVi;
    }
}