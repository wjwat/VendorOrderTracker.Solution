using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Vendor> v = Vendor.GetVendors();
        return View(v);
      }

    }
}
