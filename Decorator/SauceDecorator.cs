using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SauceDecorator : BurgerDecorator
    {
        private readonly string _sauceType;
        private readonly decimal _sauceCost;

        public SauceDecorator(IBurger burger, string sauceType, decimal sauceCost = 10m) : base(burger)
        {
            _sauceType = string.IsNullOrWhiteSpace(sauceType) ? "Sauce" : sauceType;
            _sauceCost = sauceCost < 0 ? 0 : sauceCost;
        }

        public override string GetDescription() => base.GetDescription() + $" + {_sauceType}";
        public override decimal GetCost() => base.GetCost() + _sauceCost;
    }
}
