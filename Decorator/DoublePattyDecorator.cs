using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DoublePattyDecorator : BurgerDecorator
    {
        private readonly decimal _extraPattyCost;

        public DoublePattyDecorator(IBurger burger, decimal extraPattyCost = 40m) : base(burger)
        {
            _extraPattyCost = extraPattyCost < 0 ? 0 : extraPattyCost;
        }

        public override string GetDescription() => base.GetDescription() + " + Double Patty";
        public override decimal GetCost() => base.GetCost() + _extraPattyCost;
    }
}
