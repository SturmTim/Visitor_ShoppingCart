namespace Visitor_ShoppingCart;

public class HTMLVisitor : IVisitor
{
    private string HTML { get; set; }
    
    public void VisitFood(Food food)
    {
        HTML += $"<tr><td>{food.Name}</td><td>{food.PricePerUnit}€</td><td>{food.Weight}g</td><td>{food.Calories} kcal</td></tr>\n";
    }

    public void VisitBeverage(Beverage beverage)
    {
        HTML += $"<tr><td>{beverage.Name}</td><td>{beverage.PricePerUnit}€</td><td>{beverage.Weight}g</td><td>{beverage.Alcohol:0.0}% Alc.</td></tr>\n";
    }

    public void VisitCosmetic(Cosmetic cosmetic)
    {
        HTML += $"<tr><td>{cosmetic.Name}</td><td>{cosmetic.PricePerUnit}€</td><td>{cosmetic.Weight}g</td><td>&nbsp;</td></tr>\n";
    }

    public string ResultString
    {
        get
        {
            return "<table>\n" +
                   "<tr><th>Produkt</th><th>Preis</th><th>Gewicht</th><th>Info</th></tr>" +
                   $"\n{HTML}" +
                   "</table>";
        }
    }

    public IVisitor Reset()
    {
        HTML = "";
        return this;
    }
}