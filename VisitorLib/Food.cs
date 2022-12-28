namespace Visitor_ShoppingCart;

public class Food : Good
{
  public int Calories { get; set; }
  public override void Accept(IVisitor visitor) => visitor.VisitFood(this);
  }
