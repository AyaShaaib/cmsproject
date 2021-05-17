using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Annex.App_Code;

namespace Annex.UserControl.Template.Roles
{
    public partial class ListRoles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                RolesClass rolesClass = new RolesClass();
                RolesRepeater.DataSource = rolesClass.getallroles();
                RolesRepeater.DataBind();
            }
        }

        protected void btnMoreinfo_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}