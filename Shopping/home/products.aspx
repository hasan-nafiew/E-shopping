<%@ Page Title="" Language="C#" MasterPageFile="~/home/home.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="Shopping.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Products</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCoursel" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="span9 spad">
        <ul class="breadcrumb">
            <li><a href="shop.aspx">Home</a> <span class="divider">/</span></li>
            <li class="active">Products Name</li>
        </ul>
        <h3>
            <asp:Label ID="LabelProductTitle" runat="server" Text="Products"></asp:Label>
            <small class="pull-right">
                <asp:Label ID="LabelProductCount" runat="server" Text=""></asp:Label></small></h3>
        <hr class="soft" />
        <p>
            Nowadays the Computer Accessories industry is one of the most successful business spheres. We always stay in touch with the latest fashion tendencies - that is why our goods are so popular and we have a great number of faithful customers all over the country.
        </p>
        <hr class="soft" />

        <div class="thumbnails ">
            <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" CellPadding="25">
                <ItemTemplate>
                    <div class="thumbnail">
                        <asp:Image ID="Image1" title='<%# Eval("ProductName") %>' CssClass="imageProduct" ImageUrl='<%# Eval("ProductImagePath") %>' alt='<%# Eval("ProductName") %>' runat="server" />
                        <%--<img src='<%# Eval("ProductImagePath") %>' title='<%# Eval("ProductName") %>' alt='<%# Eval("ProductName") %>' class="imageProduct" />--%>
                        <div class="caption">
                            <h5>
                                <asp:Label ID="LabelProduct" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label></h5>
                            <h4 style="text-align: center"><a class="btn" href="product_details.aspx?view='<%# Eval("ProductId") %>'"><i class="icon-zoom-in"></i></a>
                                <asp:LinkButton ID="LinkButtonAddCart" OnCommand="LinkButtonCart_Command" CommandArgument='<%# Eval("ProductId") %>' CssClass="btn" runat="server">Add To <i class="icon-shopping-cart"></i></asp:LinkButton>
                                <a class="btn btn-primary" href="#">
                                    <asp:Label ID="LabelCollumProduct2Price" runat="server" Text='<%# Eval("ProductPrice") %>'></asp:Label></a>
                            </h4>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</asp:Content>
