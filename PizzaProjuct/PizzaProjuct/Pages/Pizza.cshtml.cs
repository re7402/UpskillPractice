using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaProjuct.Model;

namespace PizzaProjuct.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzaToppings> pizzasFakeDB = new List<PizzaToppings>()
        {
            new PizzaToppings(){ ImageTitle="Margerita",PizzaName="Margerita",Price=2,Sauce=true,Cheese=true,OliveSprings=true,Chicken=true,Peperoni=true,PepperBarbequeChicken=true,Mushroom=true,GoldenCorn=true,},
            new PizzaToppings(){ ImageTitle="Hawaiian",PizzaName="Hawaiian",Price=2,Sauce=true,Cheese=true,OliveSprings=true,Chicken=true,Peperoni=true,PepperBarbequeChicken=true,Mushroom=true,GoldenCorn=true,},
            new PizzaToppings(){ImageTitle = "MeatFeast", PizzaName="MeatFeast",Price=2,Sauce=true,Cheese=true,OliveSprings=true,Chicken=true,Peperoni=true,PepperBarbequeChicken=true,Mushroom=true,GoldenCorn=true,},
            new PizzaToppings(){ImageTitle = "Seafood", PizzaName="Seafood",Price=2,Sauce=true,Cheese=true,OliveSprings=true,Chicken=true,Peperoni=true,PepperBarbequeChicken=true,Mushroom=true,GoldenCorn=true,},
            new PizzaToppings(){ ImageTitle="Margerita",PizzaName="Margerita",Price=2,Sauce=true,Cheese=true,OliveSprings=true,Chicken=true,Peperoni=true,PepperBarbequeChicken=true,Mushroom=true,GoldenCorn=true,},
            new PizzaToppings(){ ImageTitle="Hawaiian",PizzaName="Hawaiian",Price=2,Sauce=true,Cheese=true,OliveSprings=true,Chicken=true,Peperoni=true,PepperBarbequeChicken=true,Mushroom=true,GoldenCorn=true,},
            new PizzaToppings(){ImageTitle = "MeatFeast", PizzaName="MeatFeast",Price=2,Sauce=true,Cheese=true,OliveSprings=true,Chicken=true,Peperoni=true,PepperBarbequeChicken=true,Mushroom=true,GoldenCorn=true,},
            new PizzaToppings(){ImageTitle = "Seafood", PizzaName="Seafood",Price=2,Sauce=true,Cheese=true,OliveSprings=true,Chicken=true,Peperoni=true,PepperBarbequeChicken=true,Mushroom=true,GoldenCorn=true,}
        };
        
        public void OnGet()
        {
        }
    }
}
