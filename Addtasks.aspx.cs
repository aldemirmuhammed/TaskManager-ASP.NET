using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pitonProject
{
    public partial class Addtasks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["Veritabani"].ConnectionString);
                con.Open();

                DateTime oDate = DateTime.Parse(TextBox2.Text);
                DateTime oDate1 = DateTime.Parse(TextBox3.Text);
                DateTime oDate2 = DateTime.Parse(TextBox5.Text);

                SqlCommand cmd2 = new SqlCommand("INSERT INTO Tasks( title,startDate,endDate,Description,RememberedDate)" +
                    "values( @title,@startDate,@endDate,@Description,@RememberedDate)", con);
                cmd2.Parameters.Add("@title", SqlDbType.NVarChar).Value = TextBox1.Text;
                cmd2.Parameters.Add("@startDate", SqlDbType.Date).Value = oDate;
                cmd2.Parameters.Add("@endDate", SqlDbType.Date).Value = oDate1;
                cmd2.Parameters.Add("@Description", SqlDbType.NVarChar).Value = TextBox4.Text;
                cmd2.Parameters.Add("@RememberedDate", SqlDbType.DateTime).Value = oDate2;



                cmd2.ExecuteNonQuery();
                ShowMessage("Kayıt başarıyla kaydedildi");
            }
            catch (Exception)
            {

                ShowMessage("Kayıt sırasında hata oluştu!!!");
            }
        
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

    }
}