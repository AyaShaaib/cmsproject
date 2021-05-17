<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditMenu.aspx.cs" Inherits="Annex.UserControl.Template.Menu.EditMenu" %>
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
                                    <li class="breadcrumb-item active">Menus</li>
                                </ol>
                            </div>
                            <h4 class="page-title">Add Menu</h4>
                        </div>
                    </div>
                </div>
                <!-- end page title end breadcrumb -->

                <div class="row">
                    <div class="col-12">
                        <div class="card m-b-30">
                            <div class="card-body">

                                <div class="form-group row col-6">
                                    <label class="col-sm-12 font-weight-bold">Title</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox runat="server" ID="txtMenuTitle" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMenuTitle" ErrorMessage="Please Enter a Title" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group row col-6">
                                    <label class="col-sm-2 font-weight-bold">Picture</label> 
                                    <div class="col-sm-12">
                                        <asp:FileUpload ID="FileUploadMenuPicture" runat="server" CssClass="form-control"/>
                                        <asp:Label ID="lblFileUploadMenuPicture" runat="server"></asp:Label>
                                        <asp:Label ID="lblFileUploadMenuPicturePath" runat="server"></asp:Label>
                                    </div>
                                </div><br />
                                <div class="row">
                                    <div class="form-check-group col-6">
                                    <label class="col-sm-12 font-weight-bold">Parent</label> 
                                    <div class="col-sm-12">
                                        <asp:DropDownList ID="ddlParentID" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group col-6">
                                    <label class="col-sm-12 font-weight-bold">Order</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox runat="server" ID="txtMenuOrder" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                                </div><br />
                                <div class="row">
                                    <div class="form-check-group col-6">
                                    <label class="col-sm-12 font-weight-bold">Direction</label> 
                                    <div class="col-sm-12">
                                        <asp:DropDownList ID="ddlDirectionID" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                    <div class="form-check-group col-6">
                                    <label class="col-sm-12 font-weight-bold">Language</label> 
                                    <div class="col-sm-12">
                                        <asp:DropDownList ID="ddlLanguageID" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                </div><br /><br />
                                <div class="row">
                                    <div class="form-group col-6">
                                        <label  class="col-sm-5 font-weight-bold">Meta Title</label>
                                        <div class="col-sm-12">
                                           <asp:TextBox runat="server" ID="txtMetaTitle" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group col-6">
                                        <label class="col-sm-5 font-weight-bold">Meta Keyword</label>
                                        <div class="col-sm-12">
                                            <asp:TextBox runat="server" ID="txtMetaKeyword" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                               </div>
                                <br />
                                <div class="form-group col">
                                    <label class="col-sm-2 font-weight-bold">Description</label>
                                    <div class="col-sm-12">
                                        <textarea runat="server" id="MetaDescription" class="ckeditor"></textarea>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="MetaDescription" ErrorMessage="Please Enter a Description " ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <br />
                                <div class="form-group row">
                                    <label class="col-sm-2 font-weight-bold">Published?</label>
                                    <div class="col-sm-10">
                                        <asp:CheckBox runat="server" ID="chkPublished"></asp:CheckBox>
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
    </div>
</asp:Content>
