using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW_DONG_HO
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                login.InnerHtml = $"<div class='login'> {Session["username"].ToString()} <a href ='DangXuat.aspx'>Đăng Xuất</a><div/>";

            }
                string times = DateTime.Now.ToString();
                title.InnerText = times;
            
        }

      
    }

}