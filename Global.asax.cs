using BTL_LTW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL_LTW_DONG_HO
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

            //tk mac dinh
            Application["Users"] = new List<NguoiDung>();
            List<NguoiDung> Users = (List<NguoiDung>)Application["Users"];
            Users.Add(new NguoiDung("anhcu2101@gmail.com", "anhcu", "anhcu"));

            //sanpham
            Application["ProductList"] = new List<Product>();
            List<Product> ProductList = new List<Product>();
            //Dong Ho Nam
            ProductList.Add(new Product() { Id = "1", Images = "../Asset/img/1.png", Name = "Đồng hồ Orient ", Price = "500", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            ProductList.Add(new Product() { Id = "2", Images = "../Asset/img/2.png", Name = "Đồng hồ bently ", Price = "600", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            ProductList.Add(new Product() { Id = "3", Images = "../Asset/img/3.png", Name = "Đồng hồ ogivar", Price = "400", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            ProductList.Add(new Product() { Id = "4", Images = "../Asset/img/4.png", Name = "Đồng hồ italy", Price = "700", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            ProductList.Add(new Product() { Id = "5", Images = "../Asset/img/5.png", Name = "Đồng hồ hụy Sĩ", Price = "500", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            ProductList.Add(new Product() { Id = "6", Images = "../Asset/img/6.png", Name = "Đồng hồ Thụy Điện", Price = "700", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            ProductList.Add(new Product() { Id = "7", Images = "../Asset/img/7.png", Name = "Đồng hồ nam Black", Price = "800", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            
            
           /* //san pham pho bien
            ProductList.Add(new Product() { Id = "4", Images = "../Asset/img/4.png", Name = "Đồng hồ nam Mathey", Price = "600000", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            ProductList.Add(new Product() { Id = "5", Images = "../Asset/img/5.png", Name = "Đồng hồ nam Mathey", Price = "600000", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            ProductList.Add(new Product() { Id = "6", Images = "../Asset/img/6.png", Name = "Đồng hồ nam Mathey", Price = "600000", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            */
            //sanpham dong ho nu
            ProductList.Add(new Product() { Id = "8", Images = "../Asset/img/8.png", Name = "Đồng hồ Philippe", Price = "600", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            ProductList.Add(new Product() { Id = "9", Images = "../Asset/img/9.png", Name = "Đồng hồ Mini Focus", Price = "850", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            ProductList.Add(new Product() { Id = "10", Images = "../Asset/img/10.png", Name = "Đồng hồ Nữ Italy", Price = "650", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            ProductList.Add(new Product() { Id = "11", Images = "../Asset/img/11.png", Name = "Đồng hồ FreeLock", Price = "750", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            ProductList.Add(new Product() { Id = "12", Images = "../Asset/img/12.png", Name = "Đồng hồ Focus", Price = "650", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });
            ProductList.Add(new Product() { Id = "13", Images = "../Asset/img/13.png", Name = "Đồng hồ Mini", Price = "850", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." });


            Application["ProductList"] = ProductList;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["login"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}