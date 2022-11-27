<%@ Page Title="Thanh toán" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="BTL_LTW_DONG_HO.cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Asset/css/carts.css" rel="stylesheet" />

    <div class="contain-cart" style="z-index: 10;">
        <h1>Shopping Cart</h1>

        <div class="shopping-cart">

            <div class="column-labels">
                <label class="products-image">Image</label>
                <label class="products-details">products</label>
                <label class="products-price">Price</label>
                <label class="products-quantity">Quantity</label>
                <label class="products-removal">Remove</label>
                <label class="products-line-price">Total</label>
            </div>


            <asp:ListView ID="ListViewCart" runat="server">
                <ItemTemplate>
                    <div class="products">
                        <div class="products-image">
                            <img src="<%# Eval("Images") %>">
                        </div>
                        <div class="products-details">
                            <div class="products-title"><%# Eval("Name") %></div>
                            <p class="products-description"><%# Eval("Detail") %></p>
                        </div>
                        <div class="products-price"><%# Eval("Price") %></div>
                        <div class="products-quantity">
                            <input type="number" value="1" min="1">
                        </div>
                        <div class="products-removal">
                            <a href="XoaCart.aspx" runat="server">
                                <button class="remove-products">
                                    Remove
                                </button>
                            </a>

                        </div>
                        <div class="products-line-price">0</div>
                    </div>
                </ItemTemplate>
            </asp:ListView>


            <div class="totals">
                <div class="totals-item">
                    <label>Subtotal</label>
                    <div class="totals-value" id="cart-subtotal"></div>
                </div>
                <div class="totals-item">
                    <label>Tax (5%)</label>
                    <div class="totals-value" id="cart-tax">3.60</div>
                </div>
                <div class="totals-item">
                    <label>Shipping</label>
                    <div class="totals-value" id="cart-shipping">15.00</div>
                </div>
                <div class="totals-item totals-item-total">
                    <label>Grand Total</label>
                    <div class="totals-value" id="cart-total">90.57</div>
                </div>
            </div>

            <button class="checkout">Checkout</button>

        </div>
    </div>
    <script src="Asset/js/jquery-3.4.1.js"></script>
    <script src="Asset/js/bymony.js"></script>
</asp:Content>
