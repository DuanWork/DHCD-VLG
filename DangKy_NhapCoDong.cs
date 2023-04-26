using ZXing;
using ZXing.QrCode;
using System.Drawing;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Common;

namespace QuanLyCoDong
{
    public partial class DangKy_NhapCoDong : Form
    {

        public DangKy_NhapCoDong()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DUAN\MSSQLSERVER01;Initial Catalog=QLCD;Integrated Security=True");
        public string Ma_Co_Dong;

        private void txtFileName_Load(object sender, EventArgs e)
        {
            GetCoDong();
        }

        private void GetCoDong()
        {
            SqlCommand cmd = new SqlCommand("Select * from Nhap_Co_Dong", con);
            DataTable dt = new DataTable();

            con.Open();
                
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            DataCoDongGirdView.DataSource= dt;
        }

        private string getLastMaCoDong()
        {
            string lastMaCoDong = "";
            using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 Ma_Co_Dong FROM Nhap_Co_Dong ORDER BY Ma_Co_Dong DESC", con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lastMaCoDong = reader.GetString(0);
                    }
                }
                con.Close();
            }
            return lastMaCoDong;
        }

        private string GenerateNewMaCoDong()
        {
            // Lấy mã cổ đông cuối cùng trong cơ sở dữ liệu
            string lastMaCoDong = getLastMaCoDong();

            // Tạo mã cổ đông mới
            int newId = 1;
            if (!string.IsNullOrEmpty(lastMaCoDong) && lastMaCoDong.Length > 3)
            {
                newId = int.Parse(lastMaCoDong.Substring(0, 3)) + 1;
            }

            string newMaCoDong = newId.ToString("000");

            // Kiểm tra xem mã cổ đông mới có trùng với các mã cổ đông đã có trong cơ sở dữ liệu hay không
            while (IsMaCoDongExists(newMaCoDong))
            {
                newId++;
                newMaCoDong = newId.ToString("000");
            }

            return newMaCoDong;
        }

        private bool IsMaCoDongExists(string maCoDong)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Nhap_Co_Dong WHERE Ma_Co_Dong = @Ma_Co_Dong", con))
            {
                cmd.Parameters.AddWithValue("@Ma_Co_Dong", maCoDong);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                return count > 0;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string newMaCoDong = GenerateNewMaCoDong();
                SqlCommand cmd = new SqlCommand("INSERT INTO Nhap_Co_Dong (Ma_Co_Dong, Ho_Va_Ten, So_CCCD, Dia_Chi, Von_Co_Phan, Von_Uy_Quyen, Tong_Von, Tinh_trang) VALUES (@Ma_Co_Dong, @Ho_Va_Ten, @So_CCCD, @Dia_Chi, @Von_Co_Phan, @Von_Uy_Quyen, @Tong_Von, @Tinh_Trang)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Ma_Co_Dong", newMaCoDong);
                cmd.Parameters.AddWithValue("@Ho_Va_Ten", txtFullName.Text);
                cmd.Parameters.AddWithValue("@So_CCCD", txtCardNo.Text);
                cmd.Parameters.AddWithValue("@Dia_Chi", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Von_Co_Phan", 0);
                cmd.Parameters.AddWithValue("@Von_Uy_Quyen", 0);
                cmd.Parameters.AddWithValue("@Tong_Von", 0);
                cmd.Parameters.AddWithValue("@Tinh_Trang", 0);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New CoDong is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetCoDong();
            }
        }


        private bool IsValid()
        {
            if (txtFullName.Text == string.Empty)
            {
                MessageBox.Show("Name is required","Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void DataCoDongGirdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataCoDongGirdView.SelectedRows.Count > 0)
            {
                Ma_Co_Dong = Convert.ToString(DataCoDongGirdView.SelectedRows[0].Cells[0].Value);
                txtFullName.Text = DataCoDongGirdView.SelectedRows[0].Cells[1].Value?.ToString() ?? "";
                txtCardNo.Text = DataCoDongGirdView.SelectedRows[0].Cells[2].Value?.ToString() ?? "";
                txtAddress.Text = DataCoDongGirdView.SelectedRows[0].Cells[3].Value?.ToString() ?? "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Ma_Co_Dong))
            {
                string newMa_Co_Dong = GenerateNewMaCoDong();
                SqlCommand cmd = new SqlCommand("UPDATE Nhap_Co_Dong SET Ho_Va_Ten = @Ho_Va_Ten, So_CCCD = @So_CCCD, Dia_Chi = @Dia_Chi WHERE Ma_Co_Dong = @Ma_Co_Dong", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Ma_Co_Dong", this.Ma_Co_Dong);
                cmd.Parameters.AddWithValue("@Ho_Va_Ten", txtFullName.Text);
                cmd.Parameters.AddWithValue("@So_CCCD", txtCardNo.Text);
                cmd.Parameters.AddWithValue("@Dia_Chi", txtAddress.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New CoDong is successfully saved in the database", "Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetCoDong();
            }
            else
            {
                MessageBox.Show("Please Select an name update to information", "Select?",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Nhap_Co_Dong WHERE Ho_Va_Ten = @Ho_Va_Ten OR So_CCCD = @So_CCCD", con);
            command.Parameters.AddWithValue("@Ho_Va_Ten", txtFullName.Text);
            command.Parameters.AddWithValue("@So_CCCD", txtCardNo.Text);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            DataCoDongGirdView.DataSource = dt;
        }
    }
}