using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Annex.App_Code;

namespace Annex.UserControl.Template.Settings
{
    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// Saves the Settings of this CMS by using addsettings func in settingsclass 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            SettingsClass st = new SettingsClass();
            string Facebook = txtFacebook.Text;
            string Insta = txtInsta.Text;
            string Twitter = txtTwitter.Text;
            string Youtube = txtYoutube.Text;
            string SenderEm = senderEmail.Text;
            string SenderPa = senderPassword.Text;
            string RecieverEm = recieverEmail.Text;
            string smtpport = smtp.Text;
            st.AddSettings(Facebook,Insta,Twitter,Youtube,SenderEm,SenderPa,RecieverEm,smtpport);
            
        }

    }
}