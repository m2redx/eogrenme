using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UYGULAMA.Controllers
{
    public class OgretmenController : Controller
    {
       [Authorize (Roles ="admin")]

        public ActionResult Index()
        {
            return View();
        }
    }
}