<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="Annex.UserControl.Template.Settings.Settings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="row">
        <div class="col-sm-12">
            <div class="page-title-box">
                <div class="btn-group float-right">
                    <ol class="breadcrumb hide-phone p-0 m-0">
                        <li class="breadcrumb-item"><a href="home.aspx">Home</a></li>
                        <li class="breadcrumb-item"><a href="Settings.aspx">Settings</a></li>
                    </ol>
                </div>
                <h4 class="page-title">Settings</h4>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-2"><i class="fa fa-facebook"></i></div><div class="col-3"><asp:TextBox runat="server" Text="https://www.facebook.com/" Columns="45" ID="txtFacebook"></asp:TextBox></div>
    </div><br />
    <div class="row">
        <div class="col-2"><i class="fa fa-twitter"></i></div><div class="col-3"><asp:TextBox runat="server" Text="https://www.twitter.com/" Columns="45" ID="txtTwitter"></asp:TextBox></div>
    </div><br/>
    <div class=" row">
        <div class="col-2"><i class="fa fa-instagram"></i></div><div class="col-1"><asp:TextBox runat="server" Text="https://www.instagram.com/" Columns="45" ID="txtInsta"></asp:TextBox></div>
  </div><br />
    <div class=" row">
        <div class="col-2"><i class="fa fa-youtube-play"></i></div><div class="col-1"><asp:TextBox runat="server" Text="https://www.youtube.com/" Columns="45" ID="txtYoutube"></asp:TextBox></div>
  </div><br />
     <div class=" row">
        <div class="col-2"><span class=" font-18">Sender's Email </span></div><div class="col-1"><asp:TextBox runat="server" Text="" Columns="45" ID="senderEmail"></asp:TextBox></div>
  </div><br />
     <div class=" row">
        <div class="col-2"><span  class=" font-18">Sender's Password </span></div><div class="col-1"><asp:TextBox runat="server" Text="" Columns="45" ID="senderPassword"></asp:TextBox></div>
  </div><br />
     <div class=" row">
        <div class="col-2"><span class=" font-18">Reciever Email </span></div><div class="col-1"><asp:TextBox runat="server" Text="" Columns="45" ID="recieverEmail"></asp:TextBox></div>
  </div><br />
     <div class=" row">
        <div class="col-2"><span  class=" font-18">SMTP </span></div><div class="col-1"><asp:TextBox runat="server" Text="" Columns="45" ID="smtp"></asp:TextBox></div>
  </div>
<br />
     <div class=" row">
        <div class="col-1"><asp:Button CssClass="btn btn-success" Text="Save" runat="server" ID="btnSave" OnClick="btnSave_Click"></asp:Button></div><div class="col"><asp:Button runat="server" Text="Cancel" ID="btnCancel" CssClass="btn btn-danger" ></asp:Button></div>
  </div>

</asp:Content>
