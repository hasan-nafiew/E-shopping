<%@ Page Title="" Language="C#" MasterPageFile="~/home/home.Master" AutoEventWireup="true" CodeBehind="aboutus.aspx.cs" Inherits="Shopping.About_Us" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>About Us</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCoursel" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <style>
        .title {
  color: darkgoldenrod;
  font-size: 20px;
}
    </style>
    <div class="span12">
        <h2>
            <asp:Label ID="LabelProductTitle" runat="server" Text="About Us"></asp:Label>
        </h2>
        <hr class="soft" />
        <p align="justify" style="font-size: 16px;">
            ElectroBuzz is an online electronic shopping portal developed by a Team currently enrolled in DOTNET 9th batch 2017.
    In this website you will be able to browse and purchase the latest technological products at the most competitive price possible. 
    Our products span extends all electronic categories such as Mobile Phones, Cameras, Laptops, etc., which we personally acquire from 100% genuine dealers. 
    We strongly believe in customer satisfaction, that is why we provide a one-month brand replacement warranty* to assure that your hard earned money is never wasted. 
    Your strong support will help us create a strong relationship with you and help us provide you with more better products and after-sales services. 
        </p>
        <p>*T&C Applicable</p>
        <hr class="soft" />
        <h3><strong>Meet the Team</strong></h3>


        <div class="row">
            <div class="span3">
                <div class="well">
                    <img src="App_Resource_Image/Team/Shifath.jpg" alt="Shifath" style="width: 230px; height: 230px;" />
                    <div class="container">
                        <h2>Shifath Shams</h2>
                        <p class="title">Team Leader</p>
                        <p>Contact No: +8801715-457717</p>
                        <a href="https://www.facebook.com/cyberdude4ever">
                            Facebook</a>&nbsp;&nbsp;
                                <a href="https://www.linkedin.com/in/shifath-shams-44751065/">
                                    Linkedin</a>&nbsp;&nbsp;
                                <a href="mailto:shifath.shams@gmail.com">
                                    Gmail</a><br />
                        <br />
                        <a href="mailto:shifath.shams@gmail.com"></a>
                    </div>
                </div>
            </div>
            <div class="span3">
                <div class="well">
                    <img src="App_Resource_Image/Team/Seam.jpg" alt="Seam" style="width: 230px; height: 230px;">
                    <div class="container">
                        <h2>Hasan Seam</h2>
                        <p class="title">Top Contributor<br />(Full Stack Developer .Net)</p>
                        <p>Contact No: +8801741-330270</p>
                        <a href="https://www.facebook.com/hasan.seam">Facebook</a>
                            <a href="https://www.linkedin.com/in/hasanseam37">Linkedin</a>
                                <a href="mailto:hasanseam37@gmail.com">Gmail</a>
                        <a href="App_Resource_Image/Team/Hasanur Jaman Seamcvforjr.pdf" download> CV </a>
                        <br />
                    </div>
                </div>
                </div>
                <div class="span3">
                    <div class="well">
                        <img src="App_Resource_Image/Team/Faruk.jpg" alt="Faruk" style="width: 230px; height: 230px;">
                        <div class="container">
                            <h2>Omar Faruk</h2>
                            <p class="title">Database Administrator</p>
                            <p>Contact No: +8801837-362245</p>
                            <a href="https://www.facebook.com/faruk.jewel.31">
                                Facebook</a>&nbsp;&nbsp;
                                <a href="https://www.linkedin.com/in/omar-faruk-jewel-3a034196">
                                    Linkedin</a>&nbsp;&nbsp;
                                <a href="mailto:farukcse18@gmail.com">
                                    Gmail</a><br />
                            <br />
                            <a href="mailto:farukcse18@gmail.com"></a>
                        </div>
                    </div>
                </div>
            </div>

            <%--<style>
table,
th, td {
    padding: 25px;
}
</style>
        <style>
html {
  box-sizing: border-box;
}

*, *:before, *:after {
  box-sizing: inherit;
}

.column {
  float: left;
  width: 250px;
  margin-bottom: 16px;
  padding: 0 8px;
}

@media (max-width: 650px) {
  .column {
    width: 250px;
    display: block;
  }
}

.card {
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
}

.container {
  padding: 0 16px;
}

.container::after, .row::after {
  content: "";
  clear: both;
  display: table;
}

.title {
  color: darkgoldenrod;
  font-size: 20px;
}

.button {
  border: none;
  outline: 0;
  display: inline-block;
  padding: 8px;
  color: white;
  background-color: #000;
  text-align: center;
  cursor: pointer;
  width: 200px;
  align-self:center
}

.button:hover {
  background-color: #555;
}
</style>--%>
        </div>
</asp:Content>
