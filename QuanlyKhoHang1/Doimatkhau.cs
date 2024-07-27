using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanlyKhoHang1
{
    public partial class Doimatkhau : Form
    {
        private const string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=DoAnC#_QuanLyKhoHang;Integrated Security=True";
        public Doimatkhau()
        {
            InitializeComponent();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {

        }

        private void buttonchangepass_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text;
            string newPassword = textBoxnewpassword.Text;
            string selectedRole = comboBoxposition.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(selectedRole))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Account SET matkhau = @NewPassword WHERE taikhoan = @Username AND chucvu = @Role";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@NewPassword", newPassword);
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Role", selectedRole);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thay đổi mật khẩu thành công!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Không thể tìm thấy tài khoản hoặc chức vụ không đúng.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản và chọn chức vụ.");
            }
        }
    }
}
