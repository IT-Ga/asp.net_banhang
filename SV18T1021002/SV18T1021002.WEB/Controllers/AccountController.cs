using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SV18T1021002.WEB.Controllers
{
    [Authorize]
    
    public class AccountController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]

        /// </summary>
        ///  Xử lý yêu cầu đăng nhập
        /// <summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>

        public ActionResult Login(string username,string password)
        {
            if(username == "admin@abc.com" && password == "1")
            {
                //Ghi lại cookies phiên đăng nhập
                System.Web.Security.FormsAuthentication.SetAuthCookie(username, false);
                //Quay về trang chủ
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Username = username;
            ViewBag.Message = "Đăng nhập thất bại";
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Login");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ChangePassword()
        {
            return View();
        }
    }
}