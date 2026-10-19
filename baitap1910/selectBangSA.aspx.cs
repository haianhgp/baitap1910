using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace baitap1910
{
    public partial class selectBangSA : System.Web.UI.Page
    {
        string ketnoi = @"Data Source=DESKTOP-6EUF6MD7\SQLEXPRESS;Initial Catalog=quanlynhansu;User Id=sa;Password=12345678;TrustServerCertificate=True;";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }
        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM nhanvien", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            grvDanhsach.DataSource = dt;
            grvDanhsach.DataBind();

            conn.Close();
        }
    }
}
