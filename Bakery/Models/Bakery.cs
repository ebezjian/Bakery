using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadQuantity {get; set;}
    public int BreadPrice{get; set;} = 5;

    public Bread (int breadQuantity)
    {
      BreadQuantity = breadQuantity;
      
    }
    public int BreadCost()
    {
    int breadCost = BreadPrice * BreadQuantity;
    return breadCost;
    }

  }

  // public class Pastry
  // {

  // }
}