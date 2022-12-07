using BTL_LTW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW_DONG_HO
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<Product> ProductList = (List<Product>)Application["Productlist"];
            List<Product> donghonam = new List<Product>();

            foreach (Product product in ProductList)
            {
                string id = product.Id;
                    donghonam.Add(product);
            }
        }
    }
}