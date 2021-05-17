<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateCategory.aspx.cs" Inherits="Category.UpdateCategory" %>
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
                                    <li class="breadcrumb-item active">Categories</li>
                                </ol>
                            </div>
                            <h4 class="page-title">Edit Category</h4>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-12">
                        <div class="card m-b-30">
                            <div class="card-body">


                                <div class="form-group row">
                                    <label class="col-sm-2 font-weight-bold">Name</label>
                                    <div class="col-sm-10">
                                        <asp:TextBox ID="txtCategoryName" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCategoryName" ErrorMessage="Please Enter Your Name " ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-2 font-weight-bold">Parent</label>
                                    <div class="col-sm-10">
                                        <asp:DropDownList ID="ddlParentId" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                <br />
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-2 font-weight-bold">Order number</label>
                                    <div class="col-sm-10">
                                        <asp:TextBox ID="txtOrder" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtOrder" ErrorMessage="Please Enter Order Number" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-2 font-weight-bold">Picture</label>
                                    <div class="col-sm-10">
                                        <asp:FileUpload ID="FileUploadCategoryPicture" runat="server" CssClass="form-control" />
                                        <asp:Label ID="lblFileUploadCategoryPicture" runat="server" ></asp:Label>
                                        <asp:Label ID="lblFileUploadCategoryPicturePath" runat="server" ></asp:Label>
                                    </div>
                                </div>
                                <br />
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-2 font-weight-bold">Icon</label>
                                    <div class="col-sm-10">
                                        <asp:FileUpload ID="FileUploadCategoryIcon" runat="server" CssClass="form-control" />
                                        <asp:Label ID="lblFileUploadCategoryIcon" runat="server" ></asp:Label>
                                        <asp:Label ID="lblFileUploadCategoryIconPath" runat="server" ></asp:Label>
                                    </div>
                                </div>
                                <br />
                                <div class="form-check-group row">
                                    <label for="example-text-input" class="col-sm-2 font-weight-bold" >Language</label> 
                                    <div class="col-sm-10">
                                        <asp:DropDownList ID="ddlLanguageId" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                <br />
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-2 font-weight-bold">Published ?</label>
                                    <div class="col-sm-10">
                                        <asp:CheckBox ID="IsPublished" runat="server" />
                                    </div>
                                </div>
                                <div class="form-group row col-2">
                                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="Update_Click" CssClass="btn-primary form-control" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
