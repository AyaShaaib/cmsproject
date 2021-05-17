<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecoverPassword.aspx.cs" Inherits="Annex.UserControl.Template.User.RecoverPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
    <title></title>
   <link rel="shortcut icon" href="/assets/images/favicon.ico" />

    <link href="/plugins/morris/morris.css" rel="stylesheet" />
    <link href="/fonts/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <link href="/assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="/assets/css/icons.css" rel="stylesheet" type="text/css" />
    <link href="/assets/css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
         <div class="accountbg"></div>
        
 
   <div class="container">
    <div class="row">
        <div class="col-md-12">
            <h1 style="color:azure">Forgot Password</h1>
        </div>
    </div><br />
       <div class="row">
           <div class="col-md-1">
               <span style="color:azure">Email :</span>
           </div>
           <div class="col-md-2">
               <asp:TextBox runat="server" ID="txtemail" placeholder="Email"/>
           </div>
       </div><br />
       <div class="row">
           <div class="col-md-4">
               <asp:Button runat="server" ID="sendCode" Text="Send" CssClass="btn btn-facebook" OnClick="sendCode_Click" />
               <asp:label runat="server" Enabled="false" Text="" ForeColor="White" ID="lblmsg"></asp:label>
           </div>
       </div>
</div>
    </form>
</body>
</html>
