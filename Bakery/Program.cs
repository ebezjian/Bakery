using System;
using System.Collections.Generic;
using Bakery.Models;

namespace PierreBakery.Models
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Bonjour mon petite ami, welcome to Pierre's Bakery! Today we have fresh bread and pastries!");
      Console.WriteLine("We have a special on loaves of bread today. They are $5 each, but buy two and get one for free!");
      Console.WriteLine(" I know, I am so generous. How many would you like?");
      string uBreadQuantity = Console.ReadLine();
      int BreadQuantity = int.Parse(uBreadQuantity);
      Console.WriteLine("Excellent choice. Now how about pastries? Will you eat cake? We have a special for them as well, $2 each or 3 for $5.");
      Console.WriteLine("Please, I know it's such a great deal but contain your excitement. How many would you like?");
      string uPastryQuantity = Console.ReadLine();
      int PastryQuantity = int.Parse(uPastryQuantity);
      Bread uBread = new Bread(5, BreadQuantity);
      Pastry uPastry = new Pastry (2, PastryQuantity);
      int BreadTotal = uBread.OrderAmount();
      int PastryTotal = uPastry.PastryOrder();
      int FinalTotal = BreadTotal + PastryTotal;
      Console.WriteLine($"Merveilleux! your order was for {uBreadQuantity} loaves of bread and {uPastryQuantity} delectable pastries. Your total will be ${FinalTotal}.");
      Console.WriteLine("But you know mon petite ami, I've decided that you are a treat in ofteself so here, take it for free. Viva La Treats!");
    }
  }
}