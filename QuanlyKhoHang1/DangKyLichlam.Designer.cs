namespace QuanlyKhoHang1
{
    partial class DangKyLichlam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKyLichlam));
            this.pnlCa1 = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvCaToi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCaChieu = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCalam = new System.Windows.Forms.ComboBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCaSang = new System.Windows.Forms.DataGridView();
            this.btnXoaCa1 = new System.Windows.Forms.Button();
            this.btnSuaCa1 = new System.Windows.Forms.Button();
            this.btnThemCa1 = new System.Windows.Forms.Button();
            this.lbCaSang = new System.Windows.Forms.Label();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCa1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaToi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaChieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaSang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCa1
            // 
            this.pnlCa1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCa1.Controls.Add(this.label6);
            this.pnlCa1.Controls.Add(this.panel2);
            this.pnlCa1.Controls.Add(this.panel1);
            this.pnlCa1.Controls.Add(this.panel3);
            this.pnlCa1.Controls.Add(this.clearBtn);
            this.pnlCa1.Controls.Add(this.btnLoad);
            this.pnlCa1.Controls.Add(this.dgvCaToi);
            this.pnlCa1.Controls.Add(this.label5);
            this.pnlCa1.Controls.Add(this.dgvCaChieu);
            this.pnlCa1.Controls.Add(this.label4);
            this.pnlCa1.Controls.Add(this.txtMaNV);
            this.pnlCa1.Controls.Add(this.label3);
            this.pnlCa1.Controls.Add(this.cbCalam);
            this.pnlCa1.Controls.Add(this.txtHoten);
            this.pnlCa1.Controls.Add(this.label2);
            this.pnlCa1.Controls.Add(this.label1);
            this.pnlCa1.Controls.Add(this.dgvCaSang);
            this.pnlCa1.Controls.Add(this.btnXoaCa1);
            this.pnlCa1.Controls.Add(this.btnSuaCa1);
            this.pnlCa1.Controls.Add(this.btnThemCa1);
            this.pnlCa1.Controls.Add(this.lbCaSang);
            this.pnlCa1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCa1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlCa1.Location = new System.Drawing.Point(1, 40);
            this.pnlCa1.Name = "pnlCa1";
            this.pnlCa1.Size = new System.Drawing.Size(983, 502);
            this.pnlCa1.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.DarkMagenta;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clearBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearBtn.Location = new System.Drawing.Point(770, 108);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(109, 46);
            this.clearBtn.TabIndex = 21;
            this.clearBtn.Text = "Làm mới";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoad.Location = new System.Drawing.Point(479, 172);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(87, 54);
            this.btnLoad.TabIndex = 20;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvCaToi
            // 
            this.dgvCaToi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaToi.Location = new System.Drawing.Point(501, 288);
            this.dgvCaToi.Name = "dgvCaToi";
            this.dgvCaToi.RowHeadersWidth = 51;
            this.dgvCaToi.RowTemplate.Height = 24;
            this.dgvCaToi.Size = new System.Drawing.Size(423, 184);
            this.dgvCaToi.TabIndex = 19;
            this.dgvCaToi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaToi_CellContentClick);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(497, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ca tối: 18h - 22h";
            // 
            // dgvCaChieu
            // 
            this.dgvCaChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaChieu.Location = new System.Drawing.Point(16, 288);
            this.dgvCaChieu.Name = "dgvCaChieu";
            this.dgvCaChieu.RowHeadersWidth = 51;
            this.dgvCaChieu.RowTemplate.Height = 24;
            this.dgvCaChieu.Size = new System.Drawing.Size(423, 184);
            this.dgvCaChieu.TabIndex = 17;
            this.dgvCaChieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaChieu_CellContentClick);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ca chiều: 13h - 17h";
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNV.Location = new System.Drawing.Point(619, 30);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(241, 20);
            this.txtMaNV.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã nhân viên";
            // 
            // cbCalam
            // 
            this.cbCalam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCalam.FormattingEnabled = true;
            this.cbCalam.Items.AddRange(new object[] {
            "Ca sáng",
            "Ca chiều",
            "Ca tối"});
            this.cbCalam.Location = new System.Drawing.Point(619, 108);
            this.cbCalam.Name = "cbCalam";
            this.cbCalam.Size = new System.Drawing.Size(109, 27);
            this.cbCalam.TabIndex = 13;
            // 
            // txtHoten
            // 
            this.txtHoten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoten.Location = new System.Drawing.Point(620, 69);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(241, 20);
            this.txtHoten.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ca làm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ Tên";
            // 
            // dgvCaSang
            // 
            this.dgvCaSang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaSang.Location = new System.Drawing.Point(16, 42);
            this.dgvCaSang.Name = "dgvCaSang";
            this.dgvCaSang.RowHeadersWidth = 51;
            this.dgvCaSang.RowTemplate.Height = 24;
            this.dgvCaSang.Size = new System.Drawing.Size(423, 184);
            this.dgvCaSang.TabIndex = 5;
            this.dgvCaSang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaSang_CellContentClick);
            // 
            // btnXoaCa1
            // 
            this.btnXoaCa1.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnXoaCa1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCa1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoaCa1.Location = new System.Drawing.Point(608, 172);
            this.btnXoaCa1.Name = "btnXoaCa1";
            this.btnXoaCa1.Size = new System.Drawing.Size(87, 54);
            this.btnXoaCa1.TabIndex = 9;
            this.btnXoaCa1.Text = "Xóa";
            this.btnXoaCa1.UseVisualStyleBackColor = false;
            this.btnXoaCa1.Click += new System.EventHandler(this.btnXoaCa1_Click);
            // 
            // btnSuaCa1
            // 
            this.btnSuaCa1.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnSuaCa1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCa1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuaCa1.Location = new System.Drawing.Point(728, 172);
            this.btnSuaCa1.Name = "btnSuaCa1";
            this.btnSuaCa1.Size = new System.Drawing.Size(87, 54);
            this.btnSuaCa1.TabIndex = 8;
            this.btnSuaCa1.Text = "Sửa";
            this.btnSuaCa1.UseVisualStyleBackColor = false;
            this.btnSuaCa1.Click += new System.EventHandler(this.btnSuaCa1_Click);
            // 
            // btnThemCa1
            // 
            this.btnThemCa1.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnThemCa1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCa1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemCa1.Location = new System.Drawing.Point(841, 172);
            this.btnThemCa1.Name = "btnThemCa1";
            this.btnThemCa1.Size = new System.Drawing.Size(87, 54);
            this.btnThemCa1.TabIndex = 7;
            this.btnThemCa1.Text = "Thêm";
            this.btnThemCa1.UseVisualStyleBackColor = false;
            this.btnThemCa1.Click += new System.EventHandler(this.btnThemCa1_Click);
            // 
            // lbCaSang
            // 
            this.lbCaSang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaSang.Location = new System.Drawing.Point(12, 16);
            this.lbCaSang.Name = "lbCaSang";
            this.lbCaSang.Size = new System.Drawing.Size(190, 23);
            this.lbCaSang.TabIndex = 0;
            this.lbCaSang.Text = "Ca sáng: 8h - 12h";
            // 
            // dtpkDate
            // 
            this.dtpkDate.CalendarFont = new System.Drawing.Font("UTM Aircona", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Location = new System.Drawing.Point(346, 9);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(263, 22);
            this.dtpkDate.TabIndex = 2;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(619, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 1);
            this.panel3.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(620, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 1);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(619, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 1);
            this.panel2.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UTM Aircona", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label6.Location = new System.Drawing.Point(13, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Design by Group 5";
            // 
            // DangKyLichlam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(982, 540);
            this.Controls.Add(this.dtpkDate);
            this.Controls.Add(this.pnlCa1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangKyLichlam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dang Ky Lich Lam";
            this.AutoValidateChanged += new System.EventHandler(this.Form2_AutoValidateChanged);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlCa1.ResumeLayout(false);
            this.pnlCa1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaToi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaChieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaSang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCa1;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Label lbCaSang;
        private System.Windows.Forms.Button btnXoaCa1;
        private System.Windows.Forms.Button btnSuaCa1;
        private System.Windows.Forms.Button btnThemCa1;
        private System.Windows.Forms.ComboBox cbCalam;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCaSang;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCaToi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCaChieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
    }
}