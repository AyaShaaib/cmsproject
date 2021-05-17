using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Annex.App_Code;
using System.Net.Mime;
using System.Net;

namespace Annex.UserControl.Template.User
{
    public partial class RecoverPassword : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void sendCode_Click(object sender, EventArgs e)
        {
            string Email = txtemail.Text;
            PasswordClass recovery = new PasswordClass();
            recovery.getUser(Email);
            string Fname = recovery.Fname;
            if (recovery.Fname==null)
            {
                txtemail.Text = "";
                lblmsg.Text = "Enter a Valid Email";
            }
            else
            {
                string Code;
                Code = Guid.NewGuid().ToString();
                PasswordClass password = new PasswordClass();
                password.UploadCode(Email,Code);
                try
                {
                    using (MailMessage mm = new MailMessage("zakaria.harouki@gmail.com", Email))
                    {
                        mm.Subject = "Password Recovery";
                        mm.Body = @"<a href=http://localhost:34227/UserControl/Template/User/ResetPassword.aspx?Email=" + Email + "&Code=" + Code + ">Click here to change your password</a>";
                        mm.IsBodyHtml = false;
                        SmtpClient smtp = new SmtpClient("smtp-relay.sendinblue.com");
                        smtp.Host = "smtp-relay.sendinblue.com";
                        smtp.EnableSsl = true;
                        NetworkCredential NetworkCred = new NetworkCredential("zakaria.harouki@gmail.com", "rbjUEh8YVNZC0vfI");
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = NetworkCred;
                        smtp.Port = 587;
                        smtp.Send(mm);
                    }
                      /*  MailMessage Msg = new MailMessage();
                    MailAddress mailAddress = new MailAddress("zakaria.harouki@gmail.com", "Annex Team");
                    Msg.From=(mailAddress);
                    MailAddress recieveraddress = new MailAddress(Email,Fname);
                    Msg.To.Add(recieveraddress);
                    Msg.Subject ="Password Recovery";
                    Msg.Body = "<a href=http://localhost:34227/UserControl/Template/User/ResetPassword.aspx?Email="+Email+"&Code="+Code+ ">Click here to change your password</a>";
                    Msg.IsBodyHtml = false;
                    SmtpClient smtp = new SmtpClient("smtp-relay.sendinblue.com", 587);
                    //smtp.Host = ;
                    smtp.Host = "smtp-relay.sendinblue.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential(Msg.From.Address, "rbjUEh8YVNZC0vfI");
                    smtp.Send(Msg);*/
                    //Page.RegisterStartupScript("UserMsg", "<script>alert('Mail sent thank you...');if(alert){ window.location='~/UserControl/Template/User/RecoverPassword.aspx';}</script>");
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} Exception caught.", ex);
                }
            }
        }
    }
}
