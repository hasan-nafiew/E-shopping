<%@ Page Title="" Language="C#" MasterPageFile="~/home/home.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Shopping.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <div class="span9 spad">
        <ul class="breadcrumb">
            <li><a href="shop.aspx">Home</a> <span class="divider">/</span></li>
            <li class="active">Login</li>
        </ul>
        <h3>Login</h3>
        <hr class="soft" />
        <div class="row">
            <div class="span4">
                <div class="well">
                    <h5>CREATE YOUR ACCOUNT</h5>
                    <br />
                    Enter your e-mail address to create an account.<br />
                    <br />
                    <br />
                    <div>
                        <div class="control-group">
                            <label class="control-label" for="inputEmail0">E-mail address</label>
                            <div class="controls">
                                <asp:TextBox ID="TextBoxEmailRegister" placeholder="example@mail.com" class="span3" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="controls">
                            <asp:Button ID="ButtonRegister" CssClass="btn block" runat="server" Text="Create Your Account" OnClick="ButtonRegister_Click" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="span1">&nbsp;</div>
            <div class="span4">
                <div class="well">
                    <h5>ALREADY REGISTERED ?</h5>
                    <div>
                        <div class="control-group">
                            <label class="control-label" for="inputEmail1">Email</label>
                            <div class="controls">
                                <asp:TextBox ID="TextBoxLoginMail" placeholder="example@mail.com" class="span3" runat="server" TextMode="Email"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="inputPassword1">Password</label>
                            <div class="controls">
                                <asp:TextBox ID="TextBoxPassword" placeholder="Password" class="span3" runat="server" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <div class="controls">
                                <asp:Label ID="LabelLStaus" runat="server" ForeColor="#CC3300"></asp:Label>
                            </div>

                        </div>
                        <div class="control-group">
                            <div class="controls">
                                <asp:Button ID="ButtonLogin" CssClass="btn block" runat="server" Text="Sign In" OnClick="ButtonLogin_Click" />
                                <asp:LinkButton ID="lnkFacebook" runat="server" CssClass="btn btn-danger" data-provider="google"
                                    Text="Google+" OnClick="RedirectToLogin_Click" ForeColor="White" /><br />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
