﻿using BTL_LTW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW_DONG_HO
{
    public partial class TrangChiTiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString.Get("id");
            string sum = Request.QueryString.Get("amount");

            if (id != null)
            {
                List<Product> ProductList = (List<Product>)Application["productlist"];
                List<Product> Productinformation = new List<Product>();
                foreach (Product product in ProductList)
                {
                    if (id == product.Id)
                    {
                        Productinformation.Add(product);

                    }
                    ListViewProductinformation.DataSource = Productinformation;
                    ListViewProductinformation.DataBind();
                }

                if (Request.Cookies["cart"] == null)
                {
                    Response.Cookies["cart"].Value = $"{id},";
                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);
                }
                else
                {

                    //Store cookies by productID, example: 1,2,3,40,50,... 
                    Response.Cookies["cart"].Value = Request.Cookies["cart"].Value + $"{id},";
                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);
                }
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
            
            
        }

      /*  protected void AddToCartButton(object sender, EventArgs e)
        {

            
                string id = Request.QueryString.Get("id");
                //Store cart to cookies
                if (Request.Cookies["cart"] == null)
                {
                    Response.Cookies["cart"].Value = $"{id},";
                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);
                }
                else
                {

                    //Store cookies by productID, example: 1,2,3,40,50,... 
                    Response.Cookies["cart"].Value = Request.Cookies["cart"].Value + $"{id},";
                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);
                }

                //Refresh to update cart number
                //Response.Redirect(Request.Url.ToString());
            }*/
    
        
    }
}