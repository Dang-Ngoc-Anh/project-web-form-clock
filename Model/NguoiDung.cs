using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_LTW
{
    public class NguoiDung
    {
        public string email;
        public string password;
        public string repassword;

        public NguoiDung(string email, string password, string repassword)
        {

            this.email = email;
            this.password = password;
            this.repassword = repassword;
        }


    }
}