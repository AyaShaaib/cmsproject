<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoogleAuthentication.aspx.cs" Inherits="Annex.UserControl.Template.Authentication.GoogleAuthentication" %>

<!DOCTYPE html>  
    <html xmlns="http://www.w3.org/1999/xhtml">  
  
    <head runat="server">  
        <title>login</title>  
        <style type="text/css">  
            .gmailbutton {  
                background-color: #ff0000;  
                color: white;  
                width: 150px;  
            }  
        </style>  
    </head>  
  
    <body>  
        <form id="form1" runat="server">  
            <div>  
                <asp:Button ID="btnlogin" runat="server" Text="Login With Gmail" CssClass="gmailbutton" OnClick="btnlogin_Click"/> </div>  
        </form>  
    </body>  
  
    </html> 
