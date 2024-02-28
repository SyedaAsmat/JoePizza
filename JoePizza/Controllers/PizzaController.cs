using JoePizzaLib;
using Microsoft.AspNetCore.Mvc;

namespace JoePizza.Controllers
{
    public class PizzaController : Controller
    {
        static List<Pizza> pizzaMenu = new List<Pizza>
    {
        new Pizza { Id = 1, Name = "Margherita", Price = 450 },
        new Pizza { Id = 2, Name = "Pepperoni", Price = 550 },
        new Pizza { Id = 3, Name = "Farm House", Price = 860 },
        new Pizza { Id = 4, Name = "Veggie Paradise", Price = 650 }
    };

        static List<Order> orders = new List<Order>();

        public IActionResult PizzaSelection()
        {
            return View(pizzaMenu);
        }

        [HttpPost]
        public IActionResult OrderCheckout(int pizzaId, int quantity)
        {
            Pizza selectedPizza = pizzaMenu.FirstOrDefault(p => p.Id == pizzaId);

            if (selectedPizza == null)
            {
                return NotFound();
            }

            var order = new Order { Id = GetNextOrderId(), Pizza = selectedPizza, Quantity = quantity };
            orders.Add(order);

            return View(order);
        }

        public IActionResult OrderConfirmation(int orderId)
        {
            var order = orders.FirstOrDefault(o => o.Id == orderId);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
        private int GetNextOrderId()
        {
            return orders.Count + 1;
        }
    }
}
