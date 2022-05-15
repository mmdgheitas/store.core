using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using be;
using System.Threading.Tasks;
using System.IO;
namespace store.core.Controllers
{
    public class admin : Controller
    {
        private IWebHostEnvironment iwe;
        public admin(IWebHostEnvironment _iwe)
        {
            iwe = _iwe;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult addingPage()
        {
            return View();
        }
        public IActionResult add(Models.Items item)
        {
            BLL.bladmin bla = new BLL.bladmin();
            this.upload(item.img_src);
            Items i = new Items();
            i.id = item.id;
            i.id_user = item.id_user;
            i.name = item.name;
            i.pris = item.pris;
            i.size = item.size;
            i.code_mahsoul = item.code_mahsoul;
            i.color = item.color;
            i.exist = item.exist;
            i.detail = item.detail;
            i.img_src = item.img_src.FileName;
            var r = bla.add(i);
            return Json(r);
        }

        public bool upload(IFormFile file)
        {
            if (file == null)
                return false;
            var path = iwe.WebRootPath + "\\images\\items\\" + file.FileName;
            var f = System.IO.File.Create(path);
            file.CopyTo(f);
            return true;
        }
    }
}
