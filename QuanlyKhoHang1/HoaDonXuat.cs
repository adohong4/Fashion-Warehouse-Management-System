using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanlyKhoHang1
{
    public partial class HoaDonXuat : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=ADMIN\\SQLEXPRESS ;Initial Catalog=DoAnC#_QuanLyKhoHang;Integrated Security=SSPI";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        

        public HoaDonXuat()
        {
            InitializeComponent();
            fillcbKhachhang();
            fillcbNhanvien(); 
           // fillcbDVVC();
            
        }

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HoadonXuat ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        public void fillcbKhachhang()
        {
            connection = new SqlConnection(str);
            string sql = "select * from KhachHang";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader myreader;
            try
            {
                connection.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(0);
                    cbKhachhang.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillcbNhanvien()
        {
            connection = new SqlConnection(str);
            string sql = "select * from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader myreader;
            try
            {
                connection.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(0);
                    cbNhanvien.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSHD.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            txtSHD.Text = dgv.Rows[i].Cells[0].Value.ToString();
            cbKhachhang.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cbNhanvien.Text = dgv.Rows[i].Cells[2].Value.ToString();
            cbDVVC.Text = dgv.Rows[i].Cells[3].Value.ToString();
            String date = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HoadonXuat values('" + txtSHD.Text + "','" + cbKhachhang.Text + "','" + cbNhanvien.Text + "','" + cbDVVC.Text + "','" + this.date.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update HoadonXuat set SoHDX = '" + txtSHD.Text + "', MaKH = '" + cbKhachhang.Text + "', MaNV = '" + cbNhanvien.Text + "', MaDVVC = '" + cbDVVC.Text + "', Ngayxuat = '" + this.date.Text + "' where SoHDX = '" + txtSHD.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from HoadonXuat where SoHDX = '" + txtSHD.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSHD.Text = "";
            cbKhachhang.Text = "";
            cbNhanvien.Text = "";
            cbDVVC.Text = "";
            this.date.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM HoadonXuat WHERE SoHDX LIKE '%" + txtSearch.Text.Trim() + "%'";
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(str))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(table);
                }
            }
            dgv.DataSource = table;
        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {
            ChitietHDX chitietHDX = new ChitietHDX();
            chitietHDX.Show();
        }
    }
}
