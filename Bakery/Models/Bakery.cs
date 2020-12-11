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
    public int PastryQuantity {get; set;}
    public Pastry(int quantity)
    {   
      PastryQuantity = quantity;
    }

    public int OrderAmount()
    {
      if (order % 3 == 0)
      {
        int cost = (quantity/3) * 5;
        return cost;
      }
      else if (quantity % 3 > 0 && quantity > 3)
      {
        int cost = ((quantity/3) * 5) + ((quantity % 3) * 2);
        return cost;
      }
      else
      {
        return quantity * 2;
      }
    }
  }
}