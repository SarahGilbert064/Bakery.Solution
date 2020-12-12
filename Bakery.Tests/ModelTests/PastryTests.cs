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
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnPastryPrice_Int()
    {
      Pastry newPastry = new Pastry(2);
      int finalAmount = newPastry.ReturnPastryPrice(1);
      Assert.AreEqual(2, finalAmount);
    }

    [TestMethod]
    public void FinalPrice_CalculateFinalAmount_Int()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(4, newPastry.FinalPrice(2));
    }
  }
}