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
    public partial class Khachhang : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=ADMIN\\SQLEXPRESS ;Initial Catalog=DoAnC#_QuanLyKhoHang;Integrated Security=SSPI";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        public Khachhang()
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
            txtMKH.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            txtMKH.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtKH.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtSDT.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txtDiachi.Text = dgv.Rows[i].Cells[3].Value.ToString();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into KhachHang values('" + txtMKH.Text + "','" + txtKH.Text + "','" + txtSDT.Text + "','" + txtDiachi.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update KhachHang set MaKH = '" + txtMKH.Text + "', TenKH = '" + txtKH.Text + "', Phone = '" + txtSDT.Text + "', DiaChi = '" + txtDiachi.Text + "' where MaKH = '" + txtMKH.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from KhachHang where MaKH = '" + txtMKH.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMKH.Text = "";
            txtKH.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Khachhang_FormClosing(object sender, FormClosingEventArgs e)
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
            string query = "SELECT * FROM KhachHang WHERE MaKH LIKE '%" + txtSearch.Text.Trim() + "%'";
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

        private void brnHuy_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
