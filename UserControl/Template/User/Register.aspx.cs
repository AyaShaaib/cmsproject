using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Annex.App_Code;

namespace Annex.UserControl.Template.User
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This code calls a function called registermethod from register class and sends it the params the user used to register his/her account
        /// in case success then the user will be redirected to login page
        /// if not then the response Email already exists will be visible to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void regbtn_Click(object sender, EventArgs e)
        {       
                RegisterClass registerClass = new RegisterClass();
                     switch (registerClass.RegisterMethod(txtFname.Text, txtLname.Text, txtPass.Text, txtEmail.Text, txtPhone.Text))
                    {
                        case "Success":
                            Response.Redirect("~/default.aspx");
                            break;
                        case "email already exists":
                    txtEmail.Text = "Email Already Exists";
                            break;
                    }
            }
        }
    }
