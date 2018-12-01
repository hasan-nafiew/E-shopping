<%@ Page Title="" Language="C#" MasterPageFile="~/home/home.Master" AutoEventWireup="true" CodeBehind="shop.aspx.cs" Inherits="Shopping.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home</title>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderCoursel" runat="server" >
    <div id="carouselBlk">
        <div id="myCarousel" class="carousel slide">
            <div class="carousel-inner">
                <div class="item active">
                    <div class="container">
                        <a href="register.aspx">
                            <img style="width: 100%" src="themes/images/carousel/4.png" alt="special offers" /></a>
                        <div class="carousel-caption">
                            <h4>Second Thumbnail label</h4>
                            <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                        </div>
                    </div>
                </div>
                <div class="item">
                    <div class="container">
                        <a href="register.aspx">
                            <img style="width: 100%" src="themes/images/carousel/2.png" alt="" /></a>
                        <div class="carousel-caption">
                            <h4>Second Thumbnail label</h4>
                            <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                        </div>
                    </div>
                </div>
                <div class="item">
                    <div class="container">
                        <a href="register.aspx">
                            <img src="themes/images/carousel/3.png" alt="" /></a>
                        <div class="carousel-caption">
                            <h4>Second Thumbnail label</h4>
                            <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                        </div>

                    </div>
                </div>
                <div class="item">
                    <div class="container">
                        <a href="register.aspx">
                            <img src="themes/images/carousel/4.png" alt="" /></a>
                        <div class="carousel-caption">
                            <h4>Second Thumbnail label</h4>
                            <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                        </div>

                    </div>
                </div>
                <div class="item">
                    <div class="container">
                        <a href="register.aspx">
                            <img src="themes/images/carousel/5.png" alt="" /></a>
                        <div class="carousel-caption">
                            <h4>Second Thumbnail label</h4>
                            <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                        </div>
                    </div>
                </div>
                <div class="item">
                    <div class="container">
                        <a href="register.aspx">
                            <img src="themes/images/carousel/6.png" alt="" /></a>
                        <div class="carousel-caption">
                            <h4>Second Thumbnail label</h4>
                            <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                        </div>
                    </div>
                </div>
            </div>
            <a class="left carousel-control" href="#myCarousel" data-slide="prev">&lsaquo;</a>
            <a class="right carousel-control" href="#myCarousel" data-slide="next">&rsaquo;</a>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    
    <div class="thumbnails">
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" CellPadding="25"  >
            <ItemTemplate>
                <div class="thumbnail">
                    <asp:Image ID="Image1" title='<%# Eval("ProductName") %>' CssClass="imageProduct" ImageUrl='<%# Eval("ProductImagePath") %>' alt='<%# Eval("ProductName") %>' runat="server" />
                            <%--<img src='<%# Eval("ProductImagePath") %>' title='<%# Eval("ProductName") %>' alt='<%# Eval("ProductName") %>' class="imageProduct" />--%>
                            <div class="caption">
                                <h5>
                                    <asp:Label ID="LabelProduct" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label></h5>
                                <h4 style="text-align: center"><a class="btn" href="product_details.aspx?view='<%# Eval("ProductId") %>'"><i class="icon-zoom-in"></i></a>
                                    <asp:LinkButton ID="LinkButtonCart" CssClass="btn" OnCommand="LinkButtonCart_Command" CommandArgument='<%# Eval("ProductId") %>' runat="server" >Add To <i class="icon-shopping-cart"></i></asp:LinkButton>
                                    <a class="btn btn-primary" href="#">
                                    <asp:Label ID="LabelCollumProduct2Price" runat="server" Text='<%# Eval("ProductPrice") %>'></asp:Label></a>
                                </h4>
                            </div>
                        </div>
            </ItemTemplate>
        </asp:DataList>
    </div>

</asp:Content>
