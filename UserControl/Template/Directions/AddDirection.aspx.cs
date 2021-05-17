using Annex.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annex.UserControl.Template.Directions
{
    public partial class AddDirection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            chkDefault.Checked = true;
        }

        protected void Submit_Click(object sender, EventArgs e) {
            DirectionController dc = new DirectionController();
            dc.Insert(txtDirectionTitle.Text, chkDefault.Checked);
            Response.Redirect("ListDirection.aspx");
        }
    }
}