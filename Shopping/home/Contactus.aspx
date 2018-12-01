<%@ Page Title="" Language="C#" MasterPageFile="~/home/home.Master" AutoEventWireup="true" CodeBehind="Contactus.aspx.cs" Inherits="Shopping.Contact_Us" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Contact Us</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCoursel" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server"> 
<div class="span12">
    <h2>
            <asp:Label ID="LabelProductTitle" runat="server" Text="Contact Us"></asp:Label>
    </h2>
    <hr class="soft" />

    <p><h3>ElectroBuzz</h3></p>
    <p>Bdjobs.com Limited</p>
    <p>19th Floor</p>
    <p>BDBL Building</p>
    <p>12, Kawran Bazar C/A</p>
    <p>Dhaka-1215, Bangladesh</p>
    <hr class="soft" />
</div>
    <div class="row">
         <div class="span6" align="center" id="map" style="width:600px;height:510px;">
                
        </div>
        <div class="span6">
             <div>
    <h2>
            <asp:Label ID="Label1" runat="server" Text="Feedback  Us"></asp:Label>
    </h2>
    <hr class="soft" />
<table align="center" class="auto-style1">
    <tr>
        <td>
            <asp:Label ID="lblName" runat="server" Text="Enter Name"></asp:Label>

        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Please Enter Name"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblEmail" runat="server" Text="Enter your Email"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please Enter Valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
    </tr>
        <tr>
        <td>
            <asp:Label ID="lblFeedback" runat="server" Text="Feedback"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtFeedback" runat="server" class="form-control" Rows="7" TextMode="MultiLine" Height="224px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" Onclick="Save"/>
            <asp:HyperLink ID="hplClearAll" runat="server" NavigateUrl="~/contactus.aspx">Clear All</asp:HyperLink>
        </td>
    </tr>
</table>
        </div>
        </div>
    </div>
       

<script>
    var map;
    function initialize()
    {
        var latlng = new google.maps.LatLng(23.750783, 90.393425);
        var mapOptions =
            {
            center: latlng,
            zoom: 15,
            mapTypeId: google.maps.MapTypeId.ROADMAP
            }
        var map = new google.maps.Map(document.getElementById("map"), mapOptions);
    } 
    //var marker = new google.maps.Marker
    //    (
    //        {
    //            position: new google.maps.LatLng(23.750783, 90.393425),
    //            map: map,
    //            title: 'Click me'
    //        }
    //);
    //var infowindow = new google.maps.InfoWindow
    //    ({
    //            content: 'Location info: </br> Company: ElectroBuzz <br> LatLng: 23.750783, 90.393425'
    //    });
    //google.maps.event.addListener(marker, 'click', function () {
        
    //    infowindow.open(map, marker);
    //});
window.onload = initialize;
</script>
<script src="https://maps.googleapis.com/maps/api/js?key= AIzaSyDYAYk4ef5XqUfu9uDcwG7XnjovH9PAY-o &callback=myMap"></script>  
</asp:Content>

