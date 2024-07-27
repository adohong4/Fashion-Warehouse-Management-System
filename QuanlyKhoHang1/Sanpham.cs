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
    public partial class Sanpham : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=ADMIN\\SQLEXPRESS ;Initial Catalog=DoAnC#_QuanLyKhoHang;Integrated Security=SSPI";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand(); 

            command.CommandText = "select * from HangHoa ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public Sanpham()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMSP.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            txtMSP.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtSP.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cbPhanloai.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txtGiasp.Text = dgv.Rows[i].Cells[3].Value.ToString();
            txtSLuong.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HangHoa values('" + txtMSP.Text + "','" + txtSP.Text + "','" +cbPhanloai.Text + "','" + txtGiasp.Text + "','" + txtSLuong.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update HangHoa set MaSP = '" + txtMSP.Text + "', TenSP = '" + txtSP.Text + "', PhanLoai = '" + cbPhanloai.Text + "', GiaSP = '" + txtGiasp.Text + "', Soluong = '" + txtSLuong.Text + "' where MaSP = '" + txtMSP.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from HangHoa where MaSP = '" + txtMSP.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMSP.Text = "";
            txtSP.Text = "";
            cbPhanloai.Text = "";
            txtGiasp.Text = "";
            txtSLuong.Text = "";
        }

        private void Sanpham_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch { };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM HangHoa WHERE MaSP LIKE '%" + txtSearch.Text.Trim() + "%'";
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
