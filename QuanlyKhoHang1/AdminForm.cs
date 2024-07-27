using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using OfficeOpenXml;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace QuanlyKhoHang1
{
    public partial class AdminForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=DoAnC#_QuanLyKhoHang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        //Load bảng nhân viên
        private void LoadData(string query)
        {
            try
            {
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
                                dgv.DataSource = table;
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

        public AdminForm()
        {
            InitializeComponent();
        }

        private void pictureBoxback1_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Close();
        }

        private void pictureBoxback2_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Close();
        }

        private void tabControltke_Click(object sender, EventArgs e)
        {
            if (tabControltke.SelectedTab == tabPagenhanvien)
            {
                ChonNgay chonNgay = new ChonNgay();
                chonNgay.Show();
            }
            else if (tabControltke.SelectedTab == tabPagekiemkho)
            {
                FormKiemKho formKiemKho = new FormKiemKho();
                formKiemKho.Show();
            }
            else if (tabControltke.SelectedTab == tabPageNhanSu)
            {
                NhanSu nhanSu = new NhanSu();
                nhanSu.Show();
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonloc_Click(object sender, EventArgs e)
        {
            string query = ""; // Biến lưu trữ câu truy vấn SQL

            if (btnNhanvien.Checked)
            {
                query = "SELECT * FROM NhanVien";
            }
            else if (btnKhachhang.Checked)
            {
                query = "SELECT * FROM KhachHang";
            }
            else if (btnKhachhang.Checked)
            {
                query = "SELECT * FROM KhachHang";
            }
            else if (btnLichlamviec.Checked)
            {
                query = "SELECT * FROM DangKyLichLamViec";
            }
            else if (btnhoadon.Checked)
            {
                query = "SELECT * FROM HoadonNhap";
            }
            else if (btnsanpham.Checked)
            {
                query = "SELECT * FROM HangHoa";
            }

            LoadData(query);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnNhanvien.Checked = false;
            btnKhachhang.Checked = false;
            btnLichlamviec.Checked = false;
            btnsanpham.Checked = false;
            btnhoadon.Checked = false;
        }
        private void buttonxuat_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage excelPackage = new ExcelPackage();
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                int rowStart = 1;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    int col = 1;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        worksheet.Cells[rowStart, col].Value = cell.Value?.ToString() ?? "";
                        col++;
                    }
                    rowStart++;
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(file);
                    MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private BindingSource bindingSource = new BindingSource();

        private void Form_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = dgv.DataSource;
            dgv.DataSource = bindingSource;
        }

        private void buttontim_Click(object sender, EventArgs e)
        {
            string keyword = textBoxtimkiem.Text.Trim();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataGridViewCell firstCell = row.Cells[0]; // Lấy cell của cột đầu tiên
                if (firstCell.Value != null && firstCell.Value.ToString().Contains(keyword))
                {
                    row.Selected = true;
                    dgv.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonhienthi_Click(object sender, EventArgs e)
        {
            if (radioButton1kh.Checked)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(str))
                    {
                        connection.Open();
                        string query = "SELECT MONTH(Ngayxuat) AS Thang, COUNT(*) AS SoLuong FROM HoadonXuat GROUP BY MONTH(Ngayxuat)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            chart1.DataSource = table;
                            chart1.Series.Add("Khách Hàng");
                            chart1.Series[0].XValueMember = "Thang"; 
                            chart1.Series[0].YValueMembers = "SoLuong"; 
                            chart1.Series[0].Name = "Khách Hàng"; 
                            chart1.Series[0].ChartType = SeriesChartType.Column;
                            chart1.DataBind();
                        }
                    }
                }
                catch { }
            }
            else if (radioButtonhoadon.Checked)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(str))
                    {
                        connection.Open();
                        string queryNhap = "SELECT MONTH(Ngaynhap) AS Thang, COUNT(*) AS SoLuong FROM HoadonNhap GROUP BY MONTH(Ngaynhap)";
                        string queryXuat = "SELECT MONTH(Ngayxuat) AS Thang, COUNT(*) AS SoLuong FROM HoadonXuat GROUP BY MONTH(Ngayxuat)";
                        using (SqlCommand commandNhap = new SqlCommand(queryNhap, connection))
                        using (SqlCommand commandXuat = new SqlCommand(queryXuat, connection))
                        {
                            SqlDataAdapter adapterNhap = new SqlDataAdapter(commandNhap);
                            SqlDataAdapter adapterXuat = new SqlDataAdapter(commandXuat);
                            DataTable tableNhap = new DataTable();
                            DataTable tableXuat = new DataTable();
                            adapterNhap.Fill(tableNhap);
                            adapterXuat.Fill(tableXuat);
                            Series seriesNhap = chart1.Series.Add("Hóa Đơn Nhập");
                            seriesNhap.Points.DataBind(tableNhap.AsEnumerable(), "Thang", "SoLuong", "");
                            seriesNhap.ChartType = SeriesChartType.Line;
                            seriesNhap.Color = Color.Blue;
                            Series seriesXuat = chart1.Series.Add("Hóa Đơn Xuất");
                            seriesXuat.Points.DataBind(tableXuat.AsEnumerable(), "Thang", "SoLuong", "");
                            seriesXuat.ChartType = SeriesChartType.Line;
                            seriesXuat.Color = Color.Red;
                            chart1.DataBind();
                        }
                    }
                }
                catch { }
            }
            else if (radioButtonsp.Checked)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(str))
                    {
                        connection.Open();
                        string querysp = "SELECT Phanloai, SUM(SoluongSP) AS SoLuong FROM HangHoa GROUP BY Phanloai";
                        using (SqlCommand command = new SqlCommand(querysp, connection))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            chart1.DataSource = table;
                            chart1.Series[0].XValueMember = "Phanloai"; 
                            chart1.Series[0].YValueMembers = "SoLuong"; 
                            chart1.Series[0].ChartType = SeriesChartType.Pie;
                            chart1.DataBind();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

            private void buttonhuy_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }

        private void radioButton1kh_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButtonhoadon_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void tabPagenhansu_Click(object sender, EventArgs e)
        {

        }
    }
}