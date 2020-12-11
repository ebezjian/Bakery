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
      if (BreadQuantity % 3 == 0 || (BreadQuantity > 3 && BreadQuantity % 3 > 0)){
        int cost = (BreadQuantity - (BreadQuantity/3)) * 5;
        return cost;
      }
      else
      {
        return BreadQuantity * 5;
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
      if (PastryQuantity % 3 == 0)
      {
        int cost = (PastryQuantity/3) * 5;
        return cost;
      }
      else if (PastryQuantity% 3 > 0 && PastryQuantity > 3)
      {
        int cost = ((PastryQuantity/3) * 5) + ((PastryQuantity % 3) * 2);
        return cost;
      }
      else
      {
        return PastryQuantity * 2;
      }
    }
  }
}