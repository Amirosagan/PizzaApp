using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza.Data;
using Pizza.Models;

namespace Pizza.Pages.LastCheak
{
    [BindProperties(SupportsGet = true)]
    public class CheakOutModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public string? PizzaName { get; set; }

        public float price { get; set; }

        public CheakOutModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
                PizzaName = "Coustem";

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.Price = price;

            context.pizzaOrders.Add(pizzaOrder);
            context.SaveChanges();

        }
    }
}
