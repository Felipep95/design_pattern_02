using DesignPatterns02.Classes;
using DesignPatterns02.ConcretCreatorSales;
using DesignPatterns02.CreatorSaleDiscount;
using System;
using System.Collections.Generic;


namespace DesignPatterns02
{
    class Program
    {
        static void Main(string[] args)
        {
            SaleCreator[] sales = new SaleCreator[3];

            sales[0] = new InCashSaleCreator();
            sales[1] = new DebitSaleCreator();
            sales[2] = new ParceledOutSaleCreator();

            List<Product> products = new List<Product>();

            products.Add(new Product(1, "Notebook", 3000));
            products.Add(new Product(2, "Iphone", 4000));
            products.Add(new Product(3, "PS5", 5000));

            var SaleInCash = sales[0].CreateSale();
            var SaleDebit = sales[1].CreateSale();
            var SaleParceledOut = sales[2].CreateSale();

            foreach (var p in products)
            {
                SaleInCash.addProduct(p);
                SaleDebit.addProduct(p);
                SaleParceledOut.addProduct(p);
            }

            Console.WriteLine(" 1 - Dinheiro \n 2 - Débito \n 3 - Parcelado \n");
            Console.WriteLine(" Informe o médoto de pagamento: \n");

            int paymentMethod = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (paymentMethod)
            {
                case 1:
                    Console.WriteLine(" Total com desconto: " + SaleInCash.getPrice());
                    break;
                case 2:
                    Console.WriteLine(" Total com desconto: " + SaleDebit.getPrice());
                    break;
                case 3:
                    Console.WriteLine(" Total com desconto: " + SaleParceledOut.getPrice());
                    break;

                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }
    }
}
