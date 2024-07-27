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

namespace QuanlyKhoHang1
{
    public partial class HoaDonNhap : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=ADMIN\\SQLEXPRESS ;Initial Catalog=DoAnC#_QuanLyKhoHang;Integrated Security=SSPI";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public HoaDonNhap()
        {
            InitializeComponent();
            fillcbHangHoa();
            fillcbNhanvien();
        }
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HoadonNhap ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        public void fillcbHangHoa()
        {
            connection = new SqlConnection(str);
            string sql = "select * from HangHoa";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader myreader;
            try
            {
                connection.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(0);
                    cbMaSP.Items.Add(sname);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSHD.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            txtSHD.Text = dgv.Rows[i].Cells[0].Value.ToString();
            cbNhanvien.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cbMaSP.Text = dgv.Rows[i].Cells[2].Value.ToString();
            String date = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HoadonNhap values('" + txtSHD.Text + "','" + cbMaSP.Text + "','" + cbNhanvien.Text + "','" + this.date.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update HoadonNhap set SoHDN = '" + txtSHD.Text + "', MaSP = '" + cbMaSP.Text + "', MaNV = '" + cbNhanvien.Text + "', Ngaynhap = '" + this.date.Text + "' where SoHDN = '" + txtSHD.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from HoadonNhap where SoHDN = '" + txtSHD.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSHD.Text = "";
            cbMaSP.Text = "";
            cbNhanvien.Text = "";
            this.date.Text = "";
            loaddata();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM HoadonNhap WHERE SoHDN LIKE '%" + txtSearch.Text.Trim() + "%'";
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

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            ChitietHDN chitietHDN = new ChitietHDN();
            chitietHDN.Show();
        }
    }
}
