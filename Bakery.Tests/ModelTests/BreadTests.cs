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
      int finalAmount = newLoaf.ReturnBreadPrice(1);
      Assert.AreEqual(5, finalAmount);
    }

    [TestMethod]
    public void FinalPrice_CalculateFinalAmount_Int()
    {
      Bread newLoaf = new Bread(5);
      Assert.AreEqual(25, newLoaf.FinalPrice(5));
    }
  }
}