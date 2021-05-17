<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditAuthor.aspx.cs" Inherits="Annex.UserControl.Template.Author.EditAuthor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="page-content-wrapper ">

            <div class="container-fluid">

                <div class="row">
                    <div class="col-sm-12">
                        <div class="page-title-box">
                            <div class="btn-group float-right">
                                <ol class="breadcrumb hide-phone p-0 m-0">
                                    <li class="breadcrumb-item"><a href="#">Annex</a></li>
                                    <li class="breadcrumb-item"><a href="#">Forms</a></li>
                                    <li class="breadcrumb-item active">Authors</li>
                                </ol>
                            </div>
                            <h4 class="page-title">Add Author</h4>
                        </div>
                    </div>
                </div>
                <!-- end page title end breadcrumb -->

                <div class="row">
                    <div class="col-12">
                        <div class="card m-b-30">
                            <div class="card-body">
                                <div class="row">
                                    <div class="form-group row col-6">
                                    <label for="example-text-input" class="col-sm-12 font-weight-bold">Picture</label>
                                    <div class="col-sm-12">
                                        <asp:FileUpload ID="FileUploadAuthorPicture" runat="server" CssClass="form-control" />
                                        <asp:Label ID="lblFileUploadAuthorPicture" runat="server" ></asp:Label>
                                        <asp:Label ID="lblFileUploadAuthorPicturePath" runat="server" ></asp:Label>
                                    </div>
                                </div>

                                </div>
                                <br />
                                <div class="row">
                                <div class="form-group row col-6">
                                    <label class="col-sm-12 font-weight-bold">Name</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox runat="server" ID="txtAuthorName" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAuthorName" ErrorMessage="Please Enter Author Name" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                    </div>
                                <div class="row">
                                <div class="form-group row col-6">
                                    <label class="col-sm-12 font-weight-bold">Job title</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox runat="server" ID="txtAuthorJobTitle" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAuthorJobTitle" ErrorMessage="Please Enter The Job Title" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                     <div class="form-group row col-6">
                                    <label class="col-sm-12 font-weight-bold">Address</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox runat="server" ID="txtAuthorAddress" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAuthorAddress" ErrorMessage="Please Enter Address" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                    </div>
                                <div class="row">
                                <div class="form-group row col-6">
                                    <label class="col-sm-12 font-weight-bold">Email</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox runat="server" ID="txtAuthorEmail" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAuthorEmail" ErrorMessage="Please Enter Email" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                    <div class="form-group row col-6">
                                    <label class="col-sm-12 font-weight-bold">Website</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox runat="server" ID="txtAuthorWebsite" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtAuthorWebsite" ErrorMessage="Please Enter Your Website URL" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                    </div>
                                <div class="row">
                                <div class="form-group row col-6">
                                    <label class="col-sm-12 font-weight-bold">LinkedIn</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox runat="server" ID="txtAuthorLinkedIn" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAuthorLinkedIn" ErrorMessage="Please Enter Your LinkedIn URL" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group row col-6">
                                    <label class="col-sm-12 font-weight-bold">Facebook</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox runat="server" ID="txtAuthorFacebook" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtAuthorFacebook" ErrorMessage="Please Enter Your Facebook URL" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                    </div>
                                <div class="row">
                                <div class="form-group row col-6">
                                    <label class="col-sm-12 font-weight-bold">Twitter</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox runat="server" ID="txtAuthorTwitter" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtAuthorTwitter" ErrorMessage="Please Enter Your Twitter URL" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group row col-6">
                                    <label class="col-sm-12 font-weight-bold">Instagram</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox runat="server" ID="txtAuthorInstagram" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtAuthorInstagram" ErrorMessage="Please Enter Your Instagram URL" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                    </div>
                                <div class="row">
                                <div class="form-check-group row col-6">
                                    <label for="example-text-input" class="col-sm-12 font-weight-bold" >Language</label> 
                                    <div class="col-sm-12">
                                        <asp:DropDownList ID="ddlLanguageId" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                    </div>
                                <br />
                                <div class="form-group row col-2">
                                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="Edit_Click" CssClass="btn-primary form-control" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
