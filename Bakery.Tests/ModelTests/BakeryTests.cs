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

      // [TestMethod]
      // public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
      // {
      //   Pastry newPastry = new Pastry(2);
      //   Assert.AreEqual(typeof(Pastry), newPastry.GetType());
      // }

      // [TestMethod]
      // public void GetPastryPrice_ReturnsPatryPrice_Int()
      // {
      //   int testPastryPrice = 2;
      //   Pastry newPastry = new Pastry(2);
      //   int results = newPastry.PastryPrice;
      //   Assert.AreEqual(testPastryPrice, results);
      // }
    }
}
