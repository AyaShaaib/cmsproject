 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Annex._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link rel="shortcut icon" href="assets/images/favicon.ico">

        <link href="assets/css/bootstrap.min.css" rel="stylesheet" type="text/css">
        <link href="assets/css/icons.css" rel="stylesheet" type="text/css">
        <link href="assets/css/style.css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server">
    <div class="accountbg"></div>
        <div class="wrapper-page">

            <div class="card">
                <div class="card-body">

                    <h3 class="text-center mt-0 m-b-15">
                        <a href="index.html" class="logo logo-admin"><img src="assets/images/logo.png" height="24" alt="logo"/></a>
                    </h3>

                    <div class="p-3">
                        

                            <div class="form-group row">
                                <div class="col-12">
                                    <asp:TextBox runat="server" class="form-control" type="text" required="" placeholder="email" ID="loginemail"/>
                                </div>
                            </div>

                            <div class="form-group row">
                                <div class="col-12">
                                    <asp:TextBox runat="server" ID="loginpass" class="form-control" type="password" required="" placeholder="Password"/>
                                </div>
                            </div>
                            <div class="form-group row">
                                <div class="col-12">
                                    <div class="custom-control custom-checkbox"><asp:CheckBox runat="server" ID="customCheck1" />
                                        <label for="customCheck1">Remember me</label>      
                                    </div>
                                </div>
                            </div>

                            <div class="form-group text-center row m-t-20">
                                <div class="col-12">
                                    <asp:Button runat="server" class="btn btn-danger btn-block waves-effect waves-light" type="submit" Text="Login" ID="loginbtn" OnClick="loginbtn_Click"></asp:Button>
                                </div>
                            </div>
                            <div class="form-group text-center row m-t-20">
                                <div class="col-12">
                                    <asp:Button runat="server" class="btn btn-primary btn-block waves-effect waves-light" type="submit" Text="Login with Facebook" ID="loginwithfacebookbtn"></asp:Button>
                                </div>
                            </div>
                            <div class="form-group text-center row m-t-20">
                                <div class="col-12">
                                    <asp:Button runat="server" class="btn btn-success btn-block waves-effect waves-light" type="submit" Text="Login with Google" ID="Button1"></asp:Button>
                                </div>
                            </div>
                            <div class="form-group m-t-10 mb-0 row">
                                <div class="col-sm-7 m-t-20">
                                    <a href="/UserControl/Template/User/RecoverPassword.aspx" class="text-muted"><i class="mdi mdi-lock"></i> <small>Forgot your password ?</small></a>
                                </div>
                                <div class="col-sm-5 m-t-20">
                                    <a href="/UserControl/Template/User/Register.aspx" class="text-muted"><i class="mdi mdi-account-circle"></i> <small>Create an account ?</small></a>
                                </div>
                            </div>
                   
                    </div>

                </div>
            </div>
        </div>
        </form>
</body>
</html>
