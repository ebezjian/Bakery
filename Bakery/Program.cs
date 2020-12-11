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
      int bread = int.Parse(Console.ReadLine());
      Console.WriteLine("Excellent choice. Now how about pastries? Will you eat cake? We have a special for them as well, $2 each or 3 for $5.");
      Console.WriteLine("Please, I know it's such a great deal but contain your excitement. How many would you like?");
      int pastry = int.Parse(Console.ReadLine());

      Bread breadOrder = new Bread(bread);
      Pastry pastryOrder = new Pastry(pastry);

      Console.WriteLine($"Merveilleux! your order was for {bread} loaves of bread and {pastry} delectable pastries. Your total will be ${breadOrder.OrderAmount() + pastryOrder.OrderAmount()}.");
      Console.WriteLine("But you know mon petite ami, I've decided that you are a treat in ofteself so here, take it for free. Viva La Treats!");
    }
  }
}