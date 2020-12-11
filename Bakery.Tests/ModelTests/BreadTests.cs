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
      Bread newLoaf = new Bread();
      Assert.AreEqual(typeof(Bread), newLoaf.GetType());
    }

    [TestMethod]
    public void CalculatePrice_ReturnPrice_Int()
    {
      Bread newLoaf = new Bread();
      int finalAmount = newLoaf.ReturnPrice(5);
      Assert.AreEqual(5, finalAmount);
    }
  }
}