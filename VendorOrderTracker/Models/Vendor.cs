using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; init; }
    public string Description { get; init; }
    public List<Order> Orders { get; }
    private static List<Vendor> _vendors = new List<Vendor>();

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
    }
  }
}
