using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BaiTapLonWinform
{
    public class modify

    {
        SqlDataAdapter adapter;
        SqlDataReader reader;
        SqlConnection connection = null;
        SqlCommand command;
        public modify()
        {

        }

        public List<quanly> quanlys(string query)
        {
            List<quanly> lists = new List<quanly>();
            using (connection = Conection.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lists.Add(new quanly(reader.GetString(0), reader.GetString(1)));
                }
                connection.Close();
            }
            return lists;
        }

            public List<Taikhoan> taikhoans(string query)
        {
            List<Taikhoan> list = new List<Taikhoan>();
            using (connection = Conection.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Taikhoan(reader.GetString(0), reader.GetString(1)));
                }
                connection.Close();
            }
            return list;
        }
        public void dangky(string query)// dùng để insert dữ liệu đăng ký tài khoản
        {
            using (SqlConnection sqlConnection = Conection.GetConnection())
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }
        public DataTable getAllData(string query) {
            DataTable dataTable = new DataTable();
            using (connection = Conection.GetConnection())
            {
                connection.Open();


                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);

                connection.Close();

            }

            return dataTable;

        }

        #region KhachHang   
        public bool ThemNhanVien(Khachhang khachhang)
        {
            string query = "insert into KHACHHANG values(@MAKH,@TENKH,@DIACHI,@SDT)";
            connection = Conection.GetConnection();
            try
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                command.Parameters.Add("@MAKH", SqlDbType.NVarChar).Value = khachhang.Id;
                command.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = khachhang.ten;
                command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = khachhang.diachi;
                command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = khachhang.sdt;
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public bool SuaNhanVien(Khachhang khachhang)
        {
            connection = Conection.GetConnection();
            string query = "update KHACHHANG set TENKH=@TENKH,DIACHI=@DIACHI, SDT=@SDT where MAKH=@MAKH";
            try {
                connection.Open();
                command = new SqlCommand(query, connection);
                
                command.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = khachhang.Id;
                command.Parameters.Add("@TENKH", SqlDbType.VarChar).Value = khachhang.ten;
                command.Parameters.Add("@DIACHI", SqlDbType.VarChar).Value = khachhang.diachi;
                command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = khachhang.sdt;
                command.ExecuteNonQuery();

            }
            catch {
                return false;

            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public DataTable TimKhachhang(string query)
        {
            DataTable data = new DataTable();
            using (connection = Conection.GetConnection())
            {
                connection.Open();
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();


            }
            
            return data;
        }
        #endregion NhanVien

        #region SanPham
        public  bool themSanpham(SanPham sanPham)
        {
            connection = Conection.GetConnection();
            string query = "insert into SANPHAM values(@MADT,@TENDT,@MANHOM,@GIABAN,@THOIGIANBAOHANH)";
            try
            {
                connection.Open();
                command=new SqlCommand(query, connection);
                command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = sanPham.MADT;
                command.Parameters.Add("@TENDT", SqlDbType.VarChar).Value = sanPham.TENDT;
                command.Parameters.Add("@MANHOM", SqlDbType.VarChar).Value = sanPham.MANHOM;
                
                command.Parameters.Add("@GIABAN", SqlDbType.VarChar).Value = sanPham.GIABAN;
                command.Parameters.Add("@THOIGIANBAOHANH", SqlDbType.VarChar).Value = sanPham.THOIGIANBAOHANH;
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;

            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public bool Suathongtinsanpham(SanPham sanPham)
        {
            connection = Conection.GetConnection();
            string query = "update SANPHAM set TENDT=@TENDT,MANHOM=@MANHOM,GIABAN=@GIABAN,THOIGIANBAOHANH=@THOIGIANBAOHANH where MADT=@MADT";
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = sanPham.MADT;
                command.Parameters.Add("@TENDT", SqlDbType.VarChar).Value = sanPham.TENDT;
                command.Parameters.Add("@MANHOM", SqlDbType.VarChar).Value = sanPham.MANHOM;
               
                command.Parameters.Add("@GIABAN", SqlDbType.VarChar).Value = sanPham.GIABAN;
                command.Parameters.Add("@THOIGIANBAOHANH", SqlDbType.VarChar).Value = sanPham.THOIGIANBAOHANH;
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;

        }
        public DataTable TimSanPham(string query)
        {
            DataTable data = new DataTable();
            using (connection = Conection.GetConnection())
            {
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
            }
            return data;
        }
        #endregion
        #region danhmuc
        public bool themdanhmuc(danhmuc danhmuc)
        {
            connection = Conection.GetConnection();
            string query = "insert into NHOMHANG values(@MANHOM,@TENNHOM)";
            try
            {
                connection.Open();
            command=new SqlCommand(query, connection);
                command.Parameters.Add("@MANHOM", SqlDbType.VarChar).Value = danhmuc.madanhmuc;
             
                command.Parameters.Add("@TENNHOM", SqlDbType.VarChar).Value = danhmuc.tendanhmuc;
                command.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public bool xoadanhmuc(string madanhmuc)
        {
            connection = Conection.GetConnection();
            string query = "delete  from NHOMHANG where MANHOM=@MANHOM";
            try
            {
                connection.Open();
                command=new SqlCommand(query,connection);
                command.Parameters.Add("@MANHOM",SqlDbType.VarChar).Value= madanhmuc;
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;

        }
        public bool suadanhmuc(danhmuc danhmuc)
        {
            connection = Conection.GetConnection();
            string query = "update  NHOMHANG set TENNHOM=@TENNHOM where MANHOM=@MANHOM";
            try
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                command.Parameters.Add("@MANHOM", SqlDbType.VarChar).Value = danhmuc.madanhmuc;
             
                command.Parameters.Add("@TENNHOM", SqlDbType.VarChar).Value = danhmuc.tendanhmuc;
                command.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        

    }
        #endregion danhmuc
        #region hoadon
        
        public bool laphoadon(hoadon hoadon)
        {
            connection = Conection.GetConnection();
            string query = "update PHIEUBH set MADT=@MADT,MAKH=@MAKH,DIACHI=@DIACHI,NGAYMUA=@NGAYMUA,NGAYHETHAN=@NGAYHETHAN where SOBH=@SOBH";
            try
            {
                connection.Open();
                command=new SqlCommand(query, connection);
                command.Parameters.Add("@SOBH", SqlDbType.VarChar).Value = hoadon.mahoadon;
                command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = hoadon.madt;
                command.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = hoadon.makh;
                command.Parameters.Add("@DIACHI", SqlDbType.VarChar).Value = hoadon.diachi;
                command.Parameters.Add("@NGAYMUA", SqlDbType.DateTime).Value= hoadon.ngaymua;
                command.Parameters.Add("@NGAYHETHAN", SqlDbType.DateTime).Value = hoadon.ngayhethanbaohanh;
                command.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        #endregion hoadon
        #region Nhanvien
        public bool themNhanVien(NhanVien nhanVien)
        {
            connection = Conection.GetConnection();
            string query = "insert into NHANVIEN values(@MANV,@TENNV,@DIACHI,@SDT,@CMND,@NGAYSINH,@GIOITINH,@CHUCVU,@LUONG)";
            try
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                command.Parameters.Add("@MANV", SqlDbType.VarChar).Value = nhanVien.MANV;
                command.Parameters.Add("@TENNV ", SqlDbType.VarChar).Value = nhanVien.Ten;
                command.Parameters.Add("@DIACHI", SqlDbType.VarChar).Value = nhanVien.Diachi;
                command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = nhanVien.Sdt;
                command.Parameters.Add("@CMND", SqlDbType.VarChar).Value = nhanVien.CMND;
                command.Parameters.Add("@NGAYSINH", SqlDbType.VarChar).Value = nhanVien.Ngaysinh;
                command.Parameters.Add("@GIOITINH", SqlDbType.VarChar).Value = nhanVien.Gioitinh;
                command.Parameters.Add("@CHUCVU", SqlDbType.VarChar).Value = nhanVien.Chucvu;
                command.Parameters.Add("@LUONG", SqlDbType.VarChar).Value = nhanVien.Luong;
            
                command.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public bool SuaNhanVien(NhanVien nhanVien)
        {
            connection = Conection.GetConnection();
            string query = "update  NHANVIEN set TENNV=@TENNV,DIACHI=@DIACHI,SDT=@SDT,CMND=@CMND,NGAYSINH=@NGAYSINH,GIOITINH=@GIOITINH,CHUCVU=@CHUCVU,LUONG=@LUONG Where MANV=@MANV";
            try
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                command.Parameters.Add("@MANV", SqlDbType.VarChar).Value = nhanVien.MANV;
                command.Parameters.Add("@TENNV ", SqlDbType.VarChar).Value = nhanVien.Ten;
                command.Parameters.Add("@DIACHI", SqlDbType.VarChar).Value = nhanVien.Diachi;
                command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = nhanVien.Sdt;
                command.Parameters.Add("@CMND", SqlDbType.VarChar).Value = nhanVien.CMND;
                command.Parameters.Add("@NGAYSINH", SqlDbType.VarChar).Value = nhanVien.Ngaysinh;
                command.Parameters.Add("@GIOITINH", SqlDbType.VarChar).Value = nhanVien.Gioitinh;
                command.Parameters.Add("@CHUCVU", SqlDbType.VarChar).Value = nhanVien.Chucvu;
                command.Parameters.Add("@LUONG", SqlDbType.VarChar).Value = nhanVien.Luong;
                
                command.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        #endregion
    }
}

