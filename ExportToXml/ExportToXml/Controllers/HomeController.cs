using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ExportToXml.Utilities;
namespace ExportToXml.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public virtual FileResult DownloadXmlFile()
        {
            var testFile = GenerateXML.GetXML();
            var utf8Bytes = testFile.ToUTF8Bytes();
            var file = File(utf8Bytes, "text/plain", "ExportToXml.xml");
            return file;
        }

    }
}
