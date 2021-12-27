using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weblogin1.Models;
using Weblogin1.ViewModel;

namespace Weblogin1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        IAccountModel _accountModel;
        public IAccountModel accountModel { get { return _accountModel ?? (_accountModel = new AccountModel()); } private set { } }
        public ActionResult Index()
        {
            LoginViewModel md = new LoginViewModel();
            return View(md);
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var res = accountModel.CheckLogin(obj.userName, obj.passWord);

                if (res != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Error", "Tài khoản hoặc mật khẩu không đúng");
                }

            }
            return View("Index");
        }
    }
}