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
    public partial class AddWidget : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            WidgetController wc = new WidgetController();
            wc.Insert(txtWidgetTitle.Text, chkPublished.Checked);
            Response.Redirect("ListWidget.aspx");
        }
    }
}