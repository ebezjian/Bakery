using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadQuantity {get; set;}
    private int _breadPrice{get; set;} 

    public Bread (int breadQuantity, int breadPrice)
    {
      BreadQuantity = breadQuantity;
      
    }


  }

  // public class Pastry
  // {

  // }
}