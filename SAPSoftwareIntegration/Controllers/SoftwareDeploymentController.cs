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
    public class SoftwareDeploymentController : Controller
    {

        public SoftwareDeploymentController()
        {
        }

        //
        // GET: /SoftwareDeployment/Index
        public ActionResult Index()
        {
            return View();
        }
    }
}