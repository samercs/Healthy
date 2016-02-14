<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Healthy.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <h3 class="panel-title">Change Password</h3>
        </div>
        <div class="panel-body">
            <asp:Panel CssClass="alert" Visible="False" ID="Panel1" runat="server">
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </asp:Panel>

            <div class="row">
                <div class="col-md-6 col-md-offset-3">
                    <div class="form-group">
                        <label class="col-lg-4 control-label">current Password</label>
                        <div class="col-lg-8">
                            <asp:TextBox TextMode="Password" ID="txtPassword1" CssClass="form-control" placeholder="current Password" required="true" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-lg-4 control-label">New Password</label>
                        <div class="col-lg-8">
                            <asp:TextBox TextMode="Password" ID="txtPassword2" CssClass="form-control" placeholder="New Password" required="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <label class="col-lg-4 control-label">Password Confirmation</label>
                        <div class="col-lg-8">
                            <asp:TextBox TextMode="Password" ID="txtPassword3" CssClass="form-control" placeholder="Password Confirmation" required="true" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group text-right">
                        <div class="col-lg-10 col-lg-offset-2">
                            <asp:Button OnClick="btnLogin_OnClick" ID="btnLogin" CssClass="btn btn-primary" runat="server" Text="Change Password" />
                        </div>
                    </div>
                </div>
            </div>




        </div>
    </div>
</asp:Content>
