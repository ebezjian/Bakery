using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesAnInstanceOfBread_Constructor()
    {
            
      Bread newBread = new Bread(5, 1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadPrice_GetsPriceOfBread_Int()
    {      
      int testBreadPrice = 5;
      int testBreadQuantity = 1;
      Bread newBread = new Bread(testBreadPrice, testBreadQuantity);
      int confirmBreadPrice = newBread.testBreadPrice;
      Assert.AreEqual(testBreadQuantity, confirmBreadPrice);
  }
  }
}
