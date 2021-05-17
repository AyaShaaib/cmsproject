<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProductType.aspx.cs" Inherits="Annex.UserControl.Template.ProductType.AddProductType" %>
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
                                    <li class="breadcrumb-item active">Product Types</li>
                                </ol>
                            </div>
                            <h4 class="page-title">Add Product Type</h4>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-12">
                        <div class="card m-b-30">
                            <div class="card-body">

                                <div class="form-group row">
                                    <label class="col-sm-2 font-weight-bold">Product Type</label>
                                    <div class="col-sm-10">
                                       <asp:TextBox ID="ProductType" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ProductType" ErrorMessage="Please Enter a Product Type" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label class="col-sm-2 font-weight-bold">Image</label>
                                    <div class="col-sm-10">
                                       <asp:FileUpload ID="FileUploadProductTypePicture" runat="server" CssClass="form-control"/>
                                       <asp:Label ID="lblFileUploadProductTypePicture" runat="server" ></asp:Label>
                                       <asp:Label ID="lblFileUploadProductTypePicturePath" runat="server" ></asp:Label>
                                    </div>
                                </div>
                                <br />
                                <div class="form-check-group row">
                                    <label class="col-sm-2 font-weight-bold">Language</label> 
                                    <div class="col-sm-10">
                                        <asp:DropDownList ID="ddlLanguageId" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                <br />
                                <div class="form-group row col-2">
                                    <asp:Button ID="btnEdit" runat="server" Text="Add" class="btn-primary" OnClick="Insert_Click" CssClass="btn-primary form-control" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
