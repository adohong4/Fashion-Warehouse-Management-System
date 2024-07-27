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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.Style;


namespace QuanlyKhoHang1
{
    public partial class ChitietHDX : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=localhost\\SQLEXPRESS ;Initial Catalog=DoAnC#_QuanLyKhoHang;Integrated Security=SSPI";
        
        public ChitietHDX()
        {
            InitializeComponent();
            fillcbMaHang();
            fillcbMaNV();
            fillcbMaKH();
            fillcbSoHDX();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }


        /*         COMBOBOX MÃ HÀNG       */
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
                            // Lấy thông tin sản phẩm từ cơ sở dữ liệu và gán cho các TextBox tương ứng
                            txtTenhang.Text = myReader.GetString(0);
                            txtPhanloai.Text = myReader.GetString(1); // Giả sử MaTheLoai là kiểu chuỗi, nếu không phải là chuỗi, bạn cần thay đổi cách xử lý này
                            txtDongia.Text = myReader.GetString(2); // Giả sử GiaSP là kiểu số nguyên, nếu không phải là số nguyên, bạn cần thay đổi cách xử lý này
                        }
                        else
                        {
                            // Hiển thị thông báo nếu không tìm thấy thông tin sản phẩm
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



        /*      DATAGRIDVIEW CHI TIẾT HÓA ĐƠN      */
        void loaddata()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select ctx.MaSP, hh.TenSP, hh.PhanLoai, hh.GiaSP, ctx.SL, (GiaSP*SL) as Thanhtien from ChitietHDX ctx join HangHoa hh on ctx.MaSP = hh.MaSP where ctx.SoHDX = '" + cbHoadon.Text + "'; ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvHoaDonXuat.DataSource = table;
            
        }

        void Tongtien()
        {

        }



        /*       COMBOBOX MÃ NHÂN VIÊN     */
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
        private void txtMNV_SelectedIndexChanged(object sender, EventArgs e)
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


        /*   COMBOBOX MA KHACH HANG */
        public void fillcbMaKH()
        {
            connection = new SqlConnection(str);
            string sql = "select * from KhachHang";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader myreader;
            try
            {
                connection.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sMa = myreader.GetString(0);
                    cbMaKH.Items.Add(sMa);
                }
                myreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            string sql = "select * from KhachHang where MaKH = '" + cbMaKH.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader myreader;
            try
            {
                connection.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string TenKhach = myreader.GetString(1);
                    string Diachi = myreader.GetString(3);
                    string Dienthoai = myreader.GetString(2);


                    txtTenKH.Text = TenKhach;
                    txtDiachi.Text = Diachi;
                    txtSDT.Text = Dienthoai;

                }
                myreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /*   COMBOBOX MÃ SỐ HÓA ĐƠN XUẤT    */
        public void fillcbSoHDX()
        {
            connection = new SqlConnection(str);
            string sql = "select * from HoadonXuat";
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

        private void cbHoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        /*          Tìm kiếm Hóa đơn          */
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            string sql = "select hd.SoHDX, hd.Ngayxuat, nv.MaNV, nv.TenNV, kh.MaKH, kh.TenKH, kh.DiaChi, kh.Phone from Nhanvien nv join HoadonXuat hd on nv.MaNV = hd.MaNV join KhachHang kh on hd.MaKH = kh.MaKH where hd.SoHDX = '" + cbHoadon.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader myreader;
            try
            {
                connection.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string SoHDX = myreader.GetString(0);
                    string MaNV = myreader.GetString(2);
                    string TenNV = myreader.GetString(3);
                    string MaKH = myreader.GetString(4);
                    string TenKH = myreader.GetString(5);
                    string Diachi = myreader.GetString(6);
                    string Phone = myreader.GetString(7);


                    txtMHD.Text = SoHDX;
                    cbMNV.Text = MaNV;
                    txtNV.Text = TenNV;
                    cbMaKH.Text = MaKH;
                    txtTenKH.Text = TenKH;
                    txtDiachi.Text = Diachi;
                    txtSDT.Text = Phone;
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
                int soLuongXuat = Convert.ToInt32(txtSoluong.Text);
                if (soLuongHienTai < soLuongXuat)
                {
                    MessageBox.Show("Số lượng trong kho không đủ để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int soLuongMoi = soLuongHienTai - soLuongXuat;
                if (soLuongMoi < 0)
                {
                    MessageBox.Show("Mặt hàng bạn chọn hiện tại đã hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                query = "UPDATE HangHoa SET SoLuongSP = @SoLuongMoi WHERE MaSP = @MaSP";
                SqlCommand updateCommand = new SqlCommand(query, connection);
                updateCommand.Parameters.AddWithValue("@SoLuongMoi", soLuongMoi);
                updateCommand.Parameters.AddWithValue("@MaSP", cbMahang.Text);
                updateCommand.ExecuteNonQuery();

                query = "INSERT INTO ChiTietHDX VALUES (@MaHD, @MaSP, @SoLuong)";
                SqlCommand insertCommand = new SqlCommand(query, connection);
                insertCommand.Parameters.AddWithValue("@MaHD", txtMHD.Text);
                insertCommand.Parameters.AddWithValue("@MaSP", cbMahang.Text);
                insertCommand.Parameters.AddWithValue("@SoLuong", txtSoluong.Text);
                insertCommand.ExecuteNonQuery();

                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chi tiết hóa đơn xuất: " + ex.Message);
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from ChitietHDX where SoHDX '" + txtMHD.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
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
                            string sqlDelete = "DELETE FROM ChitietHDX WHERE MaSP = @MaSP"; // Thay đổi bảng và điều kiện xóa nếu cần thiết
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
        
        private void btnSumTT_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            string sql = "select sum(GiaSP*SL) as Thanhtien from ChitietHDX ctx join HangHoa hh on ctx.MaSP = hh.MaSP where ctx.SoHDX = '" + cbHoadon.Text + "';";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();

            object totalAmount = command.ExecuteScalar();
            txtTongtien.Text = totalAmount.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "update HoadonXuat set MaNV = '" + cbMNV.Text + "',MaKH = '" + cbMaKH.Text + "',TongTien = '" + txtTongtien.Text + "' where SoHDX = '" + txtMHD.Text + "'";
                command.ExecuteNonQuery();
                MessageBox.Show("Đã lưu thành công");
            }catch (Exception ex)
            {
                MessageBox.Show("lỗi");
            }
            
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage excelPackage = new ExcelPackage();
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Hóa Đơn");
                worksheet.Cells.Style.Font.Name = "Times New Roman";
                worksheet.Cells["A1:F1"].Merge = true; 
                worksheet.Cells[1, 1].Value = "HÓA ĐƠN XUẤT HÀNG CỦA CÔNG TY THỜI TRANG AVT";
                worksheet.Cells[9, 1].Value = "Mã sản phẩm";
                worksheet.Cells[9, 2].Value = "Tên sản phẩm ";
                worksheet.Cells[9, 3].Value = "Phân Loại";
                worksheet.Cells[9, 4].Value = "Đơn giá";
                worksheet.Cells[9, 5].Value = "Số Lượng";
                worksheet.Cells[9, 6].Value = "Thành Tiền";
                string tenKH = txtTenKH.Text;
                string diachi = txtDiachi.Text;
                string sdt = txtSDT.Text;
                worksheet.Cells[3, 1].Value = "Tên khách hàng: "; worksheet.Cells[3, 2].Value = tenKH;
                worksheet.Cells[4, 1].Value = "Địa Chỉ: "; worksheet.Cells[4, 2].Value = diachi;
                worksheet.Cells[5, 1].Value = "Số Điện Thoại: "; worksheet.Cells[5, 2].Value = sdt;
                DateTime currentTime = DateTime.Now;
                worksheet.Cells[6, 1].Value = "Ngày: "; worksheet.Cells[6, 2].Value = currentTime.ToShortDateString(); // Thêm ngày
                worksheet.Cells[7, 1].Value = "Giờ: "; worksheet.Cells[7, 2].Value = currentTime.ToShortTimeString(); // Thêm giờ
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
                worksheet.Cells[rowStart, 1].Value = "Tổng số tiền cần thanh toán:";
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
                using (ExcelRange range = worksheet.Cells["A16"])
                {

                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                }
                using (ExcelRange range = worksheet.Cells["D16"])
                {

                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                }
                using (ExcelRange range = worksheet.Cells["A3:B7"])
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

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
