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
        Bread newBread = new Bread(5);
        Assert.AreEqual(typeof(Bread), newBread.GetType());
      }

      [TestMethod]
      public void GetBreadPrice_ReturnsBreadPrice_Int()
      {
        int testBreadPrice = 3;
        Bread newBread = new Bread(4);
        int results = newBread.BreadPrice;
        Assert.AreEqual(testBreadPrice, results);
      }

    }
}
