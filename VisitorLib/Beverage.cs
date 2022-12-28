namespace Visitor_ShoppingCart;

public class Beverage : Good
{
  public int Calories { get; set; }
  public double Alcohol { get; set; }
  public override void Accept(IVisitor visitor) => visitor.VisitBeverage(this);
}
