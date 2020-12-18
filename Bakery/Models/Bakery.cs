using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadQuantity {get; set;}
    public int BreadPrice { get; set;}

    public Bread(int quantity, int breadPrice)
    {   
      BreadQuantity = quantity;
      BreadPrice = breadPrice;
    }

    public int OrderAmount()
    {
      int breadTotal = BreadPrice * BreadQuantity;
      if (breadTotal % 3 == 0)
      {
        int breadDeal = breadTotal /3;
        int discountedTotalBread = breadTotal - breadDeal;
        return discountedTotalBread;
      }
      else if (BreadQuantity > 3 && breadTotal % 3 !=0)
      {
        int instDeal = BreadQuantity /3;
        int bigDeal = 5 * instDeal;
        int discountedTotalBread = breadTotal - bigDeal;
        return discountedTotalBread;
      }
      else
      {
          return breadTotal;
      }
    }
  }
}