﻿using BTL_LTW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW_DONG_HO
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (IsPostBack)
            {
                string usernameL = Request.Form.Get("nameL");
                string passwordL = Request.Form.Get("passwordL");
                int dem = 0;
                if (usernameL != "" && passwordL != "")
                {
                    List<NguoiDung> users = (List<NguoiDung>)Application["Users"];

                    foreach (NguoiDung user in users)
                    {
                        if (usernameL == user.email)
                        {  
                            dem = 1;
                            if (passwordL == user.password)
                            {
                                Session["username"] = usernameL;
                                Response.Redirect("Home.aspx");
                                break;
                            }
                            else
                            {
                                stringErr.InnerHtml = "Sai mật khẩu";
                                break;
                            }
                        }
                    }
                    if (dem == 0)
                    {
                        stringErr.InnerHtml = "Không tồn tại tài khoản ";
                    }
                }
            }
        }
    }
}