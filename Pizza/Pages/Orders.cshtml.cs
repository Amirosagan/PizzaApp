using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza.Data;
using Pizza.Models;

namespace Pizza.Pages
{
    public class OrdersModel : PageModel
    {
        private readonly ApplicationDbContext context;
        public List<PizzaOrder> pizzaOrders = new List<PizzaOrder>();
        public OrdersModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            pizzaOrders = context.pizzaOrders.ToList();
        }
    }
}
