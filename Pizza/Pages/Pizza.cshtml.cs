using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza.Models;

namespace Pizza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> FakePizzaDb= new List<PizzasModel>()
        {
            new PizzasModel (){pizzaName = "Margerita" ,price = 4 , tomato = true , cheese = true , peproni = true},
            new PizzasModel (){pizzaName = "tuna" ,price = 5 , tomato = true , cheese = true , tuna = true},
            new PizzasModel (){pizzaName = "Mashrom" ,price = 5, tomato = true , cheese = true , mushroom= true},
            new PizzasModel (){pizzaName = "peproni" ,price = 4  , cheese = true , peproni= true},
            new PizzasModel (){pizzaName = "all of one" ,price = 4 , tomato = true , cheese = true , peproni = true,tuna = true,mushroom = true}
            
        };
        public void OnGet()
        {
        }
    }
}
