using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKhoHang1
{
    public partial class FormKiemKho : Form
    {
        public FormKiemKho()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           Login login = new Login();
           login.Show();
            this.Close();
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            try
            {
                Khachhang formKhachHang = new Khachhang();
                formKhachHang.ShowDialog();
            }
            catch  { }
        }

        private void btnsanpham_Click(object sender, EventArgs e)
        {
            try
            {
                Sanpham formSanpham = new Sanpham();
                formSanpham.ShowDialog();
            }
            catch { }
        }

        private void btnHDN_Click(object sender, EventArgs e)
        {
            HoaDonNhap formhoadonnhap = new HoaDonNhap();
            formhoadonnhap.ShowDialog();
        }

        private void btnHDX_Click(object sender, EventArgs e)
        {
            HoaDonXuat formhoadonxuat = new HoaDonXuat();
            formhoadonxuat.ShowDialog();
        }
    }
}
