
namespace TTCSDL
{
    partial class ThongKeKhoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbkhoa = new System.Windows.Forms.ComboBox();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExportFile = new FontAwesome.Sharp.IconButton();
            this.dataTK = new Guna.UI.WinForms.GunaDataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.soluong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hocvien = new System.Windows.Forms.Label();
            this.nhanuoc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.coso = new System.Windows.Forms.Label();
            this.bo = new System.Windows.Forms.Label();
            this.lbSLNN = new System.Windows.Forms.Label();
            this.lbSLCS = new System.Windows.Forms.Label();
            this.lbSLHV = new System.Windows.Forms.Label();
            this.lbSLB = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbSLG = new System.Windows.Forms.Label();
            this.lbSLK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTK)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbkhoa
            // 
            this.cbbkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbkhoa.FormattingEnabled = true;
            this.cbbkhoa.Location = new System.Drawing.Point(12, 45);
            this.cbbkhoa.Name = "cbbkhoa";
            this.cbbkhoa.Size = new System.Drawing.Size(644, 33);
            this.cbbkhoa.TabIndex = 88;
            this.cbbkhoa.SelectedIndexChanged += new System.EventHandler(this.cbbkhoa_SelectedIndexChanged);
            // 
            // search
            // 
            this.search.BorderRadius = 8;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultText = "";
            this.search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.Location = new System.Drawing.Point(670, 35);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.search.PlaceholderText = "Nhập vào thông tin cần tìm kiếm ...";
            this.search.SelectedText = "";
            this.search.Size = new System.Drawing.Size(320, 47);
            this.search.TabIndex = 87;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // btnExportFile
            // 
            this.btnExportFile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportFile.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportFile.IconColor = System.Drawing.Color.Black;
            this.btnExportFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportFile.IconSize = 30;
            this.btnExportFile.Location = new System.Drawing.Point(1010, 35);
            this.btnExportFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(148, 47);
            this.btnExportFile.TabIndex = 86;
            this.btnExportFile.Text = "Xuất file";
            this.btnExportFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportFile.UseVisualStyleBackColor = true;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTK.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTK.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTK.EnableHeadersVisualStyles = false;
            this.dataTK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataTK.Location = new System.Drawing.Point(2, 236);
            this.dataTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTK.Name = "dataTK";
            this.dataTK.ReadOnly = true;
            this.dataTK.RowHeadersVisible = false;
            this.dataTK.RowHeadersWidth = 62;
            this.dataTK.RowTemplate.Height = 28;
            this.dataTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTK.Size = new System.Drawing.Size(1181, 571);
            this.dataTK.TabIndex = 85;
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
            this.dataTK.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTK.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTK.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTK.ThemeStyle.HeaderStyle.Height = 32;
            this.dataTK.ThemeStyle.ReadOnly = true;
            this.dataTK.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTK.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTK.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTK.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dataTK.ThemeStyle.RowsStyle.Height = 28;
            this.dataTK.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTK.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTK_CellContentClick);
            // 
            // soluong
            // 
            this.soluong.AutoSize = true;
            this.soluong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluong.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.soluong.Location = new System.Drawing.Point(14, 99);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(185, 25);
            this.soluong.TabIndex = 89;
            this.soluong.Text = "Tổng số lượng đề tài";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(653, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 91;
            this.label3.Text = "Số đề tài loại GIỎI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(103, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 93;
            // 
            // hocvien
            // 
            this.hocvien.AutoSize = true;
            this.hocvien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocvien.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.hocvien.Location = new System.Drawing.Point(298, 159);
            this.hocvien.Name = "hocvien";
            this.hocvien.Size = new System.Drawing.Size(198, 25);
            this.hocvien.TabIndex = 94;
            this.hocvien.Text = "Số đề tài cấp Học viện";
            // 
            // nhanuoc
            // 
            this.nhanuoc.AutoSize = true;
            this.nhanuoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhanuoc.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.nhanuoc.Location = new System.Drawing.Point(298, 99);
            this.nhanuoc.Name = "nhanuoc";
            this.nhanuoc.Size = new System.Drawing.Size(207, 25);
            this.nhanuoc.TabIndex = 92;
            this.nhanuoc.Text = "Số đề tài cấp Nhà nước";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(653, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 25);
            this.label8.TabIndex = 96;
            this.label8.Text = "Số đề tài loại KHÁ";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "Chọn Khoa quản lý:";
            // 
            // coso
            // 
            this.coso.AutoSize = true;
            this.coso.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coso.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.coso.Location = new System.Drawing.Point(298, 189);
            this.coso.Name = "coso";
            this.coso.Size = new System.Drawing.Size(172, 25);
            this.coso.TabIndex = 98;
            this.coso.Text = "Số đề tài cấp Cơ sở";
            // 
            // bo
            // 
            this.bo.AutoSize = true;
            this.bo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bo.Location = new System.Drawing.Point(298, 129);
            this.bo.Name = "bo";
            this.bo.Size = new System.Drawing.Size(147, 25);
            this.bo.TabIndex = 99;
            this.bo.Text = "Số đề tài cấp Bộ";
            // 
            // lbSLNN
            // 
            this.lbSLNN.AutoSize = true;
            this.lbSLNN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLNN.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbSLNN.Location = new System.Drawing.Point(541, 101);
            this.lbSLNN.Name = "lbSLNN";
            this.lbSLNN.Size = new System.Drawing.Size(19, 23);
            this.lbSLNN.TabIndex = 101;
            this.lbSLNN.Text = "0";
            // 
            // lbSLCS
            // 
            this.lbSLCS.AutoSize = true;
            this.lbSLCS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLCS.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbSLCS.Location = new System.Drawing.Point(541, 190);
            this.lbSLCS.Name = "lbSLCS";
            this.lbSLCS.Size = new System.Drawing.Size(19, 23);
            this.lbSLCS.TabIndex = 102;
            this.lbSLCS.Text = "0";
            // 
            // lbSLHV
            // 
            this.lbSLHV.AutoSize = true;
            this.lbSLHV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLHV.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbSLHV.Location = new System.Drawing.Point(541, 159);
            this.lbSLHV.Name = "lbSLHV";
            this.lbSLHV.Size = new System.Drawing.Size(19, 23);
            this.lbSLHV.TabIndex = 103;
            this.lbSLHV.Text = "0";
            // 
            // lbSLB
            // 
            this.lbSLB.AutoSize = true;
            this.lbSLB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLB.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbSLB.Location = new System.Drawing.Point(541, 131);
            this.lbSLB.Name = "lbSLB";
            this.lbSLB.Size = new System.Drawing.Size(19, 23);
            this.lbSLB.TabIndex = 104;
            this.lbSLB.Text = "0";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSL.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbSL.Location = new System.Drawing.Point(233, 101);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(19, 23);
            this.lbSL.TabIndex = 105;
            this.lbSL.Text = "0";
            // 
            // lbSLG
            // 
            this.lbSLG.AutoSize = true;
            this.lbSLG.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLG.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbSLG.Location = new System.Drawing.Point(847, 99);
            this.lbSLG.Name = "lbSLG";
            this.lbSLG.Size = new System.Drawing.Size(19, 23);
            this.lbSLG.TabIndex = 106;
            this.lbSLG.Text = "0";
            // 
            // lbSLK
            // 
            this.lbSLK.AutoSize = true;
            this.lbSLK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLK.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbSLK.Location = new System.Drawing.Point(846, 131);
            this.lbSLK.Name = "lbSLK";
            this.lbSLK.Size = new System.Drawing.Size(19, 23);
            this.lbSLK.TabIndex = 107;
            this.lbSLK.Text = "0";
            // 
            // ThongKeKhoa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1195, 818);
            this.ControlBox = false;
            this.Controls.Add(this.lbSLK);
            this.Controls.Add(this.lbSLG);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.lbSLB);
            this.Controls.Add(this.lbSLHV);
            this.Controls.Add(this.lbSLCS);
            this.Controls.Add(this.lbSLNN);
            this.Controls.Add(this.bo);
            this.Controls.Add(this.coso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hocvien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nhanuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.cbbkhoa);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btnExportFile);
            this.Controls.Add(this.dataTK);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Name = "ThongKeKhoa";
            this.Text = "ThongKeKhoa";
            this.Load += new System.EventHandler(this.ThongKeKhoa_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbkhoa;
        private Guna.UI2.WinForms.Guna2TextBox search;
        private FontAwesome.Sharp.IconButton btnExportFile;
        private Guna.UI.WinForms.GunaDataGridView dataTK;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hocvien;
        private System.Windows.Forms.Label nhanuoc;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.Label soluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label coso;
        private System.Windows.Forms.Label bo;
        private System.Windows.Forms.Label lbSLNN;
        private System.Windows.Forms.Label lbSLCS;
        private System.Windows.Forms.Label lbSLHV;
        private System.Windows.Forms.Label lbSLB;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label lbSLG;
        private System.Windows.Forms.Label lbSLK;
    }
}