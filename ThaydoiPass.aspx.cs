using BTL_LTW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW_DONG_HO
{
    public partial class ThaydoiPass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string usernameL = Request.Form.Get("nameS");
                string passwordL = Request.Form.Get("passWordS");
                string ConfirmpassWordS = Request.Form.Get("ConfirmpassWordS");
                bool check = true;

                int dem = 0;
                if (usernameL != "" && passwordL != "" && ConfirmpassWordS != "")
                {
                    List<NguoiDung> users = (List<NguoiDung>)Application["Users"];

                    foreach (NguoiDung user in users)
                    {
                        if (usernameL == user.email)
                        {
                            dem = 1;
                            if (passwordL == user.password)
                            {
                                user.password = ConfirmpassWordS;
                                check = true;
                            }
                            else
                            {
                                btn_error.InnerHtml = "Sai mật khẩu";
                                check = false;
                            }
                        }
                    }
                    if (check)
                    {
                        btn_error.InnerHtml = "Đăng ký thành công";
                        NguoiDung newUser = new NguoiDung(usernameL, ConfirmpassWordS, ConfirmpassWordS);
                        users.Add(newUser);
                        Application["Users"] = users;
                    }
                }
            }
        }
    }
}