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
            
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeOf(Bread), newBread.GetType());
    }
  }
}