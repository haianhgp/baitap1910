using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

namespace baitap1910
{
    public partial class dangnhapSQL : System.Web.UI.Page
    {
        string ketnoi = "Server=localhost; Database=quanlynhansu; Uid=root; Pwd=12345678;";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnDangnhap_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ketnoi))
                {
                    conn.Open();

                    string query = @"SELECT * FROM nhanvien 
                                     WHERE username = @username 
                                     AND password = @password";

                    using (MySqlCommand sc = new MySqlCommand(query, conn))
                    {
                        sc.Parameters.AddWithValue("@username", user);
                        sc.Parameters.AddWithValue("@password", pass);

                        using (MySqlDataReader sdr = sc.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                Session["tenDangNhap"] = sdr["username"].ToString();
                                Session["password"] = sdr["password"].ToString();

                               
                                Response.Redirect("chenhanvien.aspx");
                            }
                            else
                            {
                                lblKetqua.Text = "Kết quả: Sai tài khoản hoặc mật khẩu!";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblKetqua.Text = "Kết quả: Lỗi đăng nhập - " + ex.Message;
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            lblKetqua.Text = "Kết quả: ";
        }
    }
}