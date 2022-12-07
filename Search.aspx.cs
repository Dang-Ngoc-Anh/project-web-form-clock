using BTL_LTW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW_DONG_HO
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string valueSearch = Request.QueryString["valueSearch"];
            if (string.IsNullOrEmpty(valueSearch))
                valueSearch = "";
            valueSearch = valueSearch.Trim();
            head__text.InnerText = $"Kết quả tìm kiếm :{valueSearch}";

            List<Product> DongHo = (List<Product>)Application["Productlist"];

            string html = "";
            DongHo = DongHo.FindAll(x => x.Name.ToLower().Contains(valueSearch.ToLower()));
            DongHo.ForEach(item =>
            {
                html += $@"
                        <div class='product-box-item'>
                            <a href='TrangChiTiet.aspx?id={item.Id}'>
                                <div class='product-img'>
                                    <img src='{item.Images}' />
                                </div>
                                <div class='product-des'>
                                    <div class='title'>{item.Name}</div>
                                    <div class='price'>
                                        {item.Price}$ <i class='fa-solid fa-cart-shopping'></i>
                                    </div>
                                </div>
                       </a>
         </div>";
            });
            if (html == "")
                html = "Không Tìm Thấy Tên Sản Phẩm";
            list__search.InnerHtml = html;
        }
    }
}