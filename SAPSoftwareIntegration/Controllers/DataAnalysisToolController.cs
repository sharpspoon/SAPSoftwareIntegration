using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using SAPSoftwareIntegration.Models;

namespace SAPSoftwareIntegration.Controllers
{
    [Authorize]
    public class DataAnalysisToolController : Controller
    {

        public DataAnalysisToolController()
        {
        }

        //
        // GET: /DataAnalysisTool/Index
        public ActionResult Index()
        {
            return View();
        }
    }
}