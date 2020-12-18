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

    public int PastryOrder()
    {
      int pastryTotal = PastryPrice * PastryQuantity;
      if (pastryTotal % 3 == 0)
      {
        int pastryDiscount = PastryQuantity / 3;
        int discountPastryTotal = pastryTotal - pastryDiscount;
        return discountPastryTotal;
      }
      else if (PastryQuantity > 3 && pastryTotal % 3 !=0)
      {
        int instacesOfSale = PastryQuantity / 3;
        int bigDiscount = 1 *instacesOfSale;
        int discountPastryTotal = pastryTotal - bigDiscount;
        return discountPastryTotal;
      }
      else
      {
        return pastryTotal;
      }
    }
  }
}