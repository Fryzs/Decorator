using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class BurgerDecorator : IBurger
    {
        protected readonly IBurger _burger;

        protected BurgerDecorator(IBurger burger)
        {
            _burger = burger ?? throw new ArgumentNullException(nameof(burger));
        }

        public virtual string GetDescription() => _burger.GetDescription();
        public virtual decimal GetCost() => _burger.GetCost();
    }
}
