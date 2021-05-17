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

namespace Annex.UserControl.Template.Directions
{
    //form-control
    public partial class EditDirection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            DirectionController dc = new DirectionController();
            //Check if no paratmeter exist, redirect to list page.           
            Uri myUri = new Uri(Request.Url.ToString());
            string DirectionID = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
            if (DirectionID == null) {
                Response.Redirect("/UserControl/Template/Directions/ListDirection.aspx");
            }
            dc.GetDirection(int.Parse(DirectionID));
            txtDirectionTitle.Text = dc.DirectionTitle;
            chkDefault.Checked = dc.DefaultDirection;
            }
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            Uri myUri = new Uri(Request.Url.ToString());
            string DirectionID = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
            DirectionController dc = new DirectionController();
            dc.Update(int.Parse(DirectionID), txtDirectionTitle.Text, chkDefault.Checked);
            Response.Redirect("ListDirection.aspx");
        }


    }
}