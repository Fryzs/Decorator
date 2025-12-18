using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public  class CheeseDecorator : BurgerDecorator
    {
        private readonly decimal _cheeseCost;

        public CheeseDecorator(IBurger burger, decimal cheeseCost = 15m) : base(burger)
        {
            _cheeseCost = cheeseCost < 0 ? 0 : cheeseCost;
        }

        public override string GetDescription() => base.GetDescription() + " + Cheese";
        public override decimal GetCost() => base.GetCost() + _cheeseCost;
    }
}
