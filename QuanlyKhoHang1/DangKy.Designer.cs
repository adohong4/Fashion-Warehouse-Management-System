namespace QuanlyKhoHang1
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.labelRegister = new System.Windows.Forms.Label();
            this.comboBoxposition = new System.Windows.Forms.ComboBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.labelposition = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labeusername = new System.Windows.Forms.Label();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.labelconfirm = new System.Windows.Forms.Label();
            this.buttonregister = new System.Windows.Forms.Button();
            this.buttonchangepass = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRegister
            // 
            this.labelRegister.BackColor = System.Drawing.Color.DarkMagenta;
            this.labelRegister.Font = new System.Drawing.Font("UTM Akashi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRegister.Location = new System.Drawing.Point(107, 9);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(414, 59);
            this.labelRegister.TabIndex = 0;
            this.labelRegister.Text = "Đăng Ký Tài Khoản";
            this.labelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxposition
            // 
            this.comboBoxposition.BackColor = System.Drawing.Color.White;
            this.comboBoxposition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxposition.FormattingEnabled = true;
            this.comboBoxposition.Items.AddRange(new object[] {
            "Nhân viên",
            "Kiểm Kho",
            "Quản Lý"});
            this.comboBoxposition.Location = new System.Drawing.Point(401, 142);
            this.comboBoxposition.Name = "comboBoxposition";
            this.comboBoxposition.Size = new System.Drawing.Size(199, 37);
            this.comboBoxposition.TabIndex = 16;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.BackColor = System.Drawing.Color.White;
            this.textBoxpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpassword.Location = new System.Drawing.Point(95, 228);
            this.textBoxpassword.Multiline = true;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(203, 37);
            this.textBoxpassword.TabIndex = 15;
            // 
            // textBoxusername
            // 
            this.textBoxusername.BackColor = System.Drawing.Color.White;
            this.textBoxusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxusername.Location = new System.Drawing.Point(95, 142);
            this.textBoxusername.Multiline = true;
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(203, 37);
            this.textBoxusername.TabIndex = 14;
            // 
            // labelposition
            // 
            this.labelposition.AutoSize = true;
            this.labelposition.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelposition.Location = new System.Drawing.Point(332, 117);
            this.labelposition.Name = "labelposition";
            this.labelposition.Size = new System.Drawing.Size(72, 19);
            this.labelposition.TabIndex = 12;
            this.labelposition.Text = "Chức Vụ";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(26, 203);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(85, 19);
            this.labelpassword.TabIndex = 11;
            this.labelpassword.Text = "Mật Khấu ";
            this.labelpassword.Click += new System.EventHandler(this.labelpassword_Click);
            // 
            // labeusername
            // 
            this.labeusername.AutoSize = true;
            this.labeusername.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeusername.Location = new System.Drawing.Point(26, 117);
            this.labeusername.Name = "labeusername";
            this.labeusername.Size = new System.Drawing.Size(84, 19);
            this.labeusername.TabIndex = 10;
            this.labeusername.Text = "Tài Khoản";
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.BackColor = System.Drawing.Color.White;
            this.textBoxConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirm.Location = new System.Drawing.Point(401, 228);
            this.textBoxConfirm.Multiline = true;
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.Size = new System.Drawing.Size(203, 39);
            this.textBoxConfirm.TabIndex = 20;
            // 
            // labelconfirm
            // 
            this.labelconfirm.AutoSize = true;
            this.labelconfirm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelconfirm.Location = new System.Drawing.Point(332, 203);
            this.labelconfirm.Name = "labelconfirm";
            this.labelconfirm.Size = new System.Drawing.Size(153, 19);
            this.labelconfirm.TabIndex = 19;
            this.labelconfirm.Text = "Xác Nhận mật Khẩu";
            this.labelconfirm.Click += new System.EventHandler(this.labelconfirm_Click);
            // 
            // buttonregister
            // 
            this.buttonregister.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonregister.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonregister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonregister.Location = new System.Drawing.Point(149, 323);
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.Size = new System.Drawing.Size(111, 53);
            this.buttonregister.TabIndex = 22;
            this.buttonregister.Text = "Đăng Ký";
            this.buttonregister.UseVisualStyleBackColor = false;
            this.buttonregister.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // buttonchangepass
            // 
            this.buttonchangepass.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonchangepass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonchangepass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonchangepass.Location = new System.Drawing.Point(352, 323);
            this.buttonchangepass.Name = "buttonchangepass";
            this.buttonchangepass.Size = new System.Drawing.Size(111, 53);
            this.buttonchangepass.TabIndex = 23;
            this.buttonchangepass.Text = "Đổi Mật Khẩu";
            this.buttonchangepass.UseVisualStyleBackColor = false;
            this.buttonchangepass.Click += new System.EventHandler(this.buttonchangepass_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(336, 228);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(336, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 228);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Aircona", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(12, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Design by Group 5";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(30, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 1);
            this.panel3.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(336, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 1);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(30, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 1);
            this.panel2.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(336, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 1);
            this.panel4.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel5.Controls.Add(this.labelRegister);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(628, 77);
            this.panel5.TabIndex = 40;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonchangepass);
            this.Controls.Add(this.buttonregister);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBoxConfirm);
            this.Controls.Add(this.labelconfirm);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBoxposition);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelposition);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labeusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBoxposition;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelposition;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labeusername;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBoxConfirm;
        private System.Windows.Forms.Label labelconfirm;
        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.Button buttonchangepass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}