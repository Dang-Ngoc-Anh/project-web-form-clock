<%@ Page Title="Trang chi tiết sản phẩm" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="TrangChiTiet.aspx.cs" Inherits="BTL_LTW_DONG_HO.TrangChiTiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Asset/css/TrangConChiTiet.min.css" rel="stylesheet" />
    <div class="content-detail" >
        <asp:ListView ID="ListViewProductinformation" runat="server">
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
                        <%# Eval("Price") %>$
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
                            <button>
                                <i class="fa-solid fa-plus"></i>
                            </button>
                            <input type="text" value="1" />
                            <button>
                                <i class="fa-solid fa-minus"></i>
                            </button>
                        </div>
                    </div>
                    <div class="add-cart">
                        <button class="btn-add-cart">Thêm vào giỏ hàng</button>
                        <button class="btn-by">Mua ngay</button>
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>

</asp:Content>


