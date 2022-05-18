
namespace TTCSDL
{
    partial class NhanSu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.txtTGTG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txttencanbo = new System.Windows.Forms.TextBox();
            this.lbtenkhoa = new System.Windows.Forms.Label();
            this.txtmacanbo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmabm = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtcapbac = new System.Windows.Forms.TextBox();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbchunhiem = new System.Windows.Forms.Label();
            this.lbmakhoa = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addPic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datanhansu = new Guna.UI.WinForms.GunaDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportFile = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datanhansu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtTGTG);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtchucvu);
            this.panel1.Controls.Add(this.lbdiachi);
            this.panel1.Controls.Add(this.rdoNu);
            this.panel1.Controls.Add(this.rdoNam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttencanbo);
            this.panel1.Controls.Add(this.lbtenkhoa);
            this.panel1.Controls.Add(this.txtmacanbo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NgaySinh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmabm);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtcapbac);
            this.panel1.Controls.Add(this.lbsdt);
            this.panel1.Controls.Add(this.lbchunhiem);
            this.panel1.Controls.Add(this.lbmakhoa);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 898);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 30;
            this.btnSave.Location = new System.Drawing.Point(432, 728);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 72);
            this.btnSave.TabIndex = 73;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 30;
            this.btnDelete.Location = new System.Drawing.Point(259, 728);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 72);
            this.btnDelete.TabIndex = 72;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 30;
            this.btnAdd.Location = new System.Drawing.Point(73, 728);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 72);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTGTG
            // 
            this.txtTGTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTGTG.Location = new System.Drawing.Point(226, 460);
            this.txtTGTG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTGTG.Multiline = true;
            this.txtTGTG.Name = "txtTGTG";
            this.txtTGTG.Size = new System.Drawing.Size(388, 39);
            this.txtTGTG.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(12, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 30);
            this.label3.TabIndex = 69;
            this.label3.Text = "Thời gian tham gia";
            // 
            // txtchucvu
            // 
            this.txtchucvu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtchucvu.Location = new System.Drawing.Point(226, 389);
            this.txtchucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtchucvu.Multiline = true;
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(388, 39);
            this.txtchucvu.TabIndex = 68;
            // 
            // lbdiachi
            // 
            this.lbdiachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbdiachi.Location = new System.Drawing.Point(11, 400);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(93, 30);
            this.lbdiachi.TabIndex = 67;
            this.lbdiachi.Text = "Chức vụ";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.rdoNu.Location = new System.Drawing.Point(519, 179);
            this.rdoNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(71, 33);
            this.rdoNu.TabIndex = 66;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.rdoNam.Location = new System.Drawing.Point(387, 179);
            this.rdoNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(89, 33);
            this.rdoNam.TabIndex = 65;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(237, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 64;
            this.label2.Text = "Giới tính";
            // 
            // txttencanbo
            // 
            this.txttencanbo.AcceptsReturn = true;
            this.txttencanbo.AcceptsTab = true;
            this.txttencanbo.AllowDrop = true;
            this.txttencanbo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttencanbo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttencanbo.Location = new System.Drawing.Point(360, 112);
            this.txttencanbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttencanbo.Multiline = true;
            this.txttencanbo.Name = "txttencanbo";
            this.txttencanbo.Size = new System.Drawing.Size(254, 39);
            this.txttencanbo.TabIndex = 63;
            // 
            // lbtenkhoa
            // 
            this.lbtenkhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbtenkhoa.AutoSize = true;
            this.lbtenkhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenkhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbtenkhoa.Location = new System.Drawing.Point(238, 123);
            this.lbtenkhoa.Name = "lbtenkhoa";
            this.lbtenkhoa.Size = new System.Drawing.Size(122, 30);
            this.lbtenkhoa.TabIndex = 62;
            this.lbtenkhoa.Text = "Tên Cán Bộ";
            // 
            // txtmacanbo
            // 
            this.txtmacanbo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmacanbo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmacanbo.Location = new System.Drawing.Point(360, 50);
            this.txtmacanbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmacanbo.Multiline = true;
            this.txtmacanbo.Name = "txtmacanbo";
            this.txtmacanbo.Size = new System.Drawing.Size(254, 39);
            this.txtmacanbo.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(14, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 30);
            this.label4.TabIndex = 60;
            this.label4.Text = "Mã bộ môn";
            // 
            // NgaySinh
            // 
            this.NgaySinh.AllowDrop = true;
            this.NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgaySinh.Location = new System.Drawing.Point(360, 240);
            this.NgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(254, 26);
            this.NgaySinh.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(237, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "Ngày sinh";
            // 
            // txtmabm
            // 
            this.txtmabm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmabm.Location = new System.Drawing.Point(226, 600);
            this.txtmabm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmabm.Multiline = true;
            this.txtmabm.Name = "txtmabm";
            this.txtmabm.Size = new System.Drawing.Size(388, 39);
            this.txtmabm.TabIndex = 56;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Location = new System.Drawing.Point(226, 529);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(388, 39);
            this.txtPhone.TabIndex = 57;
            // 
            // txtcapbac
            // 
            this.txtcapbac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcapbac.Location = new System.Drawing.Point(360, 295);
            this.txtcapbac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcapbac.Multiline = true;
            this.txtcapbac.Name = "txtcapbac";
            this.txtcapbac.Size = new System.Drawing.Size(254, 39);
            this.txtcapbac.TabIndex = 55;
            // 
            // lbsdt
            // 
            this.lbsdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsdt.AutoSize = true;
            this.lbsdt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbsdt.Location = new System.Drawing.Point(14, 540);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(150, 30);
            this.lbsdt.TabIndex = 54;
            this.lbsdt.Text = "Số Điện Thoại";
            // 
            // lbchunhiem
            // 
            this.lbchunhiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbchunhiem.AutoSize = true;
            this.lbchunhiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbchunhiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbchunhiem.Location = new System.Drawing.Point(236, 303);
            this.lbchunhiem.Name = "lbchunhiem";
            this.lbchunhiem.Size = new System.Drawing.Size(90, 30);
            this.lbchunhiem.TabIndex = 53;
            this.lbchunhiem.Text = "Cấp bậc";
            // 
            // lbmakhoa
            // 
            this.lbmakhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbmakhoa.AutoSize = true;
            this.lbmakhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmakhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbmakhoa.Location = new System.Drawing.Point(238, 62);
            this.lbmakhoa.Name = "lbmakhoa";
            this.lbmakhoa.Size = new System.Drawing.Size(119, 30);
            this.lbmakhoa.TabIndex = 52;
            this.lbmakhoa.Text = "Mã Cán Bộ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addPic);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(17, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 297);
            this.panel3.TabIndex = 0;
            // 
            // addPic
            // 
            this.addPic.BackColor = System.Drawing.Color.Teal;
            this.addPic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPic.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPic.Location = new System.Drawing.Point(0, 245);
            this.addPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPic.Name = "addPic";
            this.addPic.Size = new System.Drawing.Size(198, 50);
            this.addPic.TabIndex = 1;
            this.addPic.Text = "Thêm ảnh";
            this.addPic.UseVisualStyleBackColor = false;
            this.addPic.Click += new System.EventHandler(this.addPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 295);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // datanhansu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datanhansu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datanhansu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datanhansu.BackgroundColor = System.Drawing.Color.White;
            this.datanhansu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datanhansu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datanhansu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datanhansu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datanhansu.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datanhansu.DefaultCellStyle = dataGridViewCellStyle3;
            this.datanhansu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datanhansu.EnableHeadersVisualStyles = false;
            this.datanhansu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datanhansu.Location = new System.Drawing.Point(634, 77);
            this.datanhansu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datanhansu.Name = "datanhansu";
            this.datanhansu.RowHeadersVisible = false;
            this.datanhansu.RowHeadersWidth = 62;
            this.datanhansu.RowTemplate.Height = 28;
            this.datanhansu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datanhansu.Size = new System.Drawing.Size(898, 821);
            this.datanhansu.StandardTab = true;
            this.datanhansu.TabIndex = 45;
            this.datanhansu.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.datanhansu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datanhansu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datanhansu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datanhansu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datanhansu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datanhansu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datanhansu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datanhansu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datanhansu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datanhansu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datanhansu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datanhansu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datanhansu.ThemeStyle.HeaderStyle.Height = 50;
            this.datanhansu.ThemeStyle.ReadOnly = false;
            this.datanhansu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datanhansu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datanhansu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datanhansu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datanhansu.ThemeStyle.RowsStyle.Height = 28;
            this.datanhansu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datanhansu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datanhansu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datanhansu_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExportFile);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.txttimkiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(634, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 77);
            this.panel2.TabIndex = 18;
            // 
            // btnExportFile
            // 
            this.btnExportFile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportFile.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportFile.IconColor = System.Drawing.Color.Black;
            this.btnExportFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportFile.IconSize = 30;
            this.btnExportFile.Location = new System.Drawing.Point(600, 5);
            this.btnExportFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(160, 68);
            this.btnExportFile.TabIndex = 48;
            this.btnExportFile.Text = "Xuất file";
            this.btnExportFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportFile.UseVisualStyleBackColor = true;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton2.Location = new System.Drawing.Point(96, 15);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(57, 40);
            this.iconButton2.TabIndex = 47;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            this.txttimkiem.BackColor = System.Drawing.SystemColors.Window;
            this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(96, 14);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txttimkiem.Size = new System.Drawing.Size(332, 45);
            this.txttimkiem.TabIndex = 46;
            // 
            // NhanSu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1532, 898);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datanhansu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NhanSu";
            this.Text = "NhanSu";
            this.Load += new System.EventHandler(this.NhanSu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datanhansu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDataGridView datanhansu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox txttimkiem;
        private FontAwesome.Sharp.IconButton btnExportFile;
        private System.Windows.Forms.TextBox txtmacanbo;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.DateTimePicker NgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmabm;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtcapbac;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lbchunhiem;
        private System.Windows.Forms.Label lbmakhoa;
        private System.Windows.Forms.TextBox txttencanbo;
        private System.Windows.Forms.Label lbtenkhoa;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.TextBox txtTGTG;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}