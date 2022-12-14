<%@ Page Title="Đồng hồ nữ" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="DongHoNu.aspx.cs" Inherits="BTL_LTW_DONG_HO.DongHoNu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="./Asset/css/DongHoNam.css" rel="stylesheet" />
     <!--product item-->
        <div class="product-link">
               <label style="font-weight: bold; font-size: 1.5rem; margin-left: 20px">Sản phẩm bán chạy</label>
            <div class="product-box">
            <asp:ListView ID="DongHoNu1" runat="server">
                <ItemTemplate>
                        <div class="product-box-item">
                            <a href="TrangChiTiet.aspx?id=<%#Eval("Id")%> ">
                                <div class="product-img">
                                    <img src="<%# Eval("Images") %>" />
                                </div>
                                <div class="product-des">
                                    <div class="title"><%# Eval("Name") %></div>
                                    <div class="price">
                                        <%# Eval("Price") %>$ <i class="fa-solid fa-cart-shopping"></i>
                                    </div>
                                </div>
                            </a>
                        </div>
                </ItemTemplate>
            </asp:ListView>
              </div>
        </div>

</asp:Content>