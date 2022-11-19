<%@ Page Language="C#" Title="Đăng ký" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="DangKy.aspx.cs" Inherits="BTL_LTW_DONG_HO.DangKy" %>

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
    <form action="DangKy.aspx" method="post" runat="server">
        <div class="from-signUp">
            <div class="register ">
                <i class="fa-sharp fa-solid fa-close  fa-closeSignUp"></i>
                <h3>SIGN UP</h3>
                <div class="control">
                    <input type="email" placeholder="Use name" id="useName" name="nameS">
                    <small></small>
                </div>

                <div class="control">
                    <input type="password" placeholder="Password" id="passWord" name="passWordS">
                    <small></small>
                </div>
                <div class="control">
                    <input type="password" placeholder="Confirm password" id="ConfirmpassWord" name="ConfirmpassWordS">
                    <small></small>
                </div>
                <p runat="server" id="btn_error" style="color: red"></p>
                <div class="sccess">
                    <button type="submit" class="btnSignUp">SIGN UP</button>
                </div>
            </div>
        </div>
    </form>
    <script src="Asset/js/DangKy.js"></script>
</asp:Content>


