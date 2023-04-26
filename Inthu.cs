using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Z.Dapper.Plus;
using ZXing;
using Microsoft.Reporting.WinForms;

using ExcelDataReader;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Configuration;

namespace QuanLyCoDong
{
    public partial class FormInthu : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DUAN\MSSQLSERVER01;Initial Catalog=QLCD;Integrated Security=True");
        public string Ma_Co_Dong;

        public FormInthu()
        {
            InitializeComponent();
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            //dataGridView.DataSource= dt;  
            if (dt != null)
            {
                List<CoDong> coDongs = new List<CoDong>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CoDong coDong = new CoDong();
                    coDong.STT = dt.Rows[i]["STT"].ToString();
                    coDong.Ma_Co_Dong = dt.Rows[i]["Ma_Co_Dong"].ToString();
                    coDong.MaVLG = dt.Rows[i]["MaVLG"].ToString();
                    coDong.Gioi_Tinh = dt.Rows[i]["Gioi_Tinh"].ToString();
                    coDong.Ho_Ten = dt.Rows[i]["Ho_Ten"].ToString();
                    coDong.Von_Co_Phan = dt.Rows[i]["Von_Co_Phan"].ToString();
                    coDong.Von_Bieu_Quyet = dt.Rows[i]["Von_Bieu_Quyet"].ToString();
                    coDong.So_CCCD = dt.Rows[i]["So_CCCD"].ToString();
                    coDong.Ngay_Cap = dt.Rows[i]["Ngay_Cap"].ToString();
                    coDong.Noi_Cap = dt.Rows[i]["Noi_Cap"].ToString();
                    coDong.Dia_Chi_Thuong_Tru = dt.Rows[i]["Dia_Chi_Thuong_Tru"].ToString();
                    coDong.Dia_Chi_Lien_He = dt.Rows[i]["Dia_Chi_Lien_he"].ToString();
                    coDong.So_Dien_Thoai = dt.Rows[i]["So_Dien_Thoai"].ToString();
                    coDong.Email = dt.Rows[i]["Email"].ToString();
                    coDong.TYPE = dt.Rows[i]["TYPE"].ToString();
                    coDong.CNTC = dt.Rows[i]["CNTC"].ToString();
                    coDong.NAME = dt.Rows[i]["NAME"].ToString();
                    coDongs.Add(coDong);
                }
                thuMoiBindingSource.DataSource = coDongs;
            }
        }

        DataTableCollection tableCollection;

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cboSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void FormInthu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCDDataSet.Thu_Moi' table. You can move, or remove it, as needed.
            this.thu_MoiTableAdapter.Fill(this.qLCDDataSet.Thu_Moi);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["QLCDConnectionString"].ConnectionString;
                DapperPlusManager.Entity<CoDong>().Table("Thu_Moi");
                List<CoDong> coDongs = thuMoiBindingSource.DataSource as List<CoDong>;
                if (coDongs != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(coDongs);
                    }
                }
                MessageBox.Show("Đã tải lên!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Thu_Moi WHERE Ho_Ten = @Ho_Ten OR So_CCCD = @So_CCCD", con);
            command.Parameters.AddWithValue("@Ho_Ten", txtSearchName.Text);
            command.Parameters.AddWithValue("@So_CCCD", txtSearchCardNo.Text);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            DataCoDongGridView.DataSource = dt;
        }

        private void btnIn_Thu_Click(object sender, EventArgs e)
        {
        }

        private void txtSearchCardNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

