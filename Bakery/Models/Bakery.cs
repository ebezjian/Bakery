using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadQuantity {get; set;}
    public Bread(int quantity)
    {   
      BreadQuantity = quantity;
    }

    public int OrderAmount()
    {
      if (order % 3 == 0 || (order > 3 && order % 3 > 0)){
        int cost = (order - (order/3)) * 5;
        return cost;
      }
      else
      {
        return order * 5;
      }
    }
  }

  
  public class Pastry
  {
    public int PastryPrice {get;}
    public Pastry(int pastryPrice)
    {
      PastryPrice = pastryPrice;
    }
  }  
}