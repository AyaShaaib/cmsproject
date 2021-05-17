using Annex.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annex.UserControl.Template.Source
{
    public partial class ListSources : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SourceController sc = new SourceController();
                rptSource.DataSource = sc.GetSources();
                rptSource.DataBind();
            }
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;
            int ColorId = int.Parse(b.CommandArgument);
            SourceController cc = new SourceController();
            cc.Delete(ColorId);
            rptSource.DataSource = cc.GetSources();
            rptSource.DataBind();
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;
            int SourceId = int.Parse(b.CommandArgument);
            Response.Redirect("EditSource.aspx?ID=" + SourceId);
        }
        protected void Insert_Redirect(object sender,EventArgs e)
        {
            Response.Redirect("AddSource.aspx");
        }
    }
}