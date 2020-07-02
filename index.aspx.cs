using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace pitonProject
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            SqlConnection con2 = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["Veritabani"].ConnectionString);
            SqlCommand komut2 = new SqlCommand();

            con2.Open();

            komut2.CommandText = "select title,startDate,endDate,Description,RememberedDate,RememberedTime from  Tasks ";
            komut2.Connection = con2;
            SqlDataReader dr = komut2.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                DateTime oDate = DateTime.Parse(dr[2].ToString());
                DateTime today = DateTime.Today;
                if (DropDownList1.SelectedItem.Value.ToString() == "Günlük")
                {
                    if (oDate == today)
                    {


                        i++;
                        System.Web.UI.HtmlControls.HtmlGenericControl myDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        myDiv.Style.Add(HtmlTextWriterStyle.BackgroundColor, "lightgray");
                        myDiv.Style.Add(HtmlTextWriterStyle.Color, "Black");



                        Table tbl = new Table();
                        Table tbl2 = new Table();
                        Table tbl3 = new Table();
                        Table tbl4 = new Table();

                        TableRow tblR1 = new TableRow();
                        TableRow tblR2 = new TableRow();
                        TableRow tblR3 = new TableRow();
                        TableRow tblR4 = new TableRow();

                        TableCell tblC1 = new TableCell();
                        TableCell tblC2 = new TableCell();
                        TableCell tblC3 = new TableCell();
                        TableCell tblC4 = new TableCell();
                        TableCell tblC5 = new TableCell();

                        LinkButton myLnkBtn = new LinkButton();
                        myLnkBtn.Text = dr[0].ToString();
                        myLnkBtn.PostBackUrl = "Update.aspx?title=" + dr[0].ToString();

                        tblC1.Controls.Add(myLnkBtn);
                        tblR1.Controls.Add(tblC1);
                        tbl.Rows.Add(tblR1);
                        myDiv.Controls.Add(tbl);

                        Label start = new Label();
                        start.Text = "Başlangıç Tarihi : " + dr[1].ToString() + "     |";
                        tblC2.Controls.Add(start);

                        Label end = new Label();
                        end.Text = "Bitiş Tarihi : " + dr[2].ToString();
                        tblC3.Controls.Add(end);

                        tblR2.Controls.Add(tblC2);
                        tblR2.Controls.Add(tblC3);

                        tbl2.Rows.Add(tblR2);
                        myDiv.Controls.Add(tbl2);

                        Label desc = new Label();
                        desc.Text = dr[3].ToString();
                        tblC4.Controls.Add(desc);

                        tblR3.Controls.Add(tblC4);
                        tbl3.Rows.Add(tblR3);
                        myDiv.Controls.Add(tbl3);



                        Label rD = new Label();
                        rD.Text = "Hatılatma Tarihi :  " + dr[4].ToString();
                        tblC5.Controls.Add(rD);

                        tblR4.Controls.Add(tblC5);
                        tbl4.Rows.Add(tblR4);
                        myDiv.Controls.Add(tbl4);



                        cell.Controls.Add(myDiv);
                    }
                }
                if (DropDownList1.SelectedItem.Value.ToString() == "Haftalık")
                {

                    DateTime dt = DateTime.Now;


                    // Calculate the WeekOfMonth according to ISO 8601
                    int weekOfMonth = Iso8601WeekNumber(dt) - Iso8601WeekNumber(dt.AddDays(1 - dt.Day)) + 1;

                    DateTime oDate1 = DateTime.Parse(dr[2].ToString());
                    int week = Iso8601WeekNumber(oDate1) - Iso8601WeekNumber(oDate1.AddDays(1 - oDate1.Day)) + 1;
                    if (week == weekOfMonth)
                    {
                        System.Web.UI.HtmlControls.HtmlGenericControl myDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        myDiv.Style.Add(HtmlTextWriterStyle.BackgroundColor, "lightgray");
                        myDiv.Style.Add(HtmlTextWriterStyle.Color, "Black");



                        Table tbl = new Table();
                        Table tbl2 = new Table();
                        Table tbl3 = new Table();
                        Table tbl4 = new Table();

                        TableRow tblR1 = new TableRow();
                        TableRow tblR2 = new TableRow();
                        TableRow tblR3 = new TableRow();
                        TableRow tblR4 = new TableRow();

                        TableCell tblC1 = new TableCell();
                        TableCell tblC2 = new TableCell();
                        TableCell tblC3 = new TableCell();
                        TableCell tblC4 = new TableCell();
                        TableCell tblC5 = new TableCell();

                        LinkButton myLnkBtn = new LinkButton();
                        myLnkBtn.Text = dr[0].ToString();
                        myLnkBtn.PostBackUrl = "Update.aspx?title=" + dr[0].ToString();

                        tblC1.Controls.Add(myLnkBtn);
                        tblR1.Controls.Add(tblC1);
                        tbl.Rows.Add(tblR1);
                        myDiv.Controls.Add(tbl);

                        Label start = new Label();
                        start.Text = "Başlangıç Tarihi : " + dr[1].ToString() + "     |";
                        tblC2.Controls.Add(start);

                        Label end = new Label();
                        end.Text = "Bitiş Tarihi : " + dr[2].ToString();
                        tblC3.Controls.Add(end);

                        tblR2.Controls.Add(tblC2);
                        tblR2.Controls.Add(tblC3);

                        tbl2.Rows.Add(tblR2);
                        myDiv.Controls.Add(tbl2);

                        Label desc = new Label();
                        desc.Text = dr[3].ToString();
                        tblC4.Controls.Add(desc);

                        tblR3.Controls.Add(tblC4);
                        tbl3.Rows.Add(tblR3);
                        myDiv.Controls.Add(tbl3);



                        Label rD = new Label();
                        rD.Text = "Hatılatma Tarihi :  " + dr[4].ToString();
                        tblC5.Controls.Add(rD);

                        tblR4.Controls.Add(tblC5);
                        tbl4.Rows.Add(tblR4);
                        myDiv.Controls.Add(tbl4);



                        cell.Controls.Add(myDiv);
                    }

                }
                if (DropDownList1.SelectedItem.Value.ToString() == "Aylık")
                {
                    DateTime oDate1 = DateTime.Parse(dr[2].ToString());
                    int month = oDate1.Month;
                    DateTime MonthThis = DateTime.Today;
                    int monththis = MonthThis.Month;
                    if (month == monththis)
                    {
                        System.Web.UI.HtmlControls.HtmlGenericControl myDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        myDiv.Style.Add(HtmlTextWriterStyle.BackgroundColor, "lightgray");
                        myDiv.Style.Add(HtmlTextWriterStyle.Color, "Black");



                        Table tbl = new Table();
                        Table tbl2 = new Table();
                        Table tbl3 = new Table();
                        Table tbl4 = new Table();

                        TableRow tblR1 = new TableRow();
                        TableRow tblR2 = new TableRow();
                        TableRow tblR3 = new TableRow();
                        TableRow tblR4 = new TableRow();

                        TableCell tblC1 = new TableCell();
                        TableCell tblC2 = new TableCell();
                        TableCell tblC3 = new TableCell();
                        TableCell tblC4 = new TableCell();
                        TableCell tblC5 = new TableCell();

                        LinkButton myLnkBtn = new LinkButton();
                        myLnkBtn.Text = dr[0].ToString();
                        myLnkBtn.PostBackUrl = "Update.aspx?title=" + dr[0].ToString();

                        tblC1.Controls.Add(myLnkBtn);
                        tblR1.Controls.Add(tblC1);
                        tbl.Rows.Add(tblR1);
                        myDiv.Controls.Add(tbl);

                        Label start = new Label();
                        start.Text = "Başlangıç Tarihi : " + dr[1].ToString() + "     |";
                        tblC2.Controls.Add(start);

                        Label end = new Label();
                        end.Text = "Bitiş Tarihi : " + dr[2].ToString();
                        tblC3.Controls.Add(end);

                        tblR2.Controls.Add(tblC2);
                        tblR2.Controls.Add(tblC3);

                        tbl2.Rows.Add(tblR2);
                        myDiv.Controls.Add(tbl2);

                        Label desc = new Label();
                        desc.Text = dr[3].ToString();
                        tblC4.Controls.Add(desc);

                        tblR3.Controls.Add(tblC4);
                        tbl3.Rows.Add(tblR3);
                        myDiv.Controls.Add(tbl3);



                        Label rD = new Label();
                        rD.Text = "Hatılatma Tarihi :  " + dr[4].ToString();
                        tblC5.Controls.Add(rD);

                        tblR4.Controls.Add(tblC5);
                        tbl4.Rows.Add(tblR4);
                        myDiv.Controls.Add(tbl4);



                        cell.Controls.Add(myDiv);
                    }

                }
                if (DropDownList1.SelectedItem.Value.ToString() == "Hepsi")
                {


                    System.Web.UI.HtmlControls.HtmlGenericControl myDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    myDiv.Style.Add(HtmlTextWriterStyle.BackgroundColor, "lightgray");
                    myDiv.Style.Add(HtmlTextWriterStyle.Color, "Black");



                    Table tbl = new Table();
                    Table tbl2 = new Table();
                    Table tbl3 = new Table();
                    Table tbl4 = new Table();

                    TableRow tblR1 = new TableRow();
                    TableRow tblR2 = new TableRow();
                    TableRow tblR3 = new TableRow();
                    TableRow tblR4 = new TableRow();

                    TableCell tblC1 = new TableCell();
                    TableCell tblC2 = new TableCell();
                    TableCell tblC3 = new TableCell();
                    TableCell tblC4 = new TableCell();
                    TableCell tblC5 = new TableCell();

                    LinkButton myLnkBtn = new LinkButton();
                    myLnkBtn.Text = dr[0].ToString();
                    myLnkBtn.PostBackUrl = "Update.aspx?title=" + dr[0].ToString();

                    tblC1.Controls.Add(myLnkBtn);
                    tblR1.Controls.Add(tblC1);
                    tbl.Rows.Add(tblR1);
                    myDiv.Controls.Add(tbl);

                    Label start = new Label();
                    start.Text = "Başlangıç Tarihi : " + dr[1].ToString() + "     |";
                    tblC2.Controls.Add(start);

                    Label end = new Label();
                    end.Text = "Bitiş Tarihi : " + dr[2].ToString();
                    tblC3.Controls.Add(end);

                    tblR2.Controls.Add(tblC2);
                    tblR2.Controls.Add(tblC3);

                    tbl2.Rows.Add(tblR2);
                    myDiv.Controls.Add(tbl2);

                    Label desc = new Label();
                    desc.Text = dr[3].ToString();
                    tblC4.Controls.Add(desc);

                    tblR3.Controls.Add(tblC4);
                    tbl3.Rows.Add(tblR3);
                    myDiv.Controls.Add(tbl3);



                    Label rD = new Label();
                    rD.Text = "Hatılatma Tarihi :  " + dr[4].ToString();
                    tblC5.Controls.Add(rD);

                    tblR4.Controls.Add(tblC5);
                    tbl4.Rows.Add(tblR4);
                    myDiv.Controls.Add(tbl4);



                    cell.Controls.Add(myDiv);


                }

                DateTime oDate12 = DateTime.Parse(dr[4].ToString());
                DateTime today12 = DateTime.Today;
                if (oDate12 == today12)
                {
                    using (MailMessage mm = new MailMessage("", ""))
                    {


                        string txtBody ="Görev Hatırlatma," +
                            "Daha önce kaydettiğiniz "+dr[0].ToString()+" görevinin son günü!";

                        mm.Subject = "Görev Hatırlatma";
                        mm.Body = txtBody;

                        mm.IsBodyHtml = false;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        NetworkCredential NetworkCred = new NetworkCredential("", "");
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = NetworkCred;
                        smtp.Port = 587;
                        smtp.Send(mm);
                        //ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent all of users.');", true);
                    }
                }

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
        public static int Iso8601WeekNumber(DateTime dt)
        {
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(dt, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }



    }


}