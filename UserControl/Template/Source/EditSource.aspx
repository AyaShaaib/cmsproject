<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditSource.aspx.cs" Inherits="Annex.UserControl.Template.Source.EditSource" %>
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
                                    <li class="breadcrumb-item active">Sources</li>
                                </ol>
                            </div>
                            <h4 class="page-title">Edit Source</h4>
                        </div>
                    </div>
                </div>
                <!-- end page title end breadcrumb -->

                <div class="row">
                    <div class="col-12">
                        <div class="card m-b-30">
                            <div class="card-body">


                                <div class="form-group row">
                                    <label  class="col-sm-2 font-weight-bold">Name</label>
                                    <div class="col-sm-10">
                                        <asp:TextBox runat="server" ID="SourceTitle" CssClass="form-control"></asp:TextBox>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="SourceTitle" ErrorMessage="Please Enter a Title" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                               <div class="form-group row">
                                    <label class="col-sm-2 font-weight-bold">Source URL</label>
                                    <div class="col-sm-10">
                                        <asp:TextBox runat="server" ID="Source_Url" CssClass="form-control"></asp:TextBox>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Source_Url" ErrorMessage="Please Enter an Url" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-check-group row">
                                    <label class="col-sm-2 font-weight-bold">Language</label> 
                                    <div class="col-sm-10">
                                        <asp:DropDownList ID="ddlLanguageId" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                <br /><br />
                                <div class="form-group row">
                                    <label class="col-sm-2 font-weight-bold">Published?</label>
                                    <div class="col-sm-10">
                                        <asp:CheckBox runat="server" ID="IsPublished" ></asp:CheckBox>
                                    </div>
                                </div>
                                <div class="form-group row col-2">
                                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="Edit_Click" CssClass="btn-primary form-control" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
