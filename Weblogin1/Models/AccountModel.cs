using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weblogin1.Models
{
    public class AccountModel : IAccountModel
    {
        public Login CheckLogin(string userName, string passWord)
        {
            using (var db = new LoginEntities2())
            {
                return db.Logins.Where(x => x.userName == userName && x.passWord == passWord).FirstOrDefault();
            }
        }

    }
}