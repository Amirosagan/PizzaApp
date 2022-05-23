using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza.Models;

namespace Pizza.Pages.Form
{
    public class CustomPizzaModel : PageModel
    {

        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float price { get; set; }



        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            price = Pizza.price;
            if (Pizza.tomato) price += 1;
            if (Pizza.cheese) price += 2;
            if (Pizza.tuna) price += 4;
            if (Pizza.mushroom) price += 2;
            if (Pizza.peproni) price += 3;



            return RedirectToPage("../LastCheak/CheakOut", new { Pizza.pizzaName, price });
        }

    }
}
