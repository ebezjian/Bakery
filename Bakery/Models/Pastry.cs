using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; set;}
    public int PastryQuantity { get; set;}

    public Pastry(int pastryPrice, int pastryQuantity)
    {
      PastryPrice = pastryPrice;
      PastryQuantity = pastryQuantity;
    }
  }
}