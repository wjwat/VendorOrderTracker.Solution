using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; init; }
    public string Description { get; init; }
    public int Price { get; init; }
    public string Date { get; init; }

    public Order(string title, string description, int price, string date)
    {
      Title = "";
      Description = "";
      Price = 0;
      Date = "";
    }
  }
}
