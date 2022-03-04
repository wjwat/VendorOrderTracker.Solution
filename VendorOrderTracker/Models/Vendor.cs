using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; init; }
    public string Description { get; init; }
    public List<Order> Orders { get; init; }
    private static List<Vendor> _vendors = new List<Vendor>();

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order>();
      _vendors.Add(this);
    }

    public static void ClearVendors()
    {
      _vendors.Clear();
    }

    public static Vendor FindVendor(int id)
    {
      return _vendors[id];
    }

    public static List<Vendor> GetVendors()
    {
      return _vendors;
    }

    public void AddOrder(Order newOrder)
    {
      Orders.Add(newOrder);
    }
  }
}
