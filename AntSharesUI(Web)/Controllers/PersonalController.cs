using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using AntSharesUI_Web_.Models;

namespace AntSharesUI_Web_.Controllers
{
    public class PersonalController : Controller
    {

        // GET: Personal/Cert
        public IActionResult Cert()
        {
            return View();
        }

        // GET: Personal/Protocol
        public IActionResult Protocol()
        {
            return View();
        }
    }
}
