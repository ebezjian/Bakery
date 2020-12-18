using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
      [TestMethod]
      public void BreadConstructor_CreatesInstanceOfBread_Bread()
      {
        Bread newBread = new Bread(5, 1);
        Assert.AreEqual(typeof(Bread), newBread.GetType());
      }

      [TestMethod]
      public void GetBreadPrice_ReturnsBreadPrice_Int()
      {
        int testBreadPrice = 5;
        Bread newBread = new Bread(testBreadPrice, 5);
        int results = newBread.BreadPrice;
        Assert.AreEqual(testBreadPrice, results);
      }

      [TestMethod]
      public void GetBreadQuantity_ReturnsBreadQuantity_Int()
      {
        int testBreadPrice = 1;
        int testBreadQuantity =1;
        Bread newBread = new Bread(testBreadPrice, testBreadQuantity);
        int confirmBreadQuantity = newBread.BreadQuantity;
        Assert.AreEqual(testBreadQuantity, confirmBreadQuantity);
      }

      [TestMethod]
      public void GetBreadTotal_ReturnsBreadTotalIncludingDiscount_Int()
      {
        int testBreadPrice = 5;
        int testBreadQuantity =3;
        int testBreadTotal = 10;
        Bread newBread = new Bread(testBreadPrice, testBreadQuantity);
        int confirmBreadTotal = newBread.OrderAmount();
        Assert.AreEqual(testBreadTotal, confirmBreadTotal);
      }

      [TestMethod]
      public void GetBreadTotal_ReturnsBreadtotalWithManyDiscounts_Int()
      {
        int testBreadPrice = 5;
        int testBreadQuantity = 15;
        int testBreadTotal = 50;
        Bread newBread = new Bread(testBreadPrice, testBreadQuantity);
        int confirmBreadTotal = newBread.OrderAmount();
        Assert.AreEqual(testBreadTotal, confirmBreadTotal);
      }

      [TestMethod]
      public void GetBreadtotal_ReturnsBreadTotalIfDiscountRequirementsNotMet_Int()
      {
        int testBreadPrice = 5;
        int testBreadQuantity = 5;
        int testBreadTotal = 20;
        Bread newBread = new Bread(testBreadPrice, testBreadQuantity);
        int confirmBreadTotal = newBread.OrderAmount();
        Assert.AreEqual(testBreadTotal, confirmBreadTotal);
      }
    }

  [TestClass]
    public class PastryTests
    {
      [TestMethod]
      public void PastryConstructor_CreatesInstancesOfPastry_Pastry()
      {
        Pastry newPastry = new Pastry (2, 1);
        Assert.AreEqual(typeof(Pastry), newPastry.GetType());
      }
    }

    
}
