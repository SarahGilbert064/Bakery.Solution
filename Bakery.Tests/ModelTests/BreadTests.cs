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
      Bread newLoaf = new Bread(5);
      Assert.AreEqual(typeof(Bread), newLoaf.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnBreadPrice_Int()
    {
      Bread newLoaf = new Bread(5);
      int finalAmount = newLoaf.FinalPrice(1);
      Assert.AreEqual(5, finalAmount);
    }

    [TestMethod]
    public void FinalPrice_CalculateFinalAmount_Int()
    {
      Bread newLoaf = new Bread(5);
      Assert.AreEqual(5, newLoaf.FinalPrice(5));
    }

    [TestMethod]
    public void DiscountPrice_CalculateBreadDiscount_Int()
    {
      Bread newLoaf = new Bread(5);
      Assert.AreEqual(10, newLoaf.DiscountPrice(3));
    }
  }
}