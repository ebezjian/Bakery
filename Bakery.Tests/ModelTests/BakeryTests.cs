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
      [TestMethod]
      public void GetPastryPrice_ReturnsPastryPrice_Int()
      {
        int testPastryPrice = 2;
        Pastry newPastry = new Pastry(testPastryPrice, 1);
        int confirmPastryPrice = newPastry.PastryPrice;
        Assert.AreEqual(testPastryPrice, confirmPastryPrice);
      }
      [TestMethod]
      public void GetPastryQuantity_ReturnsPastryQuantity_Int()
      {
        int testPastryPrice =2;
        int testPastryQuantity =1;
        Pastry newPastry = new Pastry(testPastryPrice, testPastryQuantity);
        int confirmPastryQuantity = newPastry.PastryQuantity;
        Assert.AreEqual(testPastryQuantity, confirmPastryQuantity);
      }

      [TestMethod]
      public void GetPastryTotal_ReturnsPastryTotalAndDiscount_Int()
      {
        int testPastryPrice = 2;
        int testPastryQuantity = 3;
        int testPastryTotal = 5;
        Pastry newPastry = new Pastry(testPastryPrice, testPastryQuantity);
        int confirmPastryPrice = newPastry.PastryOrder();
        Assert.AreEqual(testPastryTotal, confirmPastryPrice);
      }

      [TestMethod]
      public void GetPastryTotalPrice_ReturnsPastryTotalWithMultipleInstancesOfDiscount_Int()
      {
        int testPastryPrice = 2;
        int testPastryQuantity = 5;
        int testPastryTotal = 9;
        Pastry newPastry = new Pastry(testPastryPrice, testPastryQuantity);
        int confirmPastryPrice = newPastry.PastryOrder();
        Assert.AreEqual(testPastryTotal, confirmPastryPrice);
      }
    }

    
}
