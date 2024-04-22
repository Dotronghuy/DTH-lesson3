using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson3._5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Member member)
        {
            if (ModelState.IsValid)
            {
                // Redirect to details page passing member data
                return RedirectToAction("Details", "Member", member);
            }
            return View("Index", member);
        }
    }
}