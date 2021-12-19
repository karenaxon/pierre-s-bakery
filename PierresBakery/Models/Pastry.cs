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
      int price = quantity * 2;
      Price = price;

      if(quantity >= 3 && quantity <= 5)
      {
        Price -= 1;
      } else if(quantity == 6)
      {
        Price -= 2;
      }
    }
  }
}