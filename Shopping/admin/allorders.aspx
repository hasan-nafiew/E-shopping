<%@ Page Title="" Language="C#" MasterPageFile="~/admin/home.Master" AutoEventWireup="true" CodeBehind="allorders.aspx.cs" Inherits="Shopping.admin.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <title>Order Information</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                   <div class="row">
                        <div class="col-lg-12">
                            <h1 class="page-header">Orders Information</h1>
                        </div>
                        <!-- /.col-lg-12 -->
                       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
                           <Columns>
                               <asp:TemplateField HeaderText="BillId">
                                   <EditItemTemplate>
                                       <asp:Label ID="Labelbillid" runat="server" Text='<%# Eval("billId") %>'></asp:Label>
                                   </EditItemTemplate>
                                   <ItemTemplate>
                                       <asp:Label ID="Label1" runat="server" Text='<%# Bind("billId") %>'></asp:Label>
                                   </ItemTemplate>
                               </asp:TemplateField>
                               <asp:BoundField DataField="orderId" HeaderText="Order Date" ReadOnly="True" />
                               <asp:BoundField DataField="customerName" HeaderText="Customer Name" ReadOnly="True" />
                               <asp:BoundField DataField="customerContact" HeaderText="Customer Contact" ReadOnly="True" />
                               <asp:BoundField DataField="customerMail" HeaderText="Customer Mail" ReadOnly="True" />
                               <asp:BoundField DataField="customerAddress" HeaderText="Customer Address" ReadOnly="True" />
                               <asp:BoundField DataField="billPrice" HeaderText="Bill Price" ReadOnly="True" />
                               <asp:BoundField DataField="deliveryStatus" HeaderText="Delivery Status" />
                               <asp:BoundField DataField="productsNquantity" HeaderText="Products/Quantity" ReadOnly="True" />
                               <asp:CommandField ShowEditButton="True" />
                           </Columns>
                        </asp:GridView>
                    </div>
</asp:Content>
