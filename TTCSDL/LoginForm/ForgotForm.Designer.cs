﻿
namespace TTCSDL.LoginForm
{
    partial class ForgotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotForm));
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.verifyCode = new Guna.UI2.WinForms.Guna2GradientButton();
            this.codeVerify = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sendToEmail = new Guna.UI2.WinForms.Guna2GradientButton();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(399, 1);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(51, 31);
            this.guna2ControlBox2.TabIndex = 22;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(456, 1);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(52, 31);
            this.guna2ControlBox1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(42, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // verifyCode
            // 
            this.verifyCode.BorderRadius = 8;
            this.verifyCode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.verifyCode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.verifyCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.verifyCode.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.verifyCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.verifyCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.verifyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyCode.ForeColor = System.Drawing.Color.White;
            this.verifyCode.Location = new System.Drawing.Point(102, 431);
            this.verifyCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verifyCode.Name = "verifyCode";
            this.verifyCode.Size = new System.Drawing.Size(355, 43);
            this.verifyCode.TabIndex = 39;
            this.verifyCode.Text = "Xác thực";
            this.verifyCode.Click += new System.EventHandler(this.verifyCode_Click);
            // 
            // codeVerify
            // 
            this.codeVerify.BorderRadius = 8;
            this.codeVerify.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeVerify.DefaultText = "";
            this.codeVerify.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.codeVerify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.codeVerify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeVerify.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeVerify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.codeVerify.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeVerify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.codeVerify.ForeColor = System.Drawing.Color.Black;
            this.codeVerify.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeVerify.Location = new System.Drawing.Point(102, 376);
            this.codeVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codeVerify.Name = "codeVerify";
            this.codeVerify.PasswordChar = '\0';
            this.codeVerify.PlaceholderText = "Mã xác nhận";
            this.codeVerify.SelectedText = "";
            this.codeVerify.Size = new System.Drawing.Size(355, 38);
            this.codeVerify.TabIndex = 38;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(42, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // sendToEmail
            // 
            this.sendToEmail.BorderRadius = 8;
            this.sendToEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendToEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendToEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendToEmail.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendToEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendToEmail.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.sendToEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendToEmail.ForeColor = System.Drawing.Color.White;
            this.sendToEmail.Location = new System.Drawing.Point(102, 309);
            this.sendToEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendToEmail.Name = "sendToEmail";
            this.sendToEmail.Size = new System.Drawing.Size(355, 43);
            this.sendToEmail.TabIndex = 36;
            this.sendToEmail.Text = "Gửi xác nhận";
            this.sendToEmail.Click += new System.EventHandler(this.sendToEmail_Click);
            // 
            // email
            // 
            this.email.BorderRadius = 8;
            this.email.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.email.DefaultText = "";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.Location = new System.Drawing.Point(102, 258);
            this.email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PlaceholderText = "Email";
            this.email.SelectedText = "";
            this.email.Size = new System.Drawing.Size(355, 38);
            this.email.TabIndex = 35;
            this.email.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(102, 145);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 41);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = "Điền đúng email mà bạn đăng ký và lấy mã xác thực hộp thư để có thể thực hiện các" +
    " thao tác tiếp theo";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(97, 106);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 25);
            this.linkLabel1.TabIndex = 41;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Yêu cầu:";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button1.Location = new System.Drawing.Point(3, 1);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(83, 36);
            this.guna2Button1.TabIndex = 43;
            this.guna2Button1.Text = "< Login";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ForgotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 554);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.verifyCode);
            this.Controls.Add(this.codeVerify);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sendToEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotForm";
            this.Text = "ForgotForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton verifyCode;
        private Guna.UI2.WinForms.Guna2TextBox codeVerify;
        public System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton sendToEmail;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}