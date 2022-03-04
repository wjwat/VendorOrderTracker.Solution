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
  }
}
