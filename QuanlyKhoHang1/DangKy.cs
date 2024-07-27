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
    public partial class DangKy : Form
    {
        private string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=DoAnC#_QuanLyKhoHang;Integrated Security=True";
        public DangKy()
        {
            InitializeComponent();
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text;
            string password = textBoxpassword.Text;
            string confirmPassword = textBoxConfirm.Text;
            string role = comboBoxposition.Text;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) &&
                !string.IsNullOrEmpty(confirmPassword) && !string.IsNullOrEmpty(role))
            {
                if (password == confirmPassword)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "INSERT INTO Account (taikhoan, matkhau, chucvu) VALUES (@Username, @Password, @Role)";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Username", username);
                                command.Parameters.AddWithValue("@Password", password);
                                command.Parameters.AddWithValue("@Role", role);
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Thêm tài khoản thành công!");
                                }
                                else
                                {
                                    MessageBox.Show("Thêm tài khoản thất bại!");
                                }
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Đăng ký thành công!");
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp. Vui lòng nhập lại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký.");
            }
        }


        private void labelpassword_Click(object sender, EventArgs e)
        {

        }

        private void labelconfirm_Click(object sender, EventArgs e)
        {

        }

        private void buttonchangepass_Click(object sender, EventArgs e)
        {
            Doimatkhau doiMatKhauForm = new Doimatkhau();
            doiMatKhauForm.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
