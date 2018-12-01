<%@ Page Title="" Language="C#" MasterPageFile="~/admin/home.Master" AutoEventWireup="true" CodeBehind="allproducts.aspx.cs" Inherits="Shopping.admin.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Products</h1>
        </div>
        <div class="col-lg-12 col-sm-12">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="3" GridLines="Vertical" OnPageIndexChanging="GridView1_PageIndexChanging1" OnRowEditing="GridView1_RowEditing" PageSize="5" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label ID="lblId" runat="server" Text='<%# Eval("ProductId") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Product Image">
                        <EditItemTemplate>
                            <asp:Image ID="ImageEdit" runat="server" ImageUrl='<%# Eval("ProductImagePath") %>' />
                            <asp:FileUpload ID="FileUploadImage" onchange="readURL(this);" runat="server" />
                            <img id="blah" src="#" style="padding-top: 5px; padding-bottom: 5px;" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="ImageShow" runat="server" ImageUrl='<%# Eval("ProductImagePath") %>' />
                        </ItemTemplate>
                        <ControlStyle Height="120px" Width="100px" />
                        <ItemStyle Height="150px" Width="100px" />
                    </asp:TemplateField>
                    <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                    <asp:BoundField DataField="ProductQuantity" HeaderText="Product Quantity" />
                    <asp:BoundField DataField="ProductPrice" HeaderText="Unit Price" />
                    <asp:TemplateField HeaderText="Product Details">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBoxDetails" runat="server" Text='<%# Bind("ProductDetails") %>' TextMode="MultiLine" Rows="10" Width="442px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("ProductDetails") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
        </div>
    </div>
    <script>
        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();

                reader.onload = function (e) {
                    $('#blah')
                        .attr('src', e.target.result)
                        .width(100)
                        .height(140);
                };
                reader.readAsDataURL(input.files[0]);
            }
        }
    </script>

</asp:Content>
