﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoffeeMenu.Models;

namespace CoffeeMenu.DAL
{
    public class MenuInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MenuContext>
    {
        protected override void Seed(MenuContext context)
        {
            var drinks = new List<Drink>
            {
                new Drink { Name = "Pumpkin Spice Latte", Price = 4.75, IsSeasonal = true},
                new Drink { Name = "Black Coffee", Price = 2.50, IsSeasonal = false},
                new Drink { Name = "Green Tea Latte", Price = 4.50, IsSeasonal = false},
                new Drink { Name = "Cafe Au Lait", Price = 3.25, IsSeasonal = false},

            };

            drinks.ForEach(d => context.Drinks.Add(d));
            context.SaveChanges();

        }
    }
}