using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn02
{
    public class CompositePriceCalculator : IPriceCalculator
    {
        private IReadOnlyCollection<IPriceCalculator> _calculators;
        public CompositePriceCalculator(params IPriceCalculator[] calculators)
        {
            this._calculators = calculators;
        }

        public decimal CalculatePrice(Basket basket)
        {
            var price = 0m;
            foreach(var calculator in _calculators)
                price = price + calculator.CalculatePrice(basket);
            return price;
        }
    }
}
