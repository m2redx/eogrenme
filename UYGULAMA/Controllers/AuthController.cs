using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UYGULAMA.Models;
using UYGULAMA.View_Model;

namespace UYGULAMA.Controllers
{
    public class AuthController : Controller
    {
        // GET: Home
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(AuthIndex form)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
              

                var user = Database.Session.Query<Dersler>().FirstOrDefault(k => k.DersId == form.userId);
                
                             
                        return RedirectToAction("Index","Ogrenci");
                
               
               
            } 
        }
    }
}