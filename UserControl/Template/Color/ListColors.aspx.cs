using Annex.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annex.UserControl.Template.Color
{
    public partial class ListColors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ColorController cc = new ColorController();
                rptColor.DataSource = cc.GetColors();
                rptColor.DataBind();
            }
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;
            int ColorId = int.Parse(b.CommandArgument);
            ColorController cc = new ColorController();
            cc.Delete(ColorId);
            rptColor.DataSource = cc.GetColors();
            rptColor.DataBind();
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;
            /*Session["ID"] = int.Parse(b.CommandArgument);*/
            int NewsId = int.Parse(b.CommandArgument);
            Response.Redirect("UpdateColor.aspx?ID=" + NewsId);
        }
        protected void Insert_Redirect(object sender,EventArgs e)
        {
            Response.Redirect("InsertColor.aspx");
        }
    }
}