using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using be;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace store.core.Controllers
{

    public class customer : Controller
    {
        private UserManager<user> usermanager;
        private SignInManager<user> SignInManager;

        public customer(SignInManager<user> signInmanager, UserManager<user> usermanager)
        {
            this.SignInManager = signInmanager;
            this.usermanager = usermanager;
        }





        public IActionResult Index()
        {
            return View();
        }
        public IActionResult store()
        {
            bladmin bla = new bladmin();
            var q = bla.readall();
            return View(q);
        }
        public IActionResult login_singin()
        {
            return View();
        }
        public IActionResult welcom()
        {
            return View();
        }
        public IActionResult view(int id)
        {
            bladmin bla = new bladmin();
            var q = bla.read_by_id(id);
            return View(q);
        }
        public IActionResult cart()
        {
            

            return View();
        }
        public IActionResult addtocart(string Id)
        {
            var cart = JsonConvert.DeserializeObject<List<string>>(HttpContext.Session.GetString("cart")).ToList();
            cart.Add(Id);
            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
            return Json("ok");
        }
        public IActionResult profile()
        {
            ViewBag.h = null;
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.h = usermanager.FindByNameAsync(User.Identity.Name).Result;
            }
            else
            {
                return RedirectToAction("login_singin");
            }
            
            return View();
        }
        public IActionResult change(string id)
        {
            blhuman blh = new blhuman();
            user h = blh.find_by_id(id);
            return View(h);
        }
        [HttpPost]


        //[HttpPost]
        //public string update(user h)
        //{
        //    blhuman blh = new blhuman();
        //    string r = blh.update(h);
        //    return r;
        //}
       





        [HttpPost]
        public async Task<IActionResult> login0(string username, string PasswordHash)
        {
            if (ModelState.IsValid)
            {
                var u = await usermanager.FindByNameAsync(username);
                user h = null;
                if (u == null)
                {
                    return Json("یافت نشد");
                }
                h = u;
                var rr = await SignInManager.UserManager.FindByNameAsync(h.UserName);
                var rrr = await SignInManager.UserManager.CheckPasswordAsync(h, h.pass);
                var r = await SignInManager.PasswordSignInAsync(userName: h.NormalizedUserName, password: PasswordHash, true, false);

                if (!r.Succeeded)
                    //if (!SignInManager.SignInAsync(h, true).IsCompletedSuccessfully)
                    return RedirectToAction("login_singin", h);
                else
                {
                    return RedirectToAction("profile");
                }
            }

            return RedirectToAction("login_singin");

        }

        public async Task<IActionResult> logout()
        {
            user h = usermanager.FindByNameAsync(User.Identity.Name).Result;
            await SignInManager.SignOutAsync();
            return RedirectToAction("index");
        }

        public async Task<IActionResult> create0(user h)
        {
            var resault = await usermanager.CreateAsync(h, h.pass);
            if (resault.Succeeded)
            {
                if (SignInManager.SignInAsync(h, true).IsCompletedSuccessfully)
                {
                    return RedirectToAction("welcom");
                }
                ModelState.AddModelError("","مشکلی رخ داده است");
                return RedirectToAction("login_signin");
            }
            else
            {
                ModelState.AddModelError("", "مشکلی رخ داده است");
                return RedirectToAction("login_signin");
            }
        }


    }
}



//public string create(user h)
//{
//    blhuman blh = new blhuman();
//    string r = blh.create(h);
//    return r;
//}



//public IActionResult login(string username, string PasswordHash)
//{
//    blhuman blh = new blhuman();
//    var h = blh.login(username, PasswordHash);
//    if (h != null)
//    {

//        return View("profile", h);
//    }
//    else
//    {
//        ModelState.AddModelError("", "نام کاربری یا رمز عبور اشتباه است");
//        return View("login_singin");
//    }
//}