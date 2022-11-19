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

                List<Product> ProductList = (List<Product>)Application["ProductList"];
                List<Product> donghonam = new List<Product>();

                foreach (Product product in ProductList)
                {
                    string id = product.Id;
                    if (id == "1" || id == "2" || id == "3" || id == "4" || id == "5" || id == "6" || id == "7")
                    {
                        donghonam.Add(product);
                    }
                }

                DongHoNam1.DataSource = donghonam;
                DongHoNam1.DataBind();
                if (IsPostBack)
            {
                string email = Request.Form.Get("nameS");
                string password = Request.Form.Get("passWordS");
                string ConfirmpassWordS = Request.Form.Get("ConfirmpassWordS");
                List<NguoiDung> users = (List<NguoiDung>)Application["Users"];
                bool check = true;
                if (email != "" && password != "" && ConfirmpassWordS != "")
                {
                    foreach (NguoiDung user in users)
                    {
                        if (email == user.email)
                        {
                            btn_error.InnerHtml = "Tài khoản đã được sử dụng";
                            check = false;
                        }
                    }

                    if (check)
                    {
                        btn_error.InnerHtml = "Đăng ký thành công";
                        NguoiDung newUser = new NguoiDung(email, password, ConfirmpassWordS);
                        users.Add(newUser);
                        Application["Users"] = users;
                        Response.Redirect("DangNhap.aspx");
                    }
                }
            }
        }
    }
}