<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditContent.aspx.cs" Inherits="Annex.UserControl.Template.Content.EditContent" ValidateRequest="False" %>

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
                                    <li class="breadcrumb-item active">Colors</li>
                                </ol>
                            </div>
                            <h4 class="page-title">Add Color</h4>
                        </div>
                    </div>
                </div>
                <!-- end page title end breadcrumb -->

                <div class="row">
                    <div class="col-12">
                        <div class="card m-b-30">
                            <div class="card-body">
                                <div class="row">
                                <div class="form-check-group col-6">
                                    <label class="col-sm-12 font-weight-bold">Date</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox runat="server" ID="PublishedDate" CssClass="form-control" textMode="Date"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="PublishedDate" ErrorMessage="Please Enter a Date" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                    </div>
                                <div class="row">
                                <div class="form-check-group col-6">
                                    <label class="col-sm-12 font-weight-bold">Title</label> 
                                    <div class="col-sm-12">
                                     <asp:TextBox runat="server" ID="txtContentTitle" CssClass="form-control" ></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtContentTitle" ErrorMessage="Please Enter a Title" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group col-6">
                                    <label class="col-sm-12 font-weight-bold">SubTitle</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox runat="server" ID="txtContentSubTitle" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtContentSubTitle" ErrorMessage="Please Enter a SubTitle" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                    </div>
                                <div class="row">
                                    <div class="form-check-group col-6">
                                    <label class="col-sm-12 font-weight-bold" >Menu</label> 
                                    <div class="col-sm-12">
                                        <asp:DropDownList ID="ddlMenuID" runat="server" CssClass="form-control"></asp:DropDownList>

                                    </div>
                                </div>
                                    <div class="form-check-group col-6">
                                    <label class="col-sm-12 font-weight-bold" >Album</label> 
                                    <div class="col-sm-12">
                                        <asp:DropDownList ID="ddlAlbumID" runat="server" CssClass="form-control"></asp:DropDownList>

                                    </div>
                                </div>
                                </div>
                                <br />
                                 <div class="row">
                                    <div class="form-check-group col-6">
                                    <label class="col-sm-12 font-weight-bold" >Author</label> 
                                    <div class="col-sm-12">
                                        <asp:DropDownList ID="ddlAuthorID" runat="server" CssClass="form-control"></asp:DropDownList>

                                    </div>
                                </div>
                                    <div class="form-check-group col-6">
                                    <label class="col-sm-12 font-weight-bold" >Category</label> 
                                    <div class="col-sm-12">
                                        <asp:DropDownList ID="ddlCategoryID" runat="server" CssClass="form-control"></asp:DropDownList>

                                    </div>
                                </div>
                                </div>
                                <br />
                                <div class="row">
                                                <div class="form-group col-6">
                                                <label  class="col-sm-12 font-weight-bold">Start Date & Time</label>
                                                <div class="col-sm-12">
                                                    <asp:TextBox ID="txtStartDateTime" runat="server" TextMode="DateTimeLocal" CssClass="form-control"></asp:TextBox>
                                                </div>
                                            </div>                                        
                                        <div class="form-group col-6">
                                            <label class="col-sm-12 font-weight-bold">End Date & Time</label>
                                            <div class="col-sm-12">
                                                <asp:TextBox ID="txtEndDateTime" runat="server" TextMode="DateTimeLocal" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        </div>
                                <br />
                                <div class="row">
                                    <div class="form-group col-4">
                                            <label class="col-sm-12 font-weight-bold">Image</label>
                                            <div class="col-sm-12">
                                                <asp:FileUpload ID="FileUploadContentImage" runat="server" CssClass="form-control" />
                                                <asp:Label ID="lblFileUploadContentImage" runat="server"></asp:Label>
                                                <asp:Label ID="lblFileUploadContentImagePath" runat="server"></asp:Label>
                                            </div>
                                        </div>
                                   <div class="form-group col-4">
                                            <label  class="col-sm-12 font-weight-bold">File</label>
                                            <div class="col-sm-12">
                                                <asp:FileUpload ID="FileUploadContentFile" runat="server" CssClass="form-control"/>
                                                <asp:Label ID="lblFileUploadContentFile" runat="server"></asp:Label>
                                                <asp:Label ID="lblFileUploadContentFilePath" runat="server"></asp:Label>
                                            </div>
                                        </div>
                                    <div class="form-group col-4">
                                            <label class="col-sm-12 font-weight-bold">Thumbnail</label>
                                            <div class="col-sm-12">
                                                <asp:FileUpload ID="FileUploadThumbnailContent" runat="server" CssClass="form-control" />
                                                <asp:Label ID="lblFileUploadThumbnailContent" runat="server"></asp:Label>
                                                <asp:Label ID="lblFileUploadThumbnailContentPath" runat="server"></asp:Label>
                                            </div>
                                        </div>
                                </div>
                                <div class="row">
                                    <div class="form-group col-4">
                                            <label class="col-sm-12 font-weight-bold">Text(1)</label>
                                            <div class="col-sm-12">
                                                <asp:TextBox ID="txtCustomText1" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    <div class="form-group col-4">
                                            <label class="col-sm-12 font-weight-bold">Text(2)</label>
                                            <div class="col-sm-12">
                                                <asp:TextBox ID="txtCustomText2" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    <div class="form-group col-4">
                                            <label class="col-sm-12 font-weight-bold">Text(3)</label>
                                            <div class="col-sm-12">
                                                <asp:TextBox ID="txtCustomText3" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                </div>
                                <div class="form-group col">
                                    <label class="col-sm-2 font-weight-bold">Description</label>
                                    <div class="col-sm-12">
                                        <textarea runat="server" id="Description" class="ckeditor"></textarea>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Description" ErrorMessage="Please Enter a Description " ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
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
                                    <label class="col-sm-2 font-weight-bold">Meta Description</label>
                                    <div class="col-sm-12">
                                        <textarea runat="server" id="MetaDescription" class="ckeditor"></textarea>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="MetaDescription" ErrorMessage="Please Enter a Description " ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="form-check-group col-6">
                                    <label class="col-sm-12 font-weight-bold" >Language</label> 
                                    <div class="col-sm-12">
                                        <asp:DropDownList ID="ddlLanguageID" runat="server" CssClass="form-control"></asp:DropDownList>

                                    </div>
                                </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="form-group col-6">
                                        <label class="col-sm-12 font-weight-bold">Summary</label>
                                        <div class="col-sm-12">
                                            <asp:TextBox runat="server" ID="txtSummary" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="form-group col-6">
                                    <label  class="col-sm-12 font-weight-bold">Published?</label>
                                    <div class="col-sm-12">
                                        <asp:CheckBox ID="chkPublished" runat="server" />
                                    </div>
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
