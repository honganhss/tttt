using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication1.POST
{
    public partial class XyLy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String xml =
                "<h2>Bài 09</h2>" +
                "<h3>Nguyễn Hồng Ánh </h3>" +
                "<br>Tên VXL: " + Request.Form["cpuName"] +
                "<br>Hãng: " + Request.Form["cpuFirm"] +
                "<br>Ngày SX: " + FormatDate(Request.Form["cpuDate"]) +
                "<br>Giá: " + Request.Form["cpuPrice"];
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