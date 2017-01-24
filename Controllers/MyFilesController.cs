using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab02.Controllers
{
    public class MyFilesController : Controller
    {
        // GET: MyFiles
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/TextFiles"));
            return View(files);
        }

        // GET: MyFiles
        public ActionResult MyContent(string id)
        {
            string filename = id + ".txt";
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/TextFiles")).Where(ff => Path.GetFileName(ff) == filename).ToArray();
         
            
            return View(filePaths);
        }
    }
}