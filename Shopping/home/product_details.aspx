<%@ Page Title="" Language="C#" MasterPageFile="~/home/home.Master" AutoEventWireup="true" CodeBehind="product_details.aspx.cs" Inherits="Shopping.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Product Details</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCoursel" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="span9c spad">
        <ul class="breadcrumb">
            <li><a href="shop.aspx">Home</a> <span class="divider">/</span></li>
            <li><a href="products.aspx">Products</a> <span class="divider">/</span></li>
            <li class="active">product Details</li>
        </ul>
    <div class="row">
        <div id="gallery" class="span3">
            <a href="#" title="Fujifilm FinePix S2950 Digital Camera">
                <asp:Image ID="ImageProduct"  style="width: 100%" alt="#" runat="server" />
            </a>
        </div>
        <div class="span6">
            <h3>
                <asp:Label ID="LabelProductName" runat="server" Text="Camera"></asp:Label></h3>
            <hr class="soft" />

            <div class="control-group">
                <label class="control-label"><span><asp:Label ID="LabelProductPrice" runat="server" Text="Label"></asp:Label></span></label>
                <div class="controls">
                    <asp:TextBox ID="TextBoxQuantity" FilterType="Numbers" CssClass="span1" placeholder="Qty" runat="server" ReadOnly="True"></asp:TextBox>
                    <asp:LinkButton class="btn btn-large btn-primary pull-right"  ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">  Add to cart <i class=" icon-shopping-cart"></i></asp:LinkButton>
                </div>
            </div>

            <hr class="soft" />
            <h4>
                <asp:Label ID="LabelItemQuantity" runat="server" Text="100"></asp:Label>
                items in stock</h4>
            <hr class="soft clr" />
            <p>
                <h4>Details:</h4>
               <asp:Label ID="LabelProductDetails" runat="server" Text="14 Megapixels. 18.0 x Optical Zoom. 3.0-inch LCD Screen. Full HD photos and 1280 x 720p HD movie capture. ISO sensitivity ISO6400 at reduced resolution. 
				Tracking Auto Focus. Motion Panorama Mode. Face Detection technology with Blink detection and Smile and shoot mode. 4 x AA batteries not included. WxDxH 110.2 ×81.4x73.4mm. 
				Weight 0.341kg (excluding battery and memory card). Weight 0.437kg (including battery and memory card"></asp:Label>
            </p>
        </div>
        </div>
    </div>
</asp:Content>
