using BTL_LTW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW_DONG_HO
{
    public partial class DangKy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

             
            if (IsPostBack)
            {
                string email = Request.Form.Get("nameS");
                string password = Request.Form.Get("passWordS");
                string ConfirmpassWordS = Request.Form.Get("ConfirmpassWordS");
                List<NguoiDung> users = (List<NguoiDung>)Application["Users"];
                bool check = true;
                if (email != "" && password != "" && ConfirmpassWordS != "" )
                {
                    foreach (NguoiDung user in users)
                    {
                        if (email == user.email)
                        {
                            btn_error.InnerHtml = "Tài khoản đã được sử dụng";
                            check = false;
                        }
                        else if(password != ConfirmpassWordS)
                        {
                            btn_error.InnerHtml = "Nhap sai mat khau";
                            check = false;
                        }
                    }

                    if (check )
                    {
                        btn_error.InnerHtml = "Đăng ký thành công";
                        NguoiDung newUser = new NguoiDung(email, password, ConfirmpassWordS);
                        users.Add(newUser);
                        Application["Users"] = users;
                    }
                }
            }
        }
    }
}