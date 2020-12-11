using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesAnInstanceOfBread_Constructor()
    {
      int input = 5;      
      Bread newBread = new Bread(input);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  }
}