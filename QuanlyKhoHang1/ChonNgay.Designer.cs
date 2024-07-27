namespace QuanlyKhoHang1
{
    partial class ChonNgay
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSu = new System.Windows.Forms.Button();
            this.btnSa = new System.Windows.Forms.Button();
            this.btnFri = new System.Windows.Forms.Button();
            this.btnTh = new System.Windows.Forms.Button();
            this.btnWed = new System.Windows.Forms.Button();
            this.btnTue = new System.Windows.Forms.Button();
            this.btnMon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 547);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnback);
            this.panel4.Controls.Add(this.btnNextMonth);
            this.panel4.Controls.Add(this.btnLastMonth);
            this.panel4.Controls.Add(this.btnToday);
            this.panel4.Controls.Add(this.dtpkDate);
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(720, 29);
            this.panel4.TabIndex = 1;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(108, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(82, 25);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "Quay Lại";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextMonth.Location = new System.Drawing.Point(631, 1);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(82, 25);
            this.btnNextMonth.TabIndex = 3;
            this.btnNextMonth.Text = "Tháng sau";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastMonth.Location = new System.Drawing.Point(6, 4);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(82, 25);
            this.btnLastMonth.TabIndex = 2;
            this.btnLastMonth.Text = "Tháng trước";
            this.btnLastMonth.UseVisualStyleBackColor = true;
            this.btnLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(518, 2);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(92, 26);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(210, 2);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(284, 22);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlMatrix);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 515);
            this.panel2.TabIndex = 0;
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.Location = new System.Drawing.Point(3, 54);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(710, 458);
            this.pnlMatrix.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSu);
            this.panel3.Controls.Add(this.btnSa);
            this.panel3.Controls.Add(this.btnFri);
            this.panel3.Controls.Add(this.btnTh);
            this.panel3.Controls.Add(this.btnWed);
            this.panel3.Controls.Add(this.btnTue);
            this.panel3.Controls.Add(this.btnMon);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 45);
            this.panel3.TabIndex = 0;
            // 
            // btnSu
            // 
            this.btnSu.Location = new System.Drawing.Point(623, 0);
            this.btnSu.Name = "btnSu";
            this.btnSu.Size = new System.Drawing.Size(87, 45);
            this.btnSu.TabIndex = 6;
            this.btnSu.Text = "Chủ nhật";
            this.btnSu.UseVisualStyleBackColor = true;
            // 
            // btnSa
            // 
            this.btnSa.Location = new System.Drawing.Point(520, 0);
            this.btnSa.Name = "btnSa";
            this.btnSa.Size = new System.Drawing.Size(87, 45);
            this.btnSa.TabIndex = 5;
            this.btnSa.Text = "Thứ 7";
            this.btnSa.UseVisualStyleBackColor = true;
            // 
            // btnFri
            // 
            this.btnFri.Location = new System.Drawing.Point(415, 0);
            this.btnFri.Name = "btnFri";
            this.btnFri.Size = new System.Drawing.Size(87, 45);
            this.btnFri.TabIndex = 4;
            this.btnFri.Text = "Thứ 6";
            this.btnFri.UseVisualStyleBackColor = true;
            // 
            // btnTh
            // 
            this.btnTh.Location = new System.Drawing.Point(311, 0);
            this.btnTh.Name = "btnTh";
            this.btnTh.Size = new System.Drawing.Size(87, 45);
            this.btnTh.TabIndex = 3;
            this.btnTh.Text = "Thứ 5";
            this.btnTh.UseVisualStyleBackColor = true;
            // 
            // btnWed
            // 
            this.btnWed.Location = new System.Drawing.Point(207, 0);
            this.btnWed.Name = "btnWed";
            this.btnWed.Size = new System.Drawing.Size(87, 45);
            this.btnWed.TabIndex = 2;
            this.btnWed.Text = "Thứ 4";
            this.btnWed.UseVisualStyleBackColor = true;
            // 
            // btnTue
            // 
            this.btnTue.Location = new System.Drawing.Point(105, 0);
            this.btnTue.Name = "btnTue";
            this.btnTue.Size = new System.Drawing.Size(87, 45);
            this.btnTue.TabIndex = 1;
            this.btnTue.Text = "Thứ 3";
            this.btnTue.UseVisualStyleBackColor = true;
            // 
            // btnMon
            // 
            this.btnMon.Location = new System.Drawing.Point(3, 0);
            this.btnMon.Name = "btnMon";
            this.btnMon.Size = new System.Drawing.Size(87, 45);
            this.btnMon.TabIndex = 0;
            this.btnMon.Text = "Thứ 2";
            this.btnMon.UseVisualStyleBackColor = true;
            // 
            // ChonNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(753, 571);
            this.Controls.Add(this.panel1);
            this.Name = "ChonNgay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangkyCalamviec";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Button btnSu;
        private System.Windows.Forms.Button btnSa;
        private System.Windows.Forms.Button btnFri;
        private System.Windows.Forms.Button btnTh;
        private System.Windows.Forms.Button btnWed;
        private System.Windows.Forms.Button btnTue;
        private System.Windows.Forms.Button btnMon;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Button btnback;
    }
}

