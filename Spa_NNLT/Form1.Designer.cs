namespace Spa_NNLT
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTenDangNhap = new System.Windows.Forms.Label();
            this.textBoxUsename = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.buttonDangNhap);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 171);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxUsename);
            this.panel2.Controls.Add(this.labelTenDangNhap);
            this.panel2.Location = new System.Drawing.Point(22, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 48);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelTenDangNhap
            // 
            this.labelTenDangNhap.AutoSize = true;
            this.labelTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenDangNhap.Location = new System.Drawing.Point(3, 10);
            this.labelTenDangNhap.Name = "labelTenDangNhap";
            this.labelTenDangNhap.Size = new System.Drawing.Size(160, 24);
            this.labelTenDangNhap.TabIndex = 0;
            this.labelTenDangNhap.Text = "Tên đăng nhập ";
            this.labelTenDangNhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxUsename
            // 
            this.textBoxUsename.Location = new System.Drawing.Point(169, 13);
            this.textBoxUsename.Name = "textBoxUsename";
            this.textBoxUsename.Size = new System.Drawing.Size(218, 20);
            this.textBoxUsename.TabIndex = 1;
            this.textBoxUsename.TextChanged += new System.EventHandler(this.textBoxUsename_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxMatKhau);
            this.panel3.Controls.Add(this.labelMatKhau);
            this.panel3.Location = new System.Drawing.Point(22, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 48);
            this.panel3.TabIndex = 1;
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Location = new System.Drawing.Point(169, 13);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(218, 20);
            this.textBoxMatKhau.TabIndex = 1;
            this.textBoxMatKhau.UseSystemPasswordChar = true;
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.AutoSize = true;
            this.labelMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMatKhau.Location = new System.Drawing.Point(3, 14);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(106, 24);
            this.labelMatKhau.TabIndex = 0;
            this.labelMatKhau.Text = "Mật khẩu  ";
            this.labelMatKhau.Click += new System.EventHandler(this.labelMatKhau_Click);
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDangNhap.Location = new System.Drawing.Point(66, 131);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(99, 23);
            this.buttonDangNhap.TabIndex = 2;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThoat.Location = new System.Drawing.Point(272, 131);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(99, 23);
            this.buttonThoat.TabIndex = 3;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 195);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTenDangNhap;
        private System.Windows.Forms.TextBox textBoxUsename;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonDangNhap;
    }
}

