using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public  class BaconDecorator : BurgerDecorator
    {
        private readonly decimal _baconCost;

        public BaconDecorator(IBurger burger, decimal baconCost = 25m) : base(burger)
        {
            _baconCost = baconCost < 0 ? 0 : baconCost;
        }

        public override string GetDescription() => base.GetDescription() + " + Bacon";
        public override decimal GetCost() => base.GetCost() + _baconCost;
    }

}
