using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using AntSharesUI_Web_.Models;

namespace AntSharesUI_Web_.Controllers
{
    public class WalletController : Controller
    {
        // GET: Wallet/MyWallet
        public IActionResult MyWallet()
        {
            ViewBag.Addresses = new string[] { "AbcdXweW6trsVwcBSUYrK69u4cBhDg4ZJF", "Abcdm9wpAgyYr3KHvKweGov5U3VJLmtB8W", "ANttyFkVZxGh93TmjgkiFe1TgS3csGfhJD" };
            return View();
        }

        // GET: Wallet/Open
        public IActionResult Open()
        {
            return View();
        }

        // GET: Wallet/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Wallet/ChangePassword
        public IActionResult ChangePassword()
        {
            return View();
        }

        // GET: Wallet/Address?id=1
        public IActionResult Address(int id)
        {
            return View();
        }
    }
}
