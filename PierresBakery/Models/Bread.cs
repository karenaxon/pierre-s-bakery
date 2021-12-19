namespace PierresBakery.Models
{
  public class Bread
  {
    public double Price { get; set; }
    public string Name { get; }
    public int Quantity { get; set; }

    public Bread()
    {
      Name = "bread";
      Quantity = 0;
      Price = 0;
    }

    public void CalcPrice(int quantity)
    {
      Quantity = quantity;
      int price = quantity * 5;
      Price = price;

      if(quantity % 3 == 0)
      {
        Price -= 5;
      }
    }
  }
}