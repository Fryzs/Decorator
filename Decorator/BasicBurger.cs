using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public sealed class BasicBurger : IBurger
    {
        private readonly string _name;
        private readonly decimal _cost;

        public BasicBurger(string name, decimal cost)
        {
            _name = string.IsNullOrWhiteSpace(name) ? "Basic Burger" : name;
            _cost = cost < 0 ? 0 : cost;
        }

        public string GetDescription() => _name;
        public decimal GetCost() => _cost;
    }
}
