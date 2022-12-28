namespace Visitor_ShoppingCart;

public class KasseVisitor : IVisitor
{
    private double Price { get; set; }
    
    public void VisitFood(Food food)
    {
        Price += food.PricePerUnit * food.NrUnits;
    }

    public void VisitBeverage(Beverage beverage)
    {
        Price += beverage.PricePerUnit * beverage.NrUnits;
    }

    public void VisitCosmetic(Cosmetic cosmetic)
    {
        Price += cosmetic.PricePerUnit * cosmetic.NrUnits;
    }

    public string ResultString
    {
        get {return $"Total price: {Price}"; }
    }
    public IVisitor Reset()
    {
        Price = 0;
        return this;
    }
}