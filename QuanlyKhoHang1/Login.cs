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
    public partial class Login : Form
    {
        private const string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=DoAnC#_QuanLyKhoHang;Integrated Security=True";

        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            comboBoxposition.SelectedIndexChanged += comboBoxposition_SelectedIndexChanged;
            CheckRegisterButtonState();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBoxposition_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckRegisterButtonState();
        }

        private void CheckRegisterButtonState()
        {
            if (comboBoxposition.SelectedItem != null && !string.IsNullOrEmpty(textBoxusername.Text) && !string.IsNullOrEmpty(textBoxpassword.Text))
            {
                string selectedPosition = comboBoxposition.SelectedItem.ToString();
                if (selectedPosition.Equals("Quản Lý"))
                {
                    buttonregister.Enabled = true;
                }
                else
                {
                    buttonregister.Enabled = false;
                }
            }
            else
            {
                buttonregister.Enabled = false;
            }
        }



        private void buttonregister_Click(object sender, EventArgs e)
        {
            DangKy formKDangKy = new DangKy();
            formKDangKy.Show();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text;
            string password = textBoxpassword.Text;
            string role = comboBoxposition.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Account WHERE taikhoan=@Username AND matkhau=@Password AND chucvu=@Role";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", role);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count == 1)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        if (role == "Nhân viên")
                        {
                            ChonNgay chonNgay = new ChonNgay();
                            chonNgay.Show();
                            this.Hide();
                        }
                        else if (role == "Kiểm Kho")
                        {
                            FormKiemKho formKiemKho = new FormKiemKho();
                            formKiemKho.Show();
                            this.Hide();
                        }
                        else if (role == "Quản Lý")
                        {
                            AdminForm adminform = new AdminForm();
                            adminform.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Chức vụ không hợp lệ!");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập, mật khẩu hoặc chức vụ không đúng!");
                    }
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
