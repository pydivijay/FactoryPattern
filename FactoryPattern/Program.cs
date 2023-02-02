// See https://aka.ms/new-console-template for more information


Product productA = Factory.GetProductType("A");
productA.ProductType();

Product productB = Factory.GetProductType("B");
productB.ProductType();
abstract class Product
{
   public abstract void ProductType();
}
class ProductA : Product
{
    public override void ProductType()
    {
        Console.WriteLine("product A");
    }
}

class ProductB : Product
{
    public override void ProductType()
    {
        Console.WriteLine("product B");
    }
}

class Factory
{
    public static Product GetProductType(string productType)
    {
        if(productType == "A")
        {
           return new ProductA();
        }
        else if(productType == "B")
        {
          return  new ProductB();
        }
        else
        {
            return null;
        }
    }
}
