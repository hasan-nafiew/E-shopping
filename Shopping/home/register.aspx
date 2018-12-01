<%@ Page Title="" Language="C#" MasterPageFile="~/home/home.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Shopping.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 320px;
            height: 188px;
        }
        .auto-style2 {
            width: 132px;
            height: 27px;
        }
        .auto-style3 {
            height: 27px;
            width: 223px;
        }
        .auto-style4 {
            width: 132px
        }
        .auto-style5 {
            width: 223px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="login-center">
        <fieldset>
            <legend>User Registration</legend>
             <div class="row">
                
                 <div>

                     <table align="center" class="auto-style1">
                         <tr>
                             <td class="auto-style4"><asp:Label ID="lblUserFullName" runat="server" Text="Name"></asp:Label></td>
                             <td class="auto-style5"> <asp:TextBox ID="txtUserFullName" runat="server" placeholder="Enter Full Name"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserFullName" ErrorMessage="Please Enter Name" ForeColor="#990000"></asp:RequiredFieldValidator>
                             </td>
                         </tr>
                       
                         <tr>
                             <td class="auto-style2"><asp:Label ID="lblGender" runat="server" Text="Select Gender"></asp:Label></td>
                             <td><asp:RadioButtonList ID="rbtnGender" runat="server" RepeatDirection="Horizontal" Width="214px">
                                 <asp:ListItem>Male</asp:ListItem>
                                 <asp:ListItem>Female</asp:ListItem>
                                </asp:RadioButtonList> 
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please Select a Gender" ControlToValidate="rbtnGender" ForeColor="#990000"></asp:RequiredFieldValidator>
                             </td>                               
                         </tr>
                         <tr>
                             <td class="auto-style4"><asp:Label ID="lblUserEmail" runat="server" Text="Email"></asp:Label></td>
                             <td class="auto-style5"><asp:TextBox ID="txtUserEmail" runat="server" placeholder="example@mail.com" TextMode="Email"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtUserEmail" ErrorMessage="Your Email is Mandatory" ForeColor="#990000"></asp:RequiredFieldValidator>
                                 <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtUserEmail" ErrorMessage="Please Enter Valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="#990000"></asp:RegularExpressionValidator>
                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style4"><asp:Label ID="lblUserContactNo" runat="server" Text="Contact No" ></asp:Label></td>
                             <td class="auto-style5"><asp:TextBox ID="txtUserContactNo" runat="server" placeholder="Contact Number" MinLength="11" MaxLength="11"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUserContactNo" ErrorMessage="You Must Enter Your Mobile Number" ForeColor="#990000"></asp:RequiredFieldValidator>
                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style2"><asp:Label ID="lblUserAddress" runat="server" Text="Address"></asp:Label></td>
                             <td class="auto-style3"><asp:TextBox ID="txtUserAddress" placeholder="Street Address" runat="server"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtUserAddress" ErrorMessage="You have enter your Address" ForeColor="#990000"></asp:RequiredFieldValidator>
                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style2"><asp:Label ID="lblCity" runat="server" Text="City"></asp:Label></td>
                             <td class="auto-style3"><asp:TextBox ID="txtUserCity" placeholder="Enter City" runat="server"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtUserCity" ErrorMessage="Please Enter Your City" ForeColor="#990000"></asp:RequiredFieldValidator>
                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style4"><asp:Label ID="lblUserPassword" runat="server" Text="Password"></asp:Label></td>
                             <td class="auto-style5"><asp:TextBox ID="txtUserPassword" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtUserPassword" ErrorMessage="You Cannot keep Password as Blank" ForeColor="#990000"></asp:RequiredFieldValidator>
                                 <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Password Should be more than 8 Digits and Less than 20 Digits" ControlToValidate="txtUserPassword" ValidationExpression="^.{8,20}$" ForeColor="#990000"></asp:RegularExpressionValidator>
                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style2"><asp:Label ID="lblUserConfirmPassword" runat="server" Text="Confirm Password"></asp:Label></td>
                             <td class="auto-style3"><asp:TextBox ID="txtUserConfirmPassword" placeholder=" Confirm Password" runat="server" TextMode="Password"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtUserConfirmPassword" ErrorMessage="Please Re-Enter your Password Here" ForeColor="#990000"></asp:RequiredFieldValidator>
                                 <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtUserPassword" ControlToValidate="txtUserConfirmPassword" ErrorMessage="Please Enter Same Password" ForeColor="#990000"></asp:CompareValidator>
                             </td>
                         </tr>
                         <tr>
                             
                             <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
                         </tr>
                         <tr>
                             
                             <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                 <asp:HyperLink ID="hplClearAll" runat="server" NavigateUrl="~/register.aspx">Clear All</asp:HyperLink>
                             </td>
                         </tr>
                         </table>

                 </div>
            
        </div>
        </fieldset>
       
    </div>

</asp:Content>
