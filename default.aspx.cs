using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Annex.UserControl;

namespace Annex
{
    public partial class _default : System.Web.UI.Page
    {
        /// <summary>
        /// it checks if session is timedout if it exceeds  900ms
        /// and writes a response after tyhe redirect to login page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string Q = HttpUtility.UrlDecode(Request.QueryString["Q"]);
            
            if (Q=="timeout")
            {
                Response.Write("Session Timedout");   
            }
        }
        /// <summary>
        /// On click this code will take the email and password and send them to LoginClass where a function called loginmethod is used to check if this user credentials are true
        /// if response was 1 then the user is available with these credentials in case the account islocked is true then the user won't access his account until unlocked by admin if not the user will be redirected to home
        ///in case 0 the code will check if locked and will write a response.if not the code will check the attempts using getattempts func in loginclass if less than 4 the code will add 1
        ///if the account reached its 4th attempt the account will be locked
        ///case -1 means the user is invalid in database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void loginbtn_Click(object sender, EventArgs e)
        {
           
            LoginClass lc = new LoginClass();
            String usremail = loginemail.Text;
            String usrpassword = loginpass.Text;
            
            switch (lc.LoginMethod(usremail, usrpassword))
            {
                case 1:
                    LoginClass loginClass4 = new LoginClass();
                    loginClass4.checkiflocked(usremail);
                    if (loginClass4.IsLocked == "True")
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "showContent();", true);
                    }
                    else {
                        Session["Email"] = usremail;
                        Response.Redirect("~/UserControl/Template/User/home.aspx");
                    }
                    break;
                case 0:
                    LoginClass loginClass3 = new LoginClass();
                    loginClass3.checkiflocked(usremail);
                    if (loginClass3.IsLocked=="1")
                    {
                        // string str = "function () { alert('Your Account is Locked'); }";
                        //Page.RegisterClientScriptBlock("nameofscript", str);
                        //Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction",str, true);
                        Response.Write(@"<script Language='javascript'>alert('Your Account is Locked');</script>");
                    }
                    else
                    {
                        LoginClass loginClass = new LoginClass();
                        loginClass.getattempts(usremail);
                        if (loginClass.AttemptsCount < 4)
                        {
                            int AttemptsCount = loginClass.AttemptsCount + 1;
                            LoginClass loginClass1 = new LoginClass();
                            loginClass1.updateAttempts(AttemptsCount, usremail);
                            loginemail.Text = "wrong email";
                            loginemail.Text = "wrong pass";
                        }
                        else
                        {
                            LoginClass loginClass2 = new LoginClass();
                            loginClass2.lockaccount(usremail);
                        }
                    }
                    
                        break;
                case -1:
                    loginemail.Text = "invalid";
                    loginpass.Text = "invalid";
                    break;
            }
        }
    }
}