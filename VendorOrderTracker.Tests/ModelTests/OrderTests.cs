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
    string testTitle = "An order";
    string testDescription = "My first order";
    int testPrice = 100;
    string testDate = "6/7/2022";

    [TestInitialize]
    public void Initialize()
    {
      testOrder = new Order(testTitle, testDescription, testPrice, testDate);
    }

    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      Assert.AreEqual(testTitle, testOrder.Title);
    }

    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      Assert.AreEqual(testTitle, testOrder.Description);
    }
  }
}
