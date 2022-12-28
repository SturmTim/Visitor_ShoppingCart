namespace Visitor_ShoppingCart;

public class AlkoholVisitor : IVisitor
{
    private double Alc { get; set; }
    private int amount = 0;
    
    public void VisitFood(Food food)
    {
        
    }

    public void VisitBeverage(Beverage beverage)
    {
        Alc += beverage.Alcohol;
        amount++;;
    }

    public void VisitCosmetic(Cosmetic cosmetic)
    {
        
    }

    public string ResultString
    {
        get { return $"Durchschn. Alkoholgehalt: {Alc / amount}%"; }
    }
    public IVisitor Reset()
    {
        Alc = 0;
        amount = 0;
        return this;
    }
}