using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u20547430_HW07.Controllers.NewFolder1
{
    public class FileController : Controller
    {
        //Example: A client (browser) sends an HTTP request to the server;
        //then the server returns a response to the client. The response
        //contains status information about the request and may also
        //contain the requested content.

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
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            return View();
        }

        // GET: Files/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Files/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Files/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Files/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Files/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Files/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Files/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
