<%@ Page Title="Trang chi tiết sản phẩm" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="TrangChiTiet.aspx.cs" Inherits="BTL_LTW_DONG_HO.TrangChiTiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Asset/css/TrangConChiTiet.min.css" rel="stylesheet" />
    <div class="content-detail">
        <div class="content-left">
            <div class="item-img">
                <img src="Asset/img/1.png" />
            </div>
        </div>
        <div class="content-right">
            <!-- header-->
            <div class="header">
                Đồng Hồ Nam
            </div>

            <!-- giá-->
            <div class="price">
                2000000$
            </div>

            <!-- description-->
            <div class="category">
                <p>
               sahcfbsalfgvjklsadbvjksabvjkaslbfvajsklfvba;
                asfv sahfsajlfajnxc vbhkabvjusadbv
                asdnfvbaslifvbh sadhkfvbaihsfb ajfvadifvb hb
                asdfjvbsadhkvfsadlhgfvady
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
    </div>
</asp:Content>


