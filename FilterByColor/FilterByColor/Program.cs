using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterByColor
{
    public enum Color
    {
        Red,Green,Blue,Yellow
    }
    public enum Size
    {
        Small, Medium, Large, XL
    }
    public class Product
    {
        public string Name;
        public Size productSize;
        public Color productcolor;
        public Product(string name,Size size,Color color)
        {
            this.Name = name;
            this.productcolor = color;
            this.productSize = size;
        }
    }
    public class Filter
    {
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products,Color color)
        {
            foreach(var p in products)
            {
                if(p.productcolor==color)
                    yield return p;
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var proA = new Product("Kurta", Size.Small, Color.Red);
            var proB = new Product("Jeans", Size.Small, Color.Blue);
            var proC = new Product("Pyjama", Size.Large, Color.Red);
            var proD = new Product("Saree", Size.Medium, Color.Red);
            var proE = new Product("MaxiDress", Size.Small, Color.Red);
            var products = new List<Product>() { proA, proB, proC, proD, proE };
            var filter = new Filter();
            var productsList = filter.FilterByColor(products, Color.Red);
            foreach(var product in productsList)
            {
                Console.WriteLine($"{product.Name}");
            }
            Console.ReadLine();
        }
    }
}
