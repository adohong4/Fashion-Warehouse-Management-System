using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKhoHang1
{
    public partial class DangKyLichlam : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=ADMIN\\SQLEXPRESS ;Initial Catalog=DoAnC#_QuanLyKhoHang;Integrated Security=SSPI";
        SqlDataAdapter adapter = new SqlDataAdapter();
        int CurrentUserId = 0;
        void loaddataCaSang()
        {
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = $"select * from DangKyLichLamViec where CaLam = N'Ca sáng' and NgayLamViec = '{this.Date.ToString("yyyy-MM-dd")}'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvCaSang.DataSource = table;
            
        }
        void loaddataCaChieu()
        {
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = $"select * from DangKyLichLamViec where CaLam = N'Ca chiều' and NgayLamViec = '{this.Date.ToString("yyyy-MM-dd")}' ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvCaChieu.DataSource = table;

        }

        void loaddataCaToi()
        {
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = $"select * from DangKyLichLamViec where CaLam = N'Ca tối'  and NgayLamViec = '{this.Date.ToString("yyyy-MM-dd")}'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvCaToi.DataSource = table;

        }

        private DateTime date;

        public DateTime Date { get => date; set => date = value; }

        public DangKyLichlam(DateTime date)
        {
            InitializeComponent();

            this.Date = date;

            dtpkDate.Value = Date;

        }

        private int GetDuplicate()
        {
            command = connection.CreateCommand();
            command.CommandText = $"select * from DangKyLichLamViec where CaLam = N'{cbCalam.SelectedItem}' " +
                $"and NgayLamViec = '{this.Date.ToString("yyyy-MM-dd")}'" +
                $"and MaNV = N'{txtMaNV.Text}'";
            using(var reader = command.ExecuteReader())
            {
                if(reader.Read())
                {
                    return reader.GetInt32(4);
                }

                return 0;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        void ShowJobByDate(DateTime date)
        {
            
        }
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void Form2_AutoValidateChanged(object sender, EventArgs e)
        {

        }

        private void LoadData(DataGridView gridView)
        {
            txtMaNV.ReadOnly = true;
            txtHoten.ReadOnly = true;
            int i;
            i = gridView.CurrentRow.Index;
            CurrentUserId = Int32.Parse(gridView.Rows[i].Cells[4].Value.ToString());
            txtMaNV.Text = gridView.Rows[i].Cells[0].Value.ToString();
            txtHoten.Text = gridView.Rows[i].Cells[1].Value.ToString();
            cbCalam.Text = gridView.Rows[i].Cells[2].Value.ToString();
            cbCalam.SelectedIndex = cbCalam.FindStringExact(cbCalam.Text.Trim());
        }

        private void dgvCaSang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData(dgvCaSang);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            LoadAllTable();
        }

        private void LoadAllTable()
        {
            loaddataCaToi();
            loaddataCaSang();
            loaddataCaChieu();
            ClearInput();
        }

        private void dgvCaChieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData(dgvCaChieu);
        }

        private void dgvCaToi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData(dgvCaToi);
        }

        private void btnThemCa1_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                MessageBox.Show("Input invalid");
                return;
            }

            if(GetDuplicate() > 0)
            {
                MessageBox.Show("Duplicate");
                return;
            }

            command = connection.CreateCommand();
            command.CommandText = $"insert into DangKyLichLamViec(MaNV, HoTen, CaLam, NgayLamViec) values(N'{txtMaNV.Text}', N'{txtHoten.Text}', N'{cbCalam.SelectedItem}', '{this.Date.ToString("yyyy-MM-dd")}')";
            command.ExecuteNonQuery();

            LoadAllTable();
        }

        private void Delete()
        {
            if(CurrentUserId == 0)
            {
                MessageBox.Show("Pls select a user to delete");
                return;
            }

            command = connection.CreateCommand();
            command.CommandText = $"delete from DangKyLichLamViec where Id = " + CurrentUserId;
            command.ExecuteNonQuery();

            LoadAllTable();
        }

        private void ClearInput()
        {
            txtHoten.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            txtHoten.ReadOnly = false;
            txtMaNV.ReadOnly = false;
            cbCalam.Text = string.Empty;
            cbCalam.SelectedIndex = -1;
            CurrentUserId = 0;
        }

        private bool CheckInput()
        {
            return !(string.IsNullOrEmpty(txtHoten.Text) || string.IsNullOrEmpty(txtMaNV.Text) || cbCalam.SelectedItem == null);
        }

        private void btnSuaCa1_Click(object sender, EventArgs e)
        {
            if(CurrentUserId == 0)
            {
                MessageBox.Show("Pls select a user to edit");
                return;
            }

            int id = GetDuplicate();
            if (id > 0)
            {
                MessageBox.Show("Duplicate");
                return;
            }
            if(cbCalam.SelectedItem == null)
            {
                MessageBox.Show("Please select ca lam");
                return;
            }

            command = connection.CreateCommand();
            command.CommandText = $"update DangKyLichLamViec set CaLam = N'{cbCalam.SelectedItem}' where Id = {CurrentUserId} ";
            command.ExecuteNonQuery();

            LoadAllTable();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btnXoaCa1_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
