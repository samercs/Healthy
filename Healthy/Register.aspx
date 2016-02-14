<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Healthy.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" href="Scripts/UI/jquery-ui.min.css" rel="stylesheet" />
    <script src="Scripts/UI/jquery-ui.min.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="body">
        <div class="section">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Sing Up</h3>
                </div>
                <div class="panel-body">

                    <asp:Panel CssClass="alert" Visible="False" ID="Panel1" runat="server">
                        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                    </asp:Panel>


                    <fieldset>

                        <div class="form-group">
                            <label class="col-lg-2 control-label">First Name</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="txtFName" CssClass="form-control" placeholder="First Name" required="true" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label">Last Name</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="txtLName" CssClass="form-control" placeholder="Last Name" required="true" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label">Nationality</label>
                            <div class="col-lg-10">
                                <asp:DropDownList ID="ddlCountry" CssClass="form-control" runat="server"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label">Birth Date</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="txtBirthDate" CssClass="form-control" placeholder="Birth Date" required="true" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label">Email</label>
                            <div class="col-lg-10">
                                <asp:TextBox TextMode="Email" ID="txtEmail" CssClass="form-control" placeholder="Email" required="true" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label">User Name</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="txtUserName" CssClass="form-control" placeholder="User Name" required="true" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label">Password</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="txtPassword" TextMode="Password" CssClass="form-control" placeholder="Password" required="true" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                                <asp:Button OnClick="Button1_OnClick" ID="Button1" CssClass="btn btn-primary" runat="server" Text="Submit" />

                            </div>
                        </div>
                    </fieldset>

                </div>
            </div>
        </div>
    </div>




    <script type="text/javascript">

        $(function () {

            $("#<%=txtBirthDate.ClientID%>").datepicker();

        });
    </script>

</asp:Content>
