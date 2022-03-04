using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    Order testOrder;

    [TestInitialize]
    public void Initialize()
    {
      testOrder = new Order();
    }

    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
  }
}
