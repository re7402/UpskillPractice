using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaProjuct.Model;

namespace PizzaProjuct.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzaToppings pizzaToppings { get; set; }
        public float PizzaPrice { get; set; }
        public IActionResult OnPost()
        {
            PizzaPrice = pizzaToppings.Price;
            if (pizzaToppings.Cheese)
                PizzaPrice = +1;
            if (pizzaToppings.Sauce)
                PizzaPrice = +1;
            if (pizzaToppings.Chicken)
                PizzaPrice = +1;
            if (pizzaToppings.OliveSprings)
                PizzaPrice = +1;
            if (pizzaToppings.PepperBarbequeChicken)
                PizzaPrice = +1;
            if (pizzaToppings.Peperoni)
                PizzaPrice = +1;
            if (pizzaToppings.GoldenCorn)
                PizzaPrice = +1;
            if (pizzaToppings.Mushroom)
                PizzaPrice = +1;
            return RedirectToPage("/Checkouts/Checkout", new { pizzaToppings.PizzaName, PizzaPrice });
        }
    }
}
