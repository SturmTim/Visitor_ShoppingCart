namespace Visitor_ShoppingCart;

public abstract class Good
{
  public string Name { get; set; } = null!;
  public double PricePerUnit { get; set; }
  public int NrUnits { get; set; }
  public int Weight { get; set; }

  public override string ToString() => $"{Name}: {NrUnits} x {PricePerUnit:#.00} € (je {Weight}g)";

  public abstract void Accept(IVisitor visitor);

}
