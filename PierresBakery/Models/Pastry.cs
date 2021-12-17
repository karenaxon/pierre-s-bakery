using System;
namespace PierresBakery.Models
{
  public class Pastry
  {
    public double Price { get; set; }
    public string Name { get; }
    public int Quantity { get; set; }

    public Pastry()
    {
      Name = "pastry";
      Quantity = 0;
      Price = 0;
    }

    public void CalcPrice(int quantity)
    {
      Quantity = quantity;
    }
  }
}