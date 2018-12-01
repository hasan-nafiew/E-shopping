<%@ Page Title="" Language="C#" MasterPageFile="~/home/home.Master" AutoEventWireup="true" CodeBehind="orderplace.aspx.cs" Inherits="Shopping.WebForm8" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCoursel" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="span12 spad">
        <ul class="breadcrumb">
            <li><a href="shop.aspx">Home</a> <span class="divider">/</span></li>
            <li><a href="shopping_cart.aspx">Shopping Cart</a> <span class="divider">/</span></li>
            <li class="active">Order Place</li>
        </ul>
        <hr class="soft" />
        <h3>Order Confirmation</h3>
        <div class="well">
            <div id="orderform" runat="server" class="form-horizontal">
                <h4>Please Check This & Update Your Latest Information</h4>
                <div class="control-group">
                    <label class="control-label" for="inputFname1">Name </label>
                    <div class="controls">
                        <asp:TextBox ID="TextBoxName" AutoPostBack="True" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label" for="inputLnam">Email </label>
                    <div class="controls">
                        <asp:TextBox ID="TextBoxMail" AutoPostBack="True" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label" for="input_email">Address </label>
                    <div class="controls">
                        <asp:TextBox ID="TextBoxAddress" AutoPostBack="True" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label" for="inputPassword1">Contact </label>
                    <div class="controls">
                        <asp:TextBox ID="TextBoxCntact" AutoPostBack="True" runat="server"></asp:TextBox>  
                    </div>
                </div>
 
                <div class="control-group">
                    <div class="controls">
                        <asp:Button ID="ButtonConfirm" CssClass="btn btn-success" runat="server" Text="Confirm Order" OnClick="ButtonConfirm_Click" />
                    </div>
                </div>
            </div>
            <div id="confirm" runat="server">
                <p>Order Confirmed. Check Your Mail For Update. We will contact with you for deliverying your product(s).</p>
            </div>
             <hr class="soft" />
        </div>
    </div>
</asp:Content>
