using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ExportToXml.Utilities;
using System.Text;
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
            var encoding = new ASCIIEncoding();
            var testFile = GenerateXML.GetXML();
            var file = File(encoding.GetBytes(testFile), "text/plain", "ExportToXml.xml");
            return file;
        }

    }
}
