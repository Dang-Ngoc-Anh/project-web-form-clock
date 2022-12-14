<%@ Page Title="Home" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Home.aspx.cs" Inherits="BTL_LTW_DONG_HO.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- bananer-->
    <div class="bananer">
        <div class="bananer-img">
            <img class="imgs" src="/Asset/img/bananer1.jpg" />
        </div>
        <div class="bananer-img">
            <img class="imgs" src="/Asset/img/bananer2.jpg" />
        </div>
    </div>

    <!--Wrap per contain*@ -->

    <div class="contain-wrapper" id="contain1">
        <div class="flex-box">
            <div class="product">
                <a href="">
                    <div class="wrap-img">
                        <img src="/Asset/img/2.png" />
                    </div>
                    <div class="wrap-text">
                        Đồng hồ nam
                    </div>
                </a>
            </div>
        </div>
    </div>


    <!--product item-->
    <div class="product-link">
        <label style="font-weight: bold; font-size: 1.5rem; margin-left: 20px">Sản phẩm bán chạy</label>
        <div class="product-box">
                     <div class="product-box-item">
                <a href="">
                    <div class="product-img">
                        <img src="" />
                    </div>
                </a>
                <a href="">
                    <div class="product-des">
                        <div class="title"></div>
                        <button class="price" >
                            $ <i class="fa-solid fa-cart-shopping"></i>
                        </button>
                    </div>
                </a>
            </div>
        </div>
    </div>
    <script src="./Asset/js/homeIndex.js"></script>
</asp:Content>
