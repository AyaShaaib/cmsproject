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

namespace Annex.UserControl.Template.Content
{
    public partial class ListContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ContentController dc = new ContentController();
            rptContents.DataSource = dc.GetContents();
            rptContents.DataBind();
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int ContentID = int.Parse(btn.CommandArgument);
            Response.Redirect("/UserControl/Template/Content/EditContent.aspx?ID=" + ContentID);
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int ContentID = int.Parse(btn.CommandArgument);
            ContentController dc = new ContentController();
            dc.DeleteContent(ContentID);
            rptContents.DataSource = dc.GetContents();
            rptContents.DataBind();
        }
        protected void Insert_Redirect(object sender,EventArgs e)
        {
            Response.Redirect("AddContent.aspx");
        }
    }
}