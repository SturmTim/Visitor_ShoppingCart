namespace Visitor_ShoppingCart;

public interface IVisitor
{
  void VisitFood(Food food);
  void VisitBeverage(Beverage beverage);
  void VisitCosmetic(Cosmetic cosmetic);
  string ResultString { get; }
  IVisitor Reset();
}

