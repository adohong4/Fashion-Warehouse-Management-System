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
    public partial class NhanSu : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=DoAnC#_QuanLyKhoHang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM NhanVien"; 
                using (connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (command = new SqlCommand(query, connection))
                    {
                        using (adapter = new SqlDataAdapter(command))
                        {
                            using (table = new DataTable())
                            {
                                adapter.Fill(table);
                                dataGridView1.DataSource = table;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public NhanSu()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    if (string.IsNullOrWhiteSpace(txtMNV.Text) || string.IsNullOrWhiteSpace(txtNV.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin.");
                        return;
                    }

                    string query = "INSERT INTO NhanVien (MaNV, TenNV, NgaySinh, GioiTinh, DiaChi, SDT, ChucVu) " +
                                   "VALUES (@MaNV, @TenNV, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @ChucVu)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNV",txtMNV.Text );
                    command.Parameters.AddWithValue("@TenNV", txtNV.Text);
                    command.Parameters.AddWithValue("@NgaySinh", date.Value);
                    command.Parameters.AddWithValue("@GioiTinh", radiobtnnam.Checked ? "Nam" : "Nữ");
                    command.Parameters.AddWithValue("@DiaChi", txtDiachi.Text);
                    command.Parameters.AddWithValue("@SDT", txtPhone.Text);
                    command.Parameters.AddWithValue("@ChucVu", comboBoxChucVu.Text);
                    command.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Thêm nhân viên thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }

        private void NhanSu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMNV.Text = " ";
            txtNV.Text = " ";
            date.Value = DateTime.Now;
            radiobtnnam.Checked = false;
            radiobtnNu.Checked = false;
            txtDiachi.Text = " ";
            txtPhone.Text = " ";
            comboBoxChucVu.Text = " ";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string maNV = selectedRow.Cells["MaNV"].Value.ToString();
                    string tenNV = selectedRow.Cells["TenNV"].Value.ToString();
                    DateTime ngaySinh = (DateTime)selectedRow.Cells["NgaySinh"].Value;
                    string gioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString();
                    string diaChi = selectedRow.Cells["DiaChi"].Value.ToString();
                    string sdt = selectedRow.Cells["SDT"].Value.ToString();
                    string chucVu = selectedRow.Cells["ChucVu"].Value.ToString();

                    txtMNV.Text = maNV;
                    txtNV.Text = tenNV;
                    date.Value = ngaySinh;
                    if (gioiTinh == "Nam")
                        radiobtnnam.Checked = true;
                    else
                        radiobtnNu.Checked = true;
                    txtDiachi.Text = diaChi;
                    txtPhone.Text = sdt;
                    comboBoxChucVu.Text = chucVu;
                }
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string maNV = selectedRow.Cells["MaNV"].Value.ToString();

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(str))
                        {
                            connection.Open();
                            string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@MaNV", maNV);
                                command.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Xóa nhân viên thành công!");
                        LoadData(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maNV = selectedRow.Cells["MaNV"].Value.ToString();

                try
                {
                    using (SqlConnection connection = new SqlConnection(str))
                    {
                        connection.Open();
                        string query = "UPDATE NhanVien SET TenNV = @TenNV, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SDT = @SDT, ChucVu = @ChucVu WHERE MaNV = @MaNV";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TenNV", txtNV.Text);
                            command.Parameters.AddWithValue("@NgaySinh", date.Value);
                            command.Parameters.AddWithValue("@GioiTinh", radiobtnnam.Checked ? "Nam" : "Nữ");
                            command.Parameters.AddWithValue("@DiaChi", txtDiachi.Text);
                            command.Parameters.AddWithValue("@SDT", txtPhone.Text);
                            command.Parameters.AddWithValue("@ChucVu", comboBoxChucVu.Text);
                            command.Parameters.AddWithValue("@MaNV", maNV);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    LoadData(); // Tải lại dữ liệu sau khi cập nhật
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NhanVien WHERE MaNV LIKE '%" + txtSearch.Text.Trim() + "%'";
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(str))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(table);
                }
            }
            dataGridView1.DataSource = table;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
