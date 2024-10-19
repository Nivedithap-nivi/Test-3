namespace Q3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Commodities = new List<Commodity>()
            {
                new Commodity(CommodityCategory.Furniture,"Bed",2,50000),
                new Commodity(CommodityCategory.Grocery, "Flour", 5, 80),
                new Commodity(CommodityCategory.Service, "Insurance", 2, 8500),
            };
            PrepareBill prepareBill = new PrepareBill();
            prepareBill.SetTaxRate(CommodityCategory.Furniture, 18);
            prepareBill.SetTaxRate(CommodityCategory.Grocery, 5);
            prepareBill.SetTaxRate(CommodityCategory.Service, 12);
        
            var billAmount = prepareBill.CalculateBillAmount(Commodities);
            Console.WriteLine($"{billAmount}");
        }
    }
}
