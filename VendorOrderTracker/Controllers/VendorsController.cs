using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendors = Vendor.GetVendors();

      return View(vendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);

      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}/")]
    public ActionResult Show(int id)
    {
      Vendor vendor = Vendor.FindVendor(id);

      return View(vendor);
    }

    [HttpPost("/vendors/{id}/items")]
    public ActionResult Create(int id, string title, string description, int price, string date)
    {
      Vendor vendor = Vendor.FindVendor(id);
      Order newOrder = new Order(title, description, price, date);
      vendor.AddOrder(newOrder);

      return View("Show", vendor);
    }
  }
}
