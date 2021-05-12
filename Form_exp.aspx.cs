using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gitexp_pro
{
    public partial class Form_exp : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UKMR9CC;Initial Catalog=Gitdata;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("insert into Data_exp(Name,Surname) values(@name,@sur)", conn);
            cmd2.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@sur", TextBox2.Text);
            cmd2.ExecuteNonQuery();
            conn.Close();
        }
    }
}