namespace Visitor_ShoppingCart;

public class WaggeVisitor : IVisitor
{
    private int Weight { get; set; }
    
    public void VisitFood(Food food)
    {
        Weight += food.Weight * food.NrUnits;
    }

    public void VisitBeverage(Beverage beverage)
    {
        Weight += beverage.Weight * beverage.NrUnits;
    }

    public void VisitCosmetic(Cosmetic cosmetic)
    {
        Weight += cosmetic.Weight * cosmetic.NrUnits;
    }

    public string ResultString
    {
        get { return $"Total weight: {Weight/1000.00} kg"; }
    }
    public IVisitor Reset()
    {
        Weight = 0;
        return this;
    }
}