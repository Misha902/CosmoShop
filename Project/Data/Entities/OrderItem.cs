namespace CosmoShop.Data.Entities
{
  public class OrderItem
  {
    public int Id { get; set; }
    public SpaceObject Product { get; set; }
    public int Quantity { get; set; }
    public ulong UnitPrice { get; set; }
    public Order Order { get; set; }
  }
}