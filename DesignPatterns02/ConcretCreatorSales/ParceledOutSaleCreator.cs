using DesignPatterns02.Classes;
using DesignPatterns02.ConcretSales;
using DesignPatterns02.CreatorSaleDiscount;

namespace DesignPatterns02.ConcretCreatorSales
{
    class ParceledOutSaleCreator : SaleCreator
    {
        public override Sale CreateSale()
        {
            return new ParceledOutSale();
        }
    }
}
