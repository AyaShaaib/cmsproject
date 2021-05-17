<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertNews.aspx.cs" Inherits="Annex.UserControl.Template.News.InsertNews" ValidateRequest="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ValidateRequest="false">
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
                                    <li class="breadcrumb-item active">News</li>
                                </ol>
                            </div>
                            <h4 class="page-title">Insert News</h4>

                        </div>
                    </div>
                </div>
                <!-- end page title end breadcrumb -->

                <div class="row">
                    <div class="col-12">
                        <div class="card m-b-30">
                            <div class="card-body">
                                <div class="row">
                                <div class="form-group col-6">
                                    
                                    <label  class="col-sm-12 font-weight-bold">Published Date</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox runat="server" TextMode="Date" ID="PublishedDate" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="PublishedDate" ErrorMessage="Please Enter the Published Date " ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                    </div>
                                <div class="row">
                                    <div class="form-group col-6">
                                        <label  class="col-sm-5 font-weight-bold">Title</label>
                                        <div class="col-sm-12">
                                           <asp:TextBox ID="NewsTitle" runat="server" CssClass="form-control" ></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="NewsTitle" ErrorMessage="Please Enter a Title " ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="form-group col-6">
                                        <label  class="col-sm-5 font-weight-bold">SubTitle</label>
                                        <div class="col-sm-12">
                                           <asp:TextBox ID="NewsSubtitle" runat="server" CssClass="form-control"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="NewsSubTitle" ErrorMessage="Please Enter a Subtitle" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                               </div>
                                <div class="row">
                                    <div class="form-group col-6">
                                        <label  class="col-sm-5 font-weight-bold">Author</label>
                                        <div class="col-sm-12">
                                           <asp:DropDownList ID="ddlAuthorId" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="form-group col-6">
                                        <label class="col-sm-5 font-weight-bold">Source</label>
                                        <div class="col-sm-12">
                                            <asp:DropDownList ID="ddlSourceId" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                    </div>
                               </div>
                                <br />
                                <div class="row">
                                    <div class="form-group col-6">
                                        <label  class="col-sm-5 font-weight-bold">Language</label>
                                        <div class="col-sm-12">
                                           <asp:DropDownList ID="ddlLanguageId" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="form-group col-6">
                                        <label  class="col-sm-5 font-weight-bold">YouTube_URL</label>
                                        <div class="col-sm-12">
                                           <asp:TextBox ID="Youtube_Url" runat="server" CssClass="form-control "></asp:TextBox>
                                        </div>
                                    </div>
                               </div>
                                <br />
                            <div class="row">
                                    <div class="form-group col-6">
                                        <label  class="col-sm-5 font-weight-bold">Google AD 1</label>
                                        <div class="col-sm-12">
                                           <asp:TextBox ID="First_AD" runat="server" CssClass="form-control " ></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group col-6">
                                        <label  class="col-sm-5 font-weight-bold">Google AD 2</label>
                                        <div class="col-sm-12">
                                           <asp:TextBox ID="Second_AD" runat="server" CssClass="form-control "></asp:TextBox>
                                        </div>
                                    </div>
                               </div>
                                <br />
                                <div class="row">
                                    <div class="form-group col-6">
                                        <label  class="col-sm-5 font-weight-bold">Google AD 3</label>
                                        <div class="col-sm-12">
                                           <asp:TextBox ID="Third_AD" runat="server" CssClass="form-control" ></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group col-6">
                                        <label  class="col-sm-5 font-weight-bold">Google AD 4</label>
                                        <div class="col-sm-12">
                                           <asp:TextBox ID="Fourth_AD" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                               </div>
                                <br />
                                <div class="row">
                                    <div class="form-group col-6">
                                        <label  class="col-sm-5 font-weight-bold">Google AD 5</label>
                                        <div class="col-sm-12">
                                           <asp:TextBox ID="Fifth_AD" runat="server" CssClass="form-control " ></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group col-6">
                                        <label  class="col-sm-5 font-weight-bold">Google AD 6</label>
                                        <div class="col-sm-12">
                                           <asp:TextBox ID="Sixth_AD" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                               </div>
                                <br />
                            <div class="form-group col">
                                    <label class="col-sm-2 font-weight-bold">Description</label>
                                    <div class="col-sm-12">
                                        <textarea runat="server" id="NewsDescription" class="ckeditor"></textarea>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="NewsDescription" ErrorMessage="Please Enter a Description " ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label  class="col-sm-2 font-weight-bold">Break New?</label>
                                    <div class="col-sm-10">
                                        <asp:CheckBox ID="Break_News" runat="server" />
                                    </div>
                                </div>
                                <div class="form-group row col-2">
                                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn-primary" OnClick="Submit_Click" CssClass="btn-primary form-control"/>
                                </div>
                            </div>
                             </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
