using System;
namespace PierresBakery.Models
{
  public class Pastry
  {
    public double Price { get; set; }
    public string Name { get; set; }

    public Pastry(string name)
    {
      Name = name;
      Price = 2.00;
    }
  }
}