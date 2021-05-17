<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Annex.UserControl.Template.User.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="accountbg"></div>

    
    <div class="wrapper-page">
           <div class="card">
                <div class="card-body">

                    <h3 class="text-center mt-0 m-b-15">
                        <a href="default.aspx" class="logo logo-admin"><img  src="../../../assets/images/logo.png" height="24" alt="logo"/></a>
                    </h3>

                    <div class="p-3">
                        
                    <div class="form-group row">
                                <div class="col-12">
                                    <asp:TextBox ID="txtFname" runat="server" class="form-control"  required="" placeholder="First name"/>
                                </div>
                            </div>
                        <div class="form-group row">
                                <div class="col-12">
                                    <asp:TextBox ID="txtLname" runat="server" class="form-control"  required="" placeholder="Last name"/>
                                </div>
                            </div>
                          <div class="form-group row">
                                <div class="col-12">
                                    <asp:TextBox ID="txtEmail" runat="server" class="form-control"  required="" placeholder="Email"/>
                                </div>
                            </div>
                        
                            <div class="form-group row">
                                <div class="col-12">
                                    <asp:TextBox ID="txtPhone" runat="server" class="form-control"  required="" placeholder="Phone"/>
                                </div>
                            </div>

                            <div class="form-group row">
                                <div class="col-12">
                                    <asp:TextBox runat="server" ID="txtPass" class="form-control" TextMode="Password" required="" placeholder="Password"/>
                                </div>
                            </div>
                        <div class="form-group row">
                                <div class="col-12">
                                    <asp:TextBox runat="server" ID="txtCpass" class="form-control" TextMode="Password" required="" placeholder="Confirm Password"/>
                              </div>
                            </div>
                         
                       <div class="form-group row">
                                <div class="col-12">
                                    <div class="custom-control">
                                        <asp:CheckBox runat="server"  id="customCheck1"/>
                                        <label>I accept <a href="#" class="text-muted">Terms and Conditions</a></label>
                                    </div>
                                </div>
                            </div>

                            <div class="form-group text-center row m-t-20">
                                <div class="col-12">
                                    <asp:Button runat="server" class="btn btn-danger btn-block "  Text="Register" ID="regbtn" OnClick="regbtn_Click" ></asp:Button>
                                </div>
                            </div>
                      <div class="form-group text-center row m-t-20">
                                <div class="col-12">
                        <asp:CompareValidator runat="server" ID="Comp1" ControlToValidate="txtPass" ControlToCompare="txtCpass" Text="Password mismatch" Font-Size="11px" ForeColor="Red"/>
                          </div></div>
                                    <div class="form-group m-t-10 mb-0 row">
                                <div class="col-12 m-t-20 text-center">
                                    <a href="pages-default.aspx" class="text-muted">Already have account?</a>
                                </div>
                            </div>
    
                    </div>

                </div>
            </div>
        </div>
    


</asp:Content>
