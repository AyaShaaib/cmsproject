using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Annex.App_Code;

namespace Annex.UserControl.Template.User
{
    public partial class ViewMore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            string id = HttpUtility.UrlDecode(Request.QueryString["UserId"]);
            int UserId = (int)Int64.Parse(id);
            userController.getuserdetails(UserId);
            txtname.Text = "" + userController.Fname + "" + userController.Lname;
            txtId.Text = id;
            txtEmail.Text= userController.Email;
            txtPhone.Text = userController.PhoneNumber;
        }

        protected void changepassbtn_Click(object sender, EventArgs e)
        {
            
        }

        protected void confirmpasschange_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            string id = HttpUtility.UrlDecode(Request.QueryString["UserId"]);
            int UserId = (int)Int64.Parse(id);
            string PasswordHash = txtpass.Text;
            userController.Updatepassword(UserId, PasswordHash);
            string response = userController.responsemessage;
            if (response == "Success")
            {
                Response.Redirect("~/default.aspx");
            }
        }
    }
}