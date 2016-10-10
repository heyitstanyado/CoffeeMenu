using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShopDemo
{
    public class DrinkItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } //e.g. coffee, tea, smoothie
        public double Price { get; set; }
        public bool IsSeasonal { get; set; }
    }
}