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
    public void GetPastryPrice_ReturnPastryPrice_Int()
    {
      Pastry newPastry = new Pastry(2);
      int finalAmount = newPastry.GetPastryPrice(1);
      Assert.AreEqual(2, finalAmount);
    }

    [TestMethod]
    public void FinalPrice_CalculateFinalAmount_Int()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(2, newPastry.GetPastryPrice(2));
    }

    [TestMethod]
    public void DiscountPrice_CalculatePastryDiscount_Int()
    {
      Pastry newPasty = new Pastry(2);
      Assert.AreEqual(5, newPasty.DiscountPrice(3));
    }
  }
}