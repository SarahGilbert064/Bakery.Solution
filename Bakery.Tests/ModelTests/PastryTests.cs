using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTest
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void CaluculatePrice_ReturnPastryPrice_Int()
    {
      Pastry newPastry = new Pastry();
      int finalAmount = newPastry.ReturnPastryPrice(2);
      Assert.AreEqual(1, finalAmount);
    }
  }
}