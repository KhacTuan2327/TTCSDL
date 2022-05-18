
using System;
using System.Windows.Forms;

namespace TTCSDL
{
    partial class DeTai1
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
            this.lbThongTinDT = new System.Windows.Forms.Label();
            this.lbDT = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKinhPhi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaCB = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaCap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNganh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNgay = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNam = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTrangThai = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataDT = new Guna.UI.WinForms.GunaDataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaTB = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDT)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThongTinDT
            // 
            this.lbThongTinDT.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinDT.Location = new System.Drawing.Point(1092, 11);
            this.lbThongTinDT.Name = "lbThongTinDT";
            this.lbThongTinDT.Size = new System.Drawing.Size(195, 45);
            this.lbThongTinDT.TabIndex = 1;
            this.lbThongTinDT.Text = "Chi Tiết";
            // 
            // lbDT
            // 
            this.lbDT.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDT.Location = new System.Drawing.Point(334, 11);
            this.lbDT.Name = "lbDT";
            this.lbDT.Size = new System.Drawing.Size(195, 45);
            this.lbDT.TabIndex = 2;
            this.lbDT.Text = "Đề Tài";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMa.Location = new System.Drawing.Point(840, 103);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(143, 38);
            this.lbMa.TabIndex = 3;
            this.lbMa.Text = "Mã Đề Tài";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(840, 169);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(145, 38);
            this.lbTen.TabIndex = 4;
            this.lbTen.Text = "Tên Đề Tài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(840, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kinh Phí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(840, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Năm Thực Hiện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(840, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày Đăng Kí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(840, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã Ngành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(840, 595);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã Cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(840, 663);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã Cán Bộ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(840, 732);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 38);
            this.label7.TabIndex = 11;
            this.label7.Text = "Trạng Thái";
            // 
            // txtMaDT
            // 
            this.txtMaDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDT.DefaultText = "";
            this.txtMaDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDT.Location = new System.Drawing.Point(1076, 103);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.PasswordChar = '\0';
            this.txtMaDT.PlaceholderText = "";
            this.txtMaDT.SelectedText = "";
            this.txtMaDT.Size = new System.Drawing.Size(420, 38);
            this.txtMaDT.TabIndex = 12;
            // 
            // txtTenDT
            // 
            this.txtTenDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDT.DefaultText = "";
            this.txtTenDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDT.Location = new System.Drawing.Point(1076, 169);
            this.txtTenDT.Name = "txtTenDT";
            this.txtTenDT.PasswordChar = '\0';
            this.txtTenDT.PlaceholderText = "";
            this.txtTenDT.SelectedText = "";
            this.txtTenDT.Size = new System.Drawing.Size(420, 38);
            this.txtTenDT.TabIndex = 13;
            // 
            // txtKinhPhi
            // 
            this.txtKinhPhi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKinhPhi.DefaultText = "";
            this.txtKinhPhi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKinhPhi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKinhPhi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKinhPhi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKinhPhi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKinhPhi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKinhPhi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKinhPhi.Location = new System.Drawing.Point(1076, 249);
            this.txtKinhPhi.Name = "txtKinhPhi";
            this.txtKinhPhi.PasswordChar = '\0';
            this.txtKinhPhi.PlaceholderText = "";
            this.txtKinhPhi.SelectedText = "";
            this.txtKinhPhi.Size = new System.Drawing.Size(420, 38);
            this.txtKinhPhi.TabIndex = 14;
            // 
            // txtMaCB
            // 
            this.txtMaCB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCB.DefaultText = "";
            this.txtMaCB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaCB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaCB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaCB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaCB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaCB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaCB.Location = new System.Drawing.Point(1076, 663);
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.PasswordChar = '\0';
            this.txtMaCB.PlaceholderText = "";
            this.txtMaCB.SelectedText = "";
            this.txtMaCB.Size = new System.Drawing.Size(420, 38);
            this.txtMaCB.TabIndex = 15;
            // 
            // txtMaCap
            // 
            this.txtMaCap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCap.DefaultText = "";
            this.txtMaCap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaCap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaCap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaCap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaCap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaCap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaCap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaCap.Location = new System.Drawing.Point(1076, 595);
            this.txtMaCap.Name = "txtMaCap";
            this.txtMaCap.PasswordChar = '\0';
            this.txtMaCap.PlaceholderText = "";
            this.txtMaCap.SelectedText = "";
            this.txtMaCap.Size = new System.Drawing.Size(420, 38);
            this.txtMaCap.TabIndex = 16;
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNganh.DefaultText = "";
            this.txtMaNganh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNganh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNganh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNganh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNganh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNganh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNganh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNganh.Location = new System.Drawing.Point(1076, 529);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.PasswordChar = '\0';
            this.txtMaNganh.PlaceholderText = "";
            this.txtMaNganh.SelectedText = "";
            this.txtMaNganh.Size = new System.Drawing.Size(420, 38);
            this.txtMaNganh.TabIndex = 17;
            // 
            // txtNgay
            // 
            this.txtNgay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgay.DefaultText = "";
            this.txtNgay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNgay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNgay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgay.Location = new System.Drawing.Point(1076, 383);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.PasswordChar = '\0';
            this.txtNgay.PlaceholderText = "";
            this.txtNgay.SelectedText = "";
            this.txtNgay.Size = new System.Drawing.Size(420, 38);
            this.txtNgay.TabIndex = 18;
            // 
            // txtNam
            // 
            this.txtNam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNam.DefaultText = "";
            this.txtNam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNam.Location = new System.Drawing.Point(1076, 311);
            this.txtNam.Name = "txtNam";
            this.txtNam.PasswordChar = '\0';
            this.txtNam.PlaceholderText = "";
            this.txtNam.SelectedText = "";
            this.txtNam.Size = new System.Drawing.Size(420, 38);
            this.txtNam.TabIndex = 19;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrangThai.DefaultText = "";
            this.txtTrangThai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrangThai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTrangThai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrangThai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTrangThai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrangThai.Location = new System.Drawing.Point(1076, 732);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.PasswordChar = '\0';
            this.txtTrangThai.PlaceholderText = "";
            this.txtTrangThai.SelectedText = "";
            this.txtTrangThai.Size = new System.Drawing.Size(420, 38);
            this.txtTrangThai.TabIndex = 20;
            // 
            // dataDT
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataDT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDT.BackgroundColor = System.Drawing.Color.White;
            this.dataDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataDT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataDT.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDT.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataDT.EnableHeadersVisualStyles = false;
            this.dataDT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataDT.Location = new System.Drawing.Point(14, 75);
            this.dataDT.Name = "dataDT";
            this.dataDT.RowHeadersVisible = false;
            this.dataDT.RowHeadersWidth = 62;
            this.dataDT.RowTemplate.Height = 28;
            this.dataDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDT.Size = new System.Drawing.Size(789, 795);
            this.dataDT.TabIndex = 49;
            this.dataDT.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataDT.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDT.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataDT.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataDT.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataDT.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataDT.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataDT.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataDT.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataDT.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataDT.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataDT.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataDT.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataDT.ThemeStyle.HeaderStyle.Height = 32;
            this.dataDT.ThemeStyle.ReadOnly = false;
            this.dataDT.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDT.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataDT.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataDT.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataDT.ThemeStyle.RowsStyle.Height = 28;
            this.dataDT.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDT.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataDT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDT_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(840, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 38);
            this.label8.TabIndex = 50;
            this.label8.Text = "Mã Tiểu Ban";
            // 
            // txtMaTB
            // 
            this.txtMaTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTB.DefaultText = "";
            this.txtMaTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTB.Location = new System.Drawing.Point(1076, 455);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.PasswordChar = '\0';
            this.txtMaTB.PlaceholderText = "";
            this.txtMaTB.SelectedText = "";
            this.txtMaTB.Size = new System.Drawing.Size(420, 38);
            this.txtMaTB.TabIndex = 51;
            // 
            // DeTai1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1527, 883);
            this.Controls.Add(this.txtMaTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataDT);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.txtMaNganh);
            this.Controls.Add(this.txtMaCap);
            this.Controls.Add(this.txtMaCB);
            this.Controls.Add(this.txtKinhPhi);
            this.Controls.Add(this.txtTenDT);
            this.Controls.Add(this.txtMaDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.lbDT);
            this.Controls.Add(this.lbThongTinDT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeTai1";
            this.Text = "DeTai";
            this.Load += new System.EventHandler(this.DeTai1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lbThongTinDT;
        private System.Windows.Forms.Label lbDT;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDT;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDT;
        private Guna.UI2.WinForms.Guna2TextBox txtKinhPhi;
        private Guna.UI2.WinForms.Guna2TextBox txtMaCB;
        private Guna.UI2.WinForms.Guna2TextBox txtMaCap;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNganh;
        private Guna.UI2.WinForms.Guna2TextBox txtNgay;
        private Guna.UI2.WinForms.Guna2TextBox txtNam;
        private Guna.UI2.WinForms.Guna2TextBox txtTrangThai;
        private Guna.UI.WinForms.GunaDataGridView dataDT;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTB;
    }
}