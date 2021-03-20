using System;
using System.Collections.Generic;
using DesignPatterns02.Classes;


namespace DesignPatterns02.ConcretSales
{
    class DebitSale : Sale
    {
        public List<Product> products = new List<Product>();
        double Discount = 0.15;
        double total = 0.0;

        public override void addDiscount(double percent)
        {
        }

        public override void addProduct(Product product)
        {
            products.Add(product);
        }

        public override double getPrice()
        {
            foreach (var p in products)
            {
                total += p.Price;

                Console.WriteLine($" Produto: {p.Name}");
                Console.WriteLine($" Preço: {p.Price}\n");
            }

            Console.WriteLine(" Método de pagamento: Débito \n Desconto recebido: 15% \n");
            Console.WriteLine($" Total: {total}");
            Console.WriteLine($" Desconto: {total * Discount}");

            return total - (total * Discount);
        }
    }
}
