<%@ Page Title="Đăng nhập" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="BTL_LTW_DONG_HO.DangNhap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Asset/css/acount.css" rel="stylesheet" />
    <link href="Asset/css/DongHoNam.css" rel="stylesheet" />
     <!--product item-->
        <div class="product-link">
               <label style="font-weight: bold; font-size: 1.5rem; margin-left: 20px">Sản phẩm bán chạy</label>
            <div class="product-box">
            <asp:ListView ID="DongHoNam1" runat="server">
                <ItemTemplate>
                        <div class="product-box-item">
                            <a href="TrangChiTiet.aspx? id = <%# Eval("Id")%> ">
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
    <!-- Đăng nhập-->
    <form action="DangNhap.aspx" runat="server" method="post">
        <div class="from-login">
            <div class="register">
                <i class="fa-sharp fa-solid fa-close fa-closeLogin "></i>
                <h3>LOGIN</h3>
                <div class="control">
                    <input type="text" placeholder="Use name" id="userName" name="nameL">
                </div>

                <div class="control">
                    <input type="password" placeholder="Password" id="passWord" name="passwordL">
                </div>
                <div runat="server" id="stringErr" style="color: red;"></div>
                <div class="sccess">
                    <button type="submit" runat="server" class="btnCheckLogin">Login</button>
                </div>
            </div>
        </div>
    </form>
    <script src="Asset/js/DangNhap.js"></script>
</asp:Content>
