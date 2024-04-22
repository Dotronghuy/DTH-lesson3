using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson3._5.Controllers
{
    public class thanhvienController : Controller
    {
        // GET: thanhvien
        public ActionResult Details(Member member)
        {
            return View(member);
        }
    }
}