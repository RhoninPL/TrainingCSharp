using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPage.Models;

namespace MyPage.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    [RoutePrefix("Content")]
    public class ContentController : Controller
    {
        // GET: Admin/Content
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContentModels model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // todo update
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id)
        {

            return View();
        }

        [HttpPost]
        [Route("edit/{id}")]
        public ActionResult Edit(ContentModels model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // todo update
            return RedirectToAction("Index");
        }
    }
}