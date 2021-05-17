using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Annex.App_Code;

namespace Annex.UserControl.Template.User
{
    public partial class ListUsers : System.Web.UI.Page
    {
        /// <summary>
        /// on page load the function getusers that is located in usercontroller will be called and data will be bind to the repeater(UserRepeater) of the  table in 
        /// frontend
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserController userController = new UserController();
                UsersRepeater.DataSource = userController.getUsers();
                UsersRepeater.DataBind();
            }
        }
        /// <summary>
        /// on click of button more info the user will be redirected to  Viewmore page with 
        /// the specific parameter which is ID using command argument and the info of this id will be loaded on View More page
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnMoreinfo_Click(object sender, EventArgs e)
        {
            LinkButton btn1 = (LinkButton)sender;
            string id = (btn1.CommandArgument);
            Response.Redirect("ViewMore.aspx?UserId=" + id);
        }
        /// <summary>
        /// on click of the delete icon on frontend the parameter ID will be sent using command argument to User Controller to execute the Deleteuser function 
        /// the next step is reloading the updated table of users after the deleting action 
        /// using the getusers func in UserControllers and binding the updated data to the Repeater in front end
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            LinkButton dltbtn = (LinkButton)sender;
            int UserId = int.Parse(dltbtn.CommandArgument);
            UserController us = new UserController();
            us.deleteuser(UserId);
            UsersRepeater.DataSource = us.getUsers();
            UsersRepeater.DataBind();

        }
        /// <summary>
        /// In case a user tried logging in more the 4 times and failed in the 4 attempts his account gets locked 
        /// here the admin has the authority to unlock an account by pressing unlock button and sending the Id of locked user to Usercontroller to execute the UnlockAccount func by resseting the 
        /// islocked boolean in sql table to 0 which means unlocked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Unlock_Click(object sender, EventArgs e)
        {
            LinkButton dltbtn = (LinkButton)sender;
            int UserId = int.Parse(dltbtn.CommandArgument);
            UserController us1 = new UserController();
            us1.UnlockAccount(UserId);
            UsersRepeater.DataSource = us1.getUsers();
            UsersRepeater.DataBind();
        }

    }
}