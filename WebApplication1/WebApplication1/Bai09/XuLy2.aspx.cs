using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Bai09
{
    public partial class XuLy2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String xml = "<xml>" + 
                "<h2>Bài 09</h2>" +
                "<ten>Nguyễn Hồng Ánh <ten>" +
                "<br><tenVXL>Tên VXL: " + Request.QueryString["cpuName"] + "</tenVXL>" +
                "<br><hang>Hãng: " + Request.QueryString["cpuFirm"] + "</hang>" +
                "<br><NgaySX>Ngày SX: " + FormatDate(Request.QueryString["cpuDate"]) + "</NgaySX>" +
                "<br><Gia>Giá: " + Request.QueryString["cpuPrice"] + "</Gia></xml>";
            Response.ClearHeaders();
            Response.AddHeader("conten-type", "text/xml");
            Response.Write(xml);
            Response.End();

        }

        string FormatDate(string date)
        {
            string[] dateArr = date.Split('-');
            return dateArr[2] + '/' + dateArr[1] + '/' + dateArr[0];
        }
    }
}