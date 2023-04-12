<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ThaydoiPass.aspx.cs" Inherits="BTL_LTW_DONG_HO.ThaydoiPass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form action="ThaydoiPass.aspx" method="post" runat="server"  id="f2" class="form">
        <div class="from-signUp">
            <div class="register ">
                <i class="fa-sharp fa-solid fa-close  fa-closeSignUp"></i>
                <h3>Thay Đổi Mật Khẩu</h3>
                <div class="control">
                    <input type="email" placeholder="Use name" class="useName" name="nameS">
                    <small></small>
                </div>

                <div class="control">
                    <input type="password" placeholder="Password Cũ" class="passWord" name="passWordS">
                    <small></small>
                </div>
                <div class="control">
                    <input type="password" placeholder="Passworld Mới" class="ConfirmpassWord" name="ConfirmpassWordS">
                    <small></small>
                </div>
                <p runat="server" id="btn_error" style="color: red"></p>
                <div class="sccess">
                    <button class="btnSignUp" runat="server" >SIGN UP</button>
                </div>
            </div>
        </div>
    </form>
    <script src="Asset/js/DangKy.js"></script>
</asp:Content>
