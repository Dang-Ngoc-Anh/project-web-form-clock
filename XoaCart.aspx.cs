using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW_DONG_HO
{
    public partial class XoaCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.Cookies["cart"] != null)
            {
                Response.Cookies["cart"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("cart.aspx");
            }
        }
    }
}