using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaProjuct.Model;

namespace PizzaProjuct.Pages.Checkouts
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public PizzaToppings pizza { get; set; }
        public string pizzaName { get; set; }
        public float price { get; set; }    
        public void OnGet()
        {
            if (string.IsNullOrEmpty(pizzaName))
            {
                pizzaName = "Custom";
            }
            price = pizza.Price;
        }
    }
}
