namespace Visitor_ShoppingCart;

public class KalorienVisitor : IVisitor
{
    private int Calories { get; set; }
    
    public void VisitFood(Food food)
    {
        Calories += food.Calories;
    }

    public void VisitBeverage(Beverage beverage)
    {
        Calories += beverage.Calories;
    }

    public void VisitCosmetic(Cosmetic cosmetic)
    {
    }

    public string ResultString
    {
        get {return $"{Calories} calories"; }
    }
    public IVisitor Reset()
    {
        Calories = 0;
        return this;
    }
}