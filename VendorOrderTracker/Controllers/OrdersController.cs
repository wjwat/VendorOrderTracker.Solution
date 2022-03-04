using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.FindVendor(vendorId);

      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Vendor vendor = Vendor.FindVendor(vendorId);
      Order order = vendor.Orders[orderId];

      Dictionary<string, object> model = new Dictionary<string, object> {
        { "vendor", vendor },
        { "order", order },
      };

      return View(model);
    }
  }
}
