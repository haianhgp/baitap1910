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
    public partial class selectBang : System.Web.UI.Page
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
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM nhanvien", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    grvDanhsach.DataSource = dt;
                    grvDanhsach.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write("Lỗi kết nối CSDL: " + ex.Message);
                }
            }
        }
    }
}