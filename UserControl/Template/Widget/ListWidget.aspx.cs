using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Annex.App_Code;

namespace Annex.UserControl.Template.Widget
{
    public partial class ListWidget : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WidgetController dc = new WidgetController();
            rptWidgets.DataSource = dc.GetWidgets();
            rptWidgets.DataBind();
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int WidgetID = int.Parse(btn.CommandArgument);
            Response.Redirect("/UserControl/Template/Widgets/EditWidget.aspx?ID=" + WidgetID);
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int WidgetID = int.Parse(btn.CommandArgument);
            WidgetController dc = new WidgetController();
            dc.DeleteWidget(WidgetID);
            rptWidgets.DataSource = dc.GetWidgets();
            rptWidgets.DataBind();
        }
    }
}
