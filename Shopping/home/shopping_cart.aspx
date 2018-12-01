<%@ Page Title="" Language="C#" MasterPageFile="~/home/home.Master" AutoEventWireup="true" CodeBehind="shopping_cart.aspx.cs" Inherits="Shopping.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 887px;
        }
    </style>
     <title>Cart</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCoursel" runat="server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="span9 spad">
        <ul class="breadcrumb">
            <li><a href="shop.aspx">Home</a> <span class="divider">/</span></li>
            <li class="active">SHOPPING CART</li>
        </ul>
        <h3>SHOPPING CART [ <small>
            <asp:Label ID="LabelCartItemCount" runat="server" Text="0"></asp:Label>
            Item(s) </small>]<a href="shop.aspx" class="btn btn-large pull-right">
                <i class="icon-arrow-left"></i> Continue Shopping </a>
        </h3>


        <table class="table  table-bordered">
            <thead>
                <tr>
                    <th>Product </th>
                    <th>Quantity/Cancel</th>
                    <th>Price</th>             
                    <th>Total</th>
                </tr>
            </thead>
            <tbody>
                <asp:DataList ID="DataList1" runat="server" BorderColor="White" BorderWidth="0px" GridLines="Vertical">
                    <ItemTemplate>
                        <tr>
                            <td style="padding-right:75px; padding-left:50px">
                                <asp:Image width="80" ImageUrl='<%# Eval("ProductImagePath") %>' ID="Image1" runat="server" />
                               <%-- <img width="80" src='<%# Eval("ProductImagePath") %>' alt="" />--%>
                            </td>
                            <td style="padding-right:125px; padding-left:125px" >
                                <div class="input-append">
                                    <asp:TextBox ID="TextBoxQuantity" Text='<%# Eval("ProductQuantity") %>' class="span1" Style="max-width: 34px" placeholder="1" Font-Size="16" runat="server" TextMode="Number" ReadOnly="True"></asp:TextBox>
                                    <asp:LinkButton ID="LinkButtonRemove" CssClass="btn btn-danger" OnCommand="LinkButtonCart_Command" CommandArgument='<%# Eval("ProductId") %>' runat="server"> Remove</asp:LinkButton>
                                </div>
                            </td>
                            <td style="padding-right:125px; padding-left:50px">
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("ProductPrice") %>'></asp:Label></td>
                            <td style="padding-right:0px; padding-left:0px">
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("ProductPriceTotal") %>'></asp:Label></td>
                        </tr>
                    </ItemTemplate>
                </asp:DataList>
            </tbody>
        </table>
        <hr />
        <div style="text-align: right; padding-right:20px"> Total: <asp:Label ID="LabelTotalPrice" runat="server" Text=""></asp:Label> Tk</div>
        <div class="spad"></div>
     <a href="shop.aspx" class="btn btn-large"><i class="icon-arrow-left"></i> Continue Shopping </a>
	<a href="orderplace.aspx" class="btn btn-large pull-right">Place Order <i class="icon-arrow-right"></i></a>

    </div>
</asp:Content>
