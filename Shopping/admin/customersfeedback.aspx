<%@ Page Title="" Language="C#" MasterPageFile="~/admin/home.Master" AutoEventWireup="true" CodeBehind="customersfeedback.aspx.cs" Inherits="Shopping.admin.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
                        <div class="col-lg-12">
                            <h1 class="page-header"> Feedback</h1>
                        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
                        <!-- /.col-lg-12 -->
                    </div>
</asp:Content>
