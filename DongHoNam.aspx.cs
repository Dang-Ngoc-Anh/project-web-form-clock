using BTL_LTW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW_DONG_HO
{
    public partial class DongHoNam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> ProductList = (List<Product>)Application["ProductList"];
            List<Product> donghonam = new List<Product>();

            foreach(Product product in ProductList)
            {
                string id = product.Id;
                if(id == "1" || id == "2" || id == "3" || id == "4" || id == "5" || id == "6" || id == "7")
                {
                    donghonam.Add(product);
                }
            }

            DongHoNam1.DataSource = donghonam;
            DongHoNam1.DataBind();
        }
    }
}