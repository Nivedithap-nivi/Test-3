using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
     class PrepareBill
    {
        private readonly IDictionary<CommodityCategory, double> _taxRates;
        public PrepareBill()
        {
            _taxRates = new Dictionary<CommodityCategory, double>();
        }
      public void SetTaxRate(CommodityCategory category, double taxRate)
        {
            _taxRates.Add(category, taxRate);
        }
        public double CalculateBillAmount(IList<Commodity> items)
        {
            double result = 0;
            double tax = 0;

            foreach (var i in items)
            {
                foreach (var j in _taxRates)
                {
                    if (i.Category == j.Key)
                        tax = j.Value;
                    result += i.CommodityQuantity * i.CommodityPrice;
                }

            }
            return result + tax;
        }
      
    }
}
