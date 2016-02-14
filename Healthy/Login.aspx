<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Healthy.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="body">
        <div class="section">

            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Sing In</h3>
                </div>
                <div class="panel-body">
                    <asp:Panel CssClass="alert" Visible="False" ID="Panel1" runat="server">
                        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                    </asp:Panel>

                    <div class="row">
                        <div class="col-md-6 col-md-offset-3">
                            <div class="form-group">
                                <label class="col-lg-4 control-label">User Name</label>
                                <div class="col-lg-8">
                                    <asp:TextBox ID="txtUserName" CssClass="form-control" placeholder="Uesr Name" required="true" runat="server"></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-lg-4 control-label">Password</label>
                                <div class="col-lg-8">
                                    <asp:TextBox ID="txtPassword" TextMode="Password" CssClass="form-control" placeholder="Last Name" required="true" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group text-right">
                                <div class="col-lg-10 col-lg-offset-2">
                                    <asp:Button OnClick="btnLogin_OnClick" ID="btnLogin" CssClass="btn btn-primary" runat="server" Text="Login" />
                                    <asp:Button ID="btnForgetPassword" CssClass="btn btn-warning" runat="server" Text="Forget Password ?" />
                                </div>
                            </div>
                        </div>
                    </div>




                </div>
            </div>

        </div>
    </div>
</asp:Content>
