using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace_2022.Shared {
    public class HardCodedMenuService : IMenuService {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu {
                Pizzas = new List<Pizza> {
                    //new Pizza(1, "Pepperoni", 8.99M, Spiciness.Spicy),
                    //new Pizza(2, "Margarita", 7.99M, Spiciness.None),
                    ////new Pizza(3, "Diabolo", 9.99M, Spiciness.Hot)
                    new Pizza(4, "Áo Phông", 45, Spiciness.ao1),

                    new Pizza(5, "Váy Công Chúa", 50, Spiciness.ao2),
                     new Pizza(6, "Áo Bông Hoa", 60, Spiciness.ao3),
                      new Pizza(7, "Chân Váy", 49, Spiciness.vay),
                      new Pizza(8, "Áo", 49, Spiciness.ao4)
                }
            });
    }
}

