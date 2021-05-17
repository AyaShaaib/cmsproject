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


namespace Annex.UserControl.Template.Directions
{
    public partial class ListDirection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DirectionController dc = new DirectionController();
            rptDirections.DataSource = dc.GetDirections();
            rptDirections.DataBind();

        }

        protected void Edit_Click(object sender, EventArgs e) 
        {
            LinkButton btn = (LinkButton)sender;
            int DirectionID = int.Parse(btn.CommandArgument);
            Response.Redirect("/UserControl/Template/Directions/EditDirection.aspx?ID=" + DirectionID);
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int DirectionID = int.Parse(btn.CommandArgument);
            DirectionController dc = new DirectionController();
            dc.DeleteDirection(DirectionID);
            rptDirections.DataSource = dc.GetDirections();
            rptDirections.DataBind();
        }
        protected void Insert_Redirect(object sender,EventArgs e)
        {
            Response.Redirect("AddDirection.aspx");
        }
    }
        
}