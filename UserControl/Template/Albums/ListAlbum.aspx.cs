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


namespace Annex.UserControl.Template.Albums
{
    public partial class ListAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AlbumController ac = new AlbumController();
            rptAlbums.DataSource = ac.GetAlbums();
            rptAlbums.DataBind();
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int AlbumID = int.Parse(btn.CommandArgument);
            Response.Redirect("/UserControl/Template/Albums/EditAlbum.aspx?ID=" + AlbumID);
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int AlbumID = int.Parse(btn.CommandArgument);
            AlbumController dc = new AlbumController();
            dc.DeleteAlbum(AlbumID);
            rptAlbums.DataSource = dc.GetAlbums();
            rptAlbums.DataBind();
        }

        protected void Insert_Redirect(object sender,EventArgs e)
        {
            Response.Redirect("AddAlbum.aspx");
        }
    }

}