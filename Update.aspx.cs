using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pitonProject
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string title = Request.QueryString["title"];

            SqlConnection baglanti1 = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["Veritabani"].ConnectionString);
            string sorgu1 = "  select  title,startDate,endDate,Description,RememberedDate" +
                " from Tasks where title='" + title + "'";
             
            SqlCommand komut = new SqlCommand(sorgu1, baglanti1);
            baglanti1.Open();
            SqlDataReader oku1 = komut.ExecuteReader();
            while (oku1.Read())
            {
                TextBox1.Text = oku1[0].ToString();
                TextBox2.Text = oku1[1].ToString();
                TextBox3.Text = oku1[2].ToString();
                TextBox4.Text = oku1[3].ToString();
                TextBox5.Text = oku1[4].ToString();

            }
            baglanti1.Close();


        }
        public void ShowMessage(string message)
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string title = Request.QueryString["title"];

            SqlConnection con = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["Veritabani"].ConnectionString);
            if (!IsPostBack)
            {

                if (TextBox1.Text != "")
                {
                    con.Open();


                    SqlCommand cmd2 = new SqlCommand("UPDATE Tasks SET title=@Parameter1" +
                        " WHERE title='" + title + "'", con);
                    cmd2.Parameters.Add("@Parameter1", SqlDbType.NVarChar).Value = TextBox1.Text;
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (TextBox2.Text != "")
                {
                    con.Open();

                    DateTime oDate = DateTime.Parse(TextBox2.Text);
                    SqlCommand cmd2 = new SqlCommand("UPDATE Tasks SET startDate=@Parameter2" +
                        " WHERE title='" + title + "'", con);
                    cmd2.Parameters.Add("@Parameter2", SqlDbType.Date).Value = oDate;
                    cmd2.ExecuteNonQuery();
                    con.Close();

                }
                if (TextBox3.Text != "")
                {
                    con.Open();
                    DateTime oDate1 = DateTime.Parse(TextBox3.Text);
                    SqlCommand cmd2 = new SqlCommand("UPDATE Tasks SET endDate=@Parameter3" +
                        " WHERE title='" + title + "'", con);

                    cmd2.Parameters.Add("@Parameter3", SqlDbType.Date).Value = oDate1;

                    cmd2.ExecuteNonQuery();
                    con.Close();

                }
                if (TextBox4.Text != "")
                {
                    con.Open();

                    SqlCommand cmd2 = new SqlCommand("UPDATE Tasks SET Description=@Parameter4" +
                        " WHERE title='" + title + "'", con);
                    cmd2.Parameters.Add("@Parameter4", SqlDbType.NVarChar).Value = TextBox4.Text;
                    cmd2.ExecuteNonQuery();
                    con.Close();

                }
                if (TextBox5.Text != "")
                {
                    con.Open();

                    DateTime oDate = DateTime.Parse(TextBox2.Text);
                    DateTime oDate1 = DateTime.Parse(TextBox3.Text);
                    DateTime oDate2 = DateTime.Parse(TextBox5.Text);

                    SqlCommand cmd2 = new SqlCommand("UPDATE Tasks SET RememberedDate=@Parameter5" +
                        " WHERE title='" + title + "'", con);

                    cmd2.Parameters.Add("@Parameter5", SqlDbType.DateTime).Value = oDate2;
                    cmd2.ExecuteNonQuery();
                    con.Close();

                }

                ShowMessage("Kayıt başarıyla güncellendi");
                //}
                //catch (Exception)
                //{

                //    ShowMessage("Kayıt sırasında hata oluştu!!!");
                //}
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";

            }
        }
    }
}