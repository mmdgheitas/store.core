using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using be;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace store.core.Controllers
{
    public class customer0 : Controller
    {
        private UserManager<user> usermanager;
        private SignInManager<user> signInmanager;

        public customer0(UserManager<user> usermanager, SignInManager<user> signInmanager)
        {
            this.usermanager = usermanager;
            this.signInmanager = signInmanager;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<string> create0(user h)
        {
            var resault = await usermanager.CreateAsync(h);
            if (resault.Succeeded)
            {
                await signInmanager.SignInAsync(h , true );
                return "ok";
            }
            else
            {
                return "failed";
            }
        }

        public async Task<IActionResult> login0(string username, string password)
        {
            var u = await usermanager.FindByNameAsync(username);
            if (u == null)
            {
                user h = null;
                return RedirectToAction("login", "cutomer", h);
            }
            else
            {
                user h = u;
                var r = await signInmanager.PasswordSignInAsync(h, password, true, false); ;
                return View();
            }
        }


    }
}
