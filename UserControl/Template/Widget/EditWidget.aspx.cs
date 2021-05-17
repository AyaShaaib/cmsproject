using Annex.App_Code;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Annex.UserControl.Template.Widget
{
    public partial class EditWidget : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WidgetController dc = new WidgetController();
                //Check if no paratmeter exist, redirect to list page.           
                Uri myUri = new Uri(Request.Url.ToString());
                string WidgetID = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
                if (WidgetID == null)
                {
                    Response.Redirect("/UserControl/Template/Widget/ListWidget.aspx");
                }
                dc.GetWidget(int.Parse(WidgetID));
                txtWidgetTitle.Text = dc.WidgetTitle;
                chkPublished.Checked = dc.IsPublished;
            }
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            Uri myUri = new Uri(Request.Url.ToString());
            string WidgetID = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
            WidgetController dc = new WidgetController();
            dc.Update(int.Parse(WidgetID), txtWidgetTitle.Text, chkPublished.Checked);
            Response.Redirect("ListWidget.aspx");
        }
    }
}