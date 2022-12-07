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
            /*// lấy id
            string deleteId = Request.QueryString.Get("id");
            // lấy value cookie 

            string valueCookie = Request.Cookies["cart"].Value;
            if (valueCookie.Contains(deleteId)) ;
            {
                valueCookie = valueCookie.Replace(valueCookie, valueCookie.Remove(0, deleteId.Length));
                Request.Cookies["cart"].Value = valueCookie;
                Response.Redirect("cart.aspx");
            }*/
            string id = Request.QueryString.Get("id");
            string DeleteID = id + ",";
            string cartCookies = Request.Cookies["cart"].Value;
            int posCookies = cartCookies.IndexOf(DeleteID);
            string SetCookies = cartCookies.Remove(posCookies, DeleteID.Length);
            Response.Cookies["cart"].Value = SetCookies;
            Response.Cookies["cart"].Expires = DateTime.Now.AddDays(12);
            Response.Redirect("cart.aspx");
        }
    }
}