using BTL_LTW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW_DONG_HO
{
    public partial class DongHoNu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<Product> ListProduct = (List<Product>)Application["productlist"];
            List<Product> donghonu = new List<Product>();

            foreach (Product product in ListProduct)
            {
                string id = product.Id;
                if (id == "7" || id == "8" || id == "9" || id == "10" || id == "11" || id == "12" || id == "13")
                {
                    donghonu.Add(product);
                }
            }

            DongHoNu1.DataSource = donghonu;
            DongHoNu1.DataBind();
        }
    }
}