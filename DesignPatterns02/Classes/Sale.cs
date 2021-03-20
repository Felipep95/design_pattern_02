namespace DesignPatterns02.Classes
{
    public abstract class Sale
    {
        public abstract void addDiscount(double percents);
        public abstract void addProduct(Product product);
        public abstract double getPrice();
    }
}
