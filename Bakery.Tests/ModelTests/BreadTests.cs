using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newLoaf = new Bread(0);
      Assert.AreEqual(typeof(Bread), newLoaf.GetType());
    }

    [TestMethod]
    public void CalculatePrice_ReturnBreadPrice_Int()
    {
      Bread newLoaf = new Bread(0);
      int finalAmount = newLoaf.ReturnBreadPrice(5);
      Assert.AreEqual(5, finalAmount);
    }
  }
}