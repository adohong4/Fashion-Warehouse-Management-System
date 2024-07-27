using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKhoHang1
{
    public partial class ChitietHDN : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=localhost\\SQLEXPRESS ;Initial Catalog=DoAnC#_QuanLyKhoHang;Integrated Security=SSPI";

        void loaddata()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select ctn.MaSP, hh.TenSP, hh.Phanloai, hh.GiaSP, ctn.SLNhap, (GiaSP*SLNhap) as Thanhtien from ChitietHDN ctn join HangHoa hh on ctn.MaSP = hh.MaSP where ctn.SoHDN = '" + cbHoadon.Text + "'; ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvHoaDonXuat.DataSource = table;

        }
        public ChitietHDN()
        {
            InitializeComponent();
            fillcbSoHDN();
            fillcbMaNV();
            fillcbMaHang();
        }
        public void fillcbSoHDN()
        {
            connection = new SqlConnection(str);
            string sql = "select * from HoadonNhap";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader myreader;
            try
            {
                connection.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sMa = myreader.GetString(0);
                    cbHoadon.Items.Add(sMa);
                }
                myreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
           
        }

        public void fillcbMaNV()
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
                    string sMa = myreader.GetString(0);
                    cbMNV.Items.Add(sMa);
                }
                myreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbMNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            string sql = "select * from NhanVien where MaNV = '" + cbMNV.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader myreader;
            try
            {
                connection.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string TenNV = myreader.GetString(1);
                    txtNV.Text = TenNV;
                }
                myreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void fillcbMaHang()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                string sql = "SELECT MaSP FROM HangHoa";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader myReader;
                try
                {
                    connection.Open();
                    myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        string sName = myReader.GetString(0);
                        cbMahang.Items.Add(sName);
                    }
                    myReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi điền ComboBox: " + ex.Message);
                }
            }

        }
        private void cbMahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMahang.SelectedIndex != -1)
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    string sql = "SELECT TenSP, PhanLoai, GiaSP FROM HangHoa WHERE MaSP = @MaSP";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@MaSP", cbMahang.SelectedItem.ToString());
                    SqlDataReader myReader;
                    try
                    {
                        connection.Open();
                        myReader = cmd.ExecuteReader();
                        if (myReader.Read())
                        {
                            txtTenhang.Text = myReader.GetString(0);
                            txtPhanloai.Text = myReader.GetString(1); 
                            txtDongia.Text = myReader.GetString(2);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin sản phẩm.");
                        }
                        myReader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
                    }
                }
            }
        }

        private void btnTimkiem_Click_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            string sql = "select hd.SoHDN, hd.Ngaynhap, nv.MaNV, nv.TenNV from Nhanvien nv join HoadonNhap hd on nv.MaNV = hd.MaNV where hd.SoHDN = '" + cbHoadon.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader myreader;
            try
            {
                connection.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string SoHDN = myreader.GetString(0);
                    string MaNV = myreader.GetString(2);
                    string TenNV = myreader.GetString(3);


                    txtMHD.Text = SoHDN;
                    cbMNV.Text = MaNV;
                    txtNV.Text = TenNV;

                }
                myreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loaddata();
        }

        private void dgvHoaDonXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvHoaDonXuat.CurrentRow.Index;
            cbMahang.Text = dgvHoaDonXuat.Rows[i].Cells[0].Value.ToString();
            txtTenhang.Text = dgvHoaDonXuat.Rows[i].Cells[1].Value.ToString();
            txtPhanloai.Text = dgvHoaDonXuat.Rows[i].Cells[2].Value.ToString();
            txtDongia.Text = dgvHoaDonXuat.Rows[i].Cells[3].Value.ToString();
            txtSoluong.Text = dgvHoaDonXuat.Rows[i].Cells[4].Value.ToString();
            txtThanhtien.Text = dgvHoaDonXuat.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT SoLuongSP FROM HangHoa WHERE MaSP = @MaSP";
                SqlCommand selectCommand = new SqlCommand(query, connection);
                selectCommand.Parameters.AddWithValue("@MaSP", cbMahang.Text);
                int soLuongHienTai = Convert.ToInt32(selectCommand.ExecuteScalar());

                int soLuongNhap = Convert.ToInt32(txtSoluong.Text);
                int soLuongMoi = soLuongHienTai + soLuongNhap;

                query = "UPDATE HangHoa SET SoLuongSP = @SoLuongMoi WHERE MaSP = @MaSP";
                SqlCommand updateCommand = new SqlCommand(query, connection);
                updateCommand.Parameters.AddWithValue("@SoLuongMoi", soLuongMoi);
                updateCommand.Parameters.AddWithValue("@MaSP", cbMahang.Text);
                updateCommand.ExecuteNonQuery();

                query = "INSERT INTO ChiTietHDN VALUES (@MaHD, @MaSP, @SoLuong)";
                SqlCommand insertCommand = new SqlCommand(query, connection);
                insertCommand.Parameters.AddWithValue("@MaHD", txtMHD.Text);
                insertCommand.Parameters.AddWithValue("@MaSP", cbMahang.Text);
                insertCommand.Parameters.AddWithValue("@SoLuong", txtSoluong.Text);
                insertCommand.ExecuteNonQuery();

                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chi tiết hóa đơn nhập: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "update HoadonNhap set MaNV = '" + cbMNV.Text + "',TongTien = '" + txtTongtien.Text + "' where SoHDN = '" + txtMHD.Text + "'";
                command.ExecuteNonQuery();
                MessageBox.Show("Đã lưu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi");
            }
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonXuat.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvHoaDonXuat.SelectedRows)
                {
                    string maSP = row.Cells["MaSP"].Value.ToString();
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(str))
                        {
                            connection.Open();
                            string sqlDelete = "DELETE FROM ChitietHDN WHERE MaSP = @MaSP"; 
                            SqlCommand cmd = new SqlCommand(sqlDelete, connection);
                            cmd.Parameters.AddWithValue("@MaSP", maSP);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                dgvHoaDonXuat.Rows.Remove(row);
                            }
                            else
                            {
                                MessageBox.Show("Không có dữ liệu nào được xóa từ cơ sở dữ liệu.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa dữ liệu từ cơ sở dữ liệu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            string sql = "select sum(GiaSP*SLNhap) as Thanhtien from ChitietHDN ctn join HangHoa hh on ctn.MaSP = hh.MaSP where ctn.SoHDN = '" + cbHoadon.Text + "';";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();

            object totalAmount = command.ExecuteScalar();
            txtTongtien.Text = totalAmount.ToString();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage excelPackage = new ExcelPackage();
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Hóa Đơn");
                worksheet.Cells.Style.Font.Name = "Times New Roman";
                worksheet.Cells["A1:F1"].Merge = true;
                worksheet.Cells[1, 1].Value = "HÓA ĐƠN NHẬP HÀNG CỦA CÔNG TY THỜI TRANG AVT";
                worksheet.Cells[9, 1].Value = "Mã sản phẩm";
                worksheet.Cells[9, 2].Value = "Tên sản phẩm ";
                worksheet.Cells[9, 3].Value = "Phân Loại";
                worksheet.Cells[9, 4].Value = "Đơn giá";
                worksheet.Cells[9, 5].Value = "Số Lượng Nhập";
                worksheet.Cells[9, 6].Value = "Thành Tiền";

                string tenNV = txtNV.Text;
                string maNV = cbMNV.Text;
                worksheet.Cells[3, 1].Value = "Mã Nhân Viên: "; worksheet.Cells[3, 2].Value = maNV;
                worksheet.Cells[4, 1].Value = "Tên Nhân Viên: "; worksheet.Cells[4, 2].Value = tenNV;
                DateTime currentTime = DateTime.Now;
                worksheet.Cells[5, 1].Value = "Ngày: "; worksheet.Cells[5, 2].Value = currentTime.ToShortDateString(); // Thêm ngày
                worksheet.Cells[6, 1].Value = "Giờ: "; worksheet.Cells[6, 2].Value = currentTime.ToShortTimeString(); // Thêm giờ
                int rowStart = 10; 
                foreach (DataGridViewRow row in dgvHoaDonXuat.Rows)
                {
                    int col = 1;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        worksheet.Cells[rowStart, col].Value = cell.Value?.ToString() ?? "";
                        col++;
                    }
                    rowStart++;
                }

                string tongTien = txtTongtien.Text;
                string LHD = txtNV.Text;
                worksheet.Cells[rowStart, 1].Value = "Tổng số tiền nhập hàng:";
                worksheet.Cells[rowStart, 2].Value = tongTien;
                worksheet.Cells[rowStart, 4].Value = "Người lập hóa đơn";
                worksheet.Cells[rowStart, 5].Value = LHD;
                worksheet.Cells.AutoFitColumns();
                using (ExcelRange range = worksheet.Cells["A1:F1"])
                {
                    range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Căn giữa nội dung
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.MediumGray;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                }
                using (ExcelRange range = worksheet.Cells["A9:F9"])
                {

                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                }
                using (ExcelRange range = worksheet.Cells["A15"])
                {

                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                }
                using (ExcelRange range = worksheet.Cells["D15"])
                {

                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                }
                using (ExcelRange range = worksheet.Cells["A3:B7"]) // Điều chỉnh từ ô A3 đến A7
                {
                    range.Style.Font.Italic = true;
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

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
