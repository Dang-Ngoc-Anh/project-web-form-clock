<%@ Page Title="Trang chi tiết sản phẩm" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="TrangChiTiet.aspx.cs" Inherits="BTL_LTW_DONG_HO.TrangChiTiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="./Asset/css/TrangConChiTiet.min.css" rel="stylesheet" />
    <div class="content-detail" >
        <ListView ID="ListViewProductinformation" runat="server">
            <ItemTemplate>
                <div class="content-left">
                    <div class="item-img">
                        <img src="<%# Eval("Images") %>"  alt="Load ảnh thất bại"/>
                    </div>
                </div>
                <div class="content-right">
                    <!-- header-->
                    <div class="header">
                        <%# Eval("Name") %>
                    </div>
                    <!-- giá-->
                    <div class="price">
                        <%# Eval("Price") %>
                    </div>
                    <!-- description-->
                    <div class="category">
                        <p>
                            <%# Eval("Detail") %>
                        </p>
                    </div>
                    <!-- So luong-->
                    <div class="numbers">
                        <span>Số lượng</span>
                        <div class="box-number">
                            <button class="addCart">
                                <i class="fa-solid fa-plus"></i>
                            </button>
                            <input type="text" value="1"  class="amount" name="amount"/>
                            <button  class="remove-cart">
                                <i class="fa-solid fa-minus"></i>
                            </button>
                        </div>
                    </div>
                    <div class="add-cart">
                        <form runat="server" method="post">
                              <button id="Btn1" class="btn-add-cart" runat="server" onserverclick="Btn1_ServerClick" >Thêm vào giỏ hàng</button>
                        </form>
                        <button class="btn-by" >Mua ngay</button>
                    </div>
                </div>
            </ItemTemplate>
        </ListView>
           <p  id="themgiohang" runat="server" style="color: red" ></p>
 
    </div>
    <div class="pay">
        <div class="des">
            <label>Thanh toán : </label>
        </div>
    </div>
    <script src="./Asset/js/jquery-3.4.1.js"></script>
    <script src="./Asset/js/cart.js"></script>
</asp:Content>


