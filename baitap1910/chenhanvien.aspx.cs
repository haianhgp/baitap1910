using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient; // Sử dụng thư viện MySQL

namespace baitap1910
{
    public partial class chenhanvien : System.Web.UI.Page
    {
        string ketnoi = "Server=localhost; Database=quanlynhansu; Uid=root; Pwd=12345678;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
    
            using (MySqlConnection conn = new MySqlConnection(ketnoi))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM nhanvien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grvDanhsach.DataSource = dt;
                grvDanhsach.DataBind();
            }
        }

        protected void btnDangky_Click(object sender, EventArgs e)
        {
            try
            {
             
                using (MySqlConnection conn = new MySqlConnection(ketnoi))
                {
                    conn.Open();
                    string sqlInsert = "INSERT INTO nhanvien(manv, hoten, username, password) VALUES(@manv, @hoten, @username, @password)";

                    
                    using (MySqlCommand cmd = new MySqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@manv", txtManv.Text.Trim());
                        cmd.Parameters.AddWithValue("@hoten", txtHoten.Text.Trim());
                        cmd.Parameters.AddWithValue("@username", txtUser.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());

                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            lbl1.Text = "Bạn đã chèn bản ghi thành công!";
                            LoadData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lbl1.Text = "Lỗi khi chèn dữ liệu: " + ex.Message;
            }
        }
    }
}