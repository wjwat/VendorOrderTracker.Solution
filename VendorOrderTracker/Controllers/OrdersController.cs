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
        { "orderId", orderId },
      };

      return View(model);
    }

    // This is pretty similar to route above, how would I DRY this?
    [HttpGet("/vendors/{vendorId}/orders/{orderId}/edit")]
    public ActionResult Edit(int vendorId, int orderId)
    {
      Vendor vendor = Vendor.FindVendor(vendorId);
      Order order = vendor.Orders[orderId];

      Dictionary<string, object> model = new Dictionary<string, object> {
        { "vendor", vendor },
        { "order", order },
        { "orderId", orderId },
      };

      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders/{orderId}/edit")]
    public ActionResult Edit(int vendorId,
        int orderId,
        int id,
        string title,
        string description,
        int price,
        string date)
    {
      Order order = Vendor.FindVendor(vendorId).Orders[orderId];

      order.Title = title;
      order.Description = description;
      order.Price = price;
      order.Date = date;

      return RedirectToAction("Show", new { orderId, vendorId });
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}/delete")]
    public ActionResult Delete(int vendorId, int orderId)
    {
      Vendor vendor = Vendor.FindVendor(vendorId);
      Order order = vendor.Orders[orderId];

      vendor.Orders.RemoveAt(orderId);

      return RedirectToAction("Show", "Vendors", new { id = vendorId });
    }
  }
}
