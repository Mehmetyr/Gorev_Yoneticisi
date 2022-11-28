using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plans.API.Models
{
    public class UserConstants
    {
        public static List<UserModel> users = new List<UserModel>()
        {
            new UserModel(){ UserName = "Mehmet_Admin", EmailAddress="mhmtyru@gmail.com",Password="1234",GivenName="Mehmet",Surname="Yoru",Role="Admin"},
            new UserModel(){ UserName = "Yusuf_Kullanici", EmailAddress="Yusuf@gmail.com",Password="1234",GivenName="Yusuf",Surname="Yoru",Role="Kullanici"}

        };
    }
}
