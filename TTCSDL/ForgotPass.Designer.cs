namespace TTCSDL
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.email = new System.Windows.Forms.TextBox();
            this.layMk = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.passW = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-6, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(881, 488);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(295, 180);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(296, 45);
            this.email.TabIndex = 1;
            // 
            // layMk
            // 
            this.layMk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.layMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layMk.Location = new System.Drawing.Point(295, 309);
            this.layMk.Name = "layMk";
            this.layMk.Size = new System.Drawing.Size(147, 48);
            this.layMk.TabIndex = 3;
            this.layMk.Text = "Lấy mật khẩu";
            this.layMk.UseVisualStyleBackColor = false;
            this.layMk.Click += new System.EventHandler(this.layMk_Click);
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.Color.MediumAquamarine;
            this.copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy.Location = new System.Drawing.Point(597, 246);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(69, 45);
            this.copy.TabIndex = 4;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // passW
            // 
            this.passW.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passW.Location = new System.Drawing.Point(295, 246);
            this.passW.Name = "passW";
            this.passW.Size = new System.Drawing.Size(296, 45);
            this.passW.TabIndex = 2;
            this.passW.UseSystemPasswordChar = true;
            this.passW.TextChanged += new System.EventHandler(this.passW_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(448, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(238, 246);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(238, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 486);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passW);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.layMk);
            this.Controls.Add(this.email);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPass";
            this.Text = "QuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button layMk;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.TextBox passW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}