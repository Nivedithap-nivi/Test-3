using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    enum CommodityCategory
    {
        Furniture,
        Grocery,
        Service
    }
    class Commodity
    {
       public CommodityCategory Category { get; set; }
        public string CommodityName {  get; set; }
        public int CommodityQuantity {  get; set; }
        public double CommodityPrice {  get; set; }

        public Commodity(CommodityCategory Category, string CommodityName, int CommodityQuantity, double CommodityPrice)
        {
            this.Category = Category;
            this.CommodityQuantity = CommodityQuantity;
            this.CommodityPrice = CommodityPrice;
            this.CommodityName = CommodityName;
        }
    }
}
