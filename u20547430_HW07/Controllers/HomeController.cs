using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u20547430_HW07.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult AboutMe()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Index()  //INSIDE FileUpload
        {
            return View();
        }

        //Single File Upload
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase files) //INSIDE HOME
        {
            // Verify that the user selected a file
            // Not null and has a length

            if (files != null && files.ContentLength > 0)
            {
                // extract only the filename

                var fileName = Path.GetFileName(files.FileName);

                // store the file inside ~/App_Data/uploads folder

                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);

                // The chosen default path for saving

                files.SaveAs(path);
            }
            // redirect back to the index action to show the form once again

            return RedirectToAction("Index");
        }
    }
}
    }

}