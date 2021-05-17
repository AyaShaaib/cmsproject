using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Annex.App_Start;

namespace Annex
{
    /// <summary>
    /// a global connection string for the database called MyConn
    /// 
    /// </summary>
    public class Global : System.Web.HttpApplication
    {

        public static string MyConn = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        

        void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        /// <summary>
        /// on Session start this code checks if the Email is available if not then the session has ended and it will redirect the user to login
        /// this protects the website from being accessed without logging in 
        /// the session time is 900ms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Session_Start(object sender, EventArgs e)
        {
            
            // Code that runs when a new session is started  

            if (Session["Email"] != null)
            {
                //Redirect to Welcome Page if Session is not null  
                Response.Redirect("~/UserControl/Template/User/home.aspx");
                Session.Timeout = 900;

            }
            else
            {
                //Redirect to Login Page if Session is null & Expires   
                Response.Redirect("~/default.aspx");

            }
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
   
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}