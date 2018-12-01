<%@ Page Title="" Language="C#" MasterPageFile="~/admin/home.Master" AutoEventWireup="true" CodeBehind="addproduct.aspx.cs" Inherits="Shopping.admin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
                        <div class="col-lg-12">
                            <h1 class="page-header">Add Product</h1>
                        </div>
                                                <div class="panel-body">
                            <div class="row">
                                <div class="col-lg-6">
                                    <div role="form">
                                        <div class="form-group">
                                            <label>Product Name</label>
                                            <asp:TextBox ID="TextBoxProductName" class="form-control" runat="server" Width="200px"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Product Price</label>
                                               <asp:TextBox ID="TextBoxProductPrice" class="form-control" runat="server" TextMode="Number" Width="201px"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Product Quantity</label>
                                            <asp:TextBox ID="TextBoxProductQuantity" class="form-control" runat="server" TextMode="Number" Width="199px"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Product Category</label>
                                            <asp:DropDownList ID="DropDownListCategory" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="form-group">
                                            <label>Product Details</label>
                                            <asp:TextBox ID="TextBoxProductDetails" class="form-control" runat="server" Rows="10" TextMode="MultiLine" Width="200px"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Product Image</label>
                                            <asp:FileUpload ID="FileUploadProductImage" onchange="readURL(this);" runat="server" />
                                            <img id="blah" src="#"  style="padding-top:5px;padding-bottom:5px;" />
                                        </div>
                                        <asp:Button ID="ButtonSubmit" class="btn btn-default" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
                                        <asp:Button ID="ButtonReset" CssClass="btn btn-default" runat="server" Text="Reset" OnClick="ButtonReset_Click" />
                                    </div>
                                </div>
                                <!-- /.col-lg-6 (nested) -->
                            </div>
                            <!-- /.row (nested) -->
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
