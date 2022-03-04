using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    Vendor testVendor;
    string testName = "Vendor Name";
    string testDescription = "Test description";
    List<Vendor> emptyVendorList = new List<Vendor>();

    [TestInitialize]
    public void Initialize()
    {
      testVendor = new Vendor(testName, testDescription);
    }

    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      Assert.AreEqual(testName, testVendor.Name);
    }

    [TestMethod]
    public void GetDescription_ReturnsVendorDescription_String()
    {
      Assert.AreEqual(testDescription, testVendor.Description);
    }

    [TestMethod]
    public void ClearVendors_RemovesAllVendorListObjects_True()
    {
      Vendor.ClearVendors();

      CollectionAssert.AreEqual(emptyVendorList, Vendor.GetVendors());
    }

    [TestMethod]
    public void GetVendors_ReturnsListOfAllVendorObjects_VendorList()
    {
      // Remove Vendors to start with empty list
      Vendor.ClearVendors();

      List<Vendor> testVendorList = new List<Vendor> {
        new Vendor("test1", "test2"),
        new Vendor("test3", "test4"),
        new Vendor("test5", "test6"),
      };

      CollectionAssert.AreEqual(testVendorList, Vendor.GetVendors());
    }

    [TestMethod]
    public void AddOrder_AddsOrderToListOfOrdersInVendor_True()
    {
      // public Order(string title, string description, int price, string date)
      Order testOrder = new Order("Title", "Descrip", 100, "6/7/2090");

      List<Order> testOrderList = new List<Order> {
        testOrder,
      };

      testVendor.AddOrder(testOrder);

      CollectionAssert.AreEqual(testOrderList, testVendor.Orders);
    }
  }
}
