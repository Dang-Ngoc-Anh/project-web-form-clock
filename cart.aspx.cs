using BTL_LTW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW_DONG_HO
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Cookies["cart"] != null)
            {
                String id = Request.QueryString.Get("id");
                List<Product> cartList = new List<Product>();
                List<Product> productList = (List<Product>)Application["ProductList"];
                string[] productsID = Request.Cookies["cart"].Value.Split(',');

                // hien product
                foreach (string productID in productsID)
                {
                    foreach (Product product in productList)
                    {
                        if (product.Id == productID)
                        {
                            cartList.Add(product);

                        }
                    }
                }
                ListViewCart.DataSource = cartList;
                ListViewCart.DataBind();

                //Display products price toan bo san pham
            }

        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            string id = Request.QueryString.Get("id");
            string valueCokie = Request.Cookies["cart"].Value;
            if(valueCokie.Contains(id + ","))
            {
                valueCokie = valueCokie.Replace(valueCokie, valueCokie.Remove(valueCokie.IndexOf(id + ",", id.Length)));
            }
            Request.Cookies["cart"].Value = valueCokie;
        }
    }
}