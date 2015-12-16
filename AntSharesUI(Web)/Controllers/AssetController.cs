using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using AntSharesUI_Web_.Models;

namespace AntSharesUI_Web_.Controllers
{
    public class AssetController : Controller
    {

        // GET: Asset/MyAsset
        public IActionResult MyAsset()
        {
            return View();
        }

        // GET: Asset/Transfer
        public IActionResult Transfer()
        {
            return View();
        }
    }
}
