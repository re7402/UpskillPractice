using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{

    public enum Color
    {
        Red, Blue, Green, Yellow
    }
    public enum Size
    {
        Small, Medium, Large, XL
    }
    public class Product
    {
        public string Name;
        public Color color;
        public Size size;
        public Product(string Name, Size size, Color color)
        {
            this.Name = Name;
            this.size = size;
            this.color = color;
        }
    }
    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
            {
                if (p.size == size)
                    yield return p;
            }
        }
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
            {
                if (p.productcolor == color)
                    yield return p;
            }
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            var productA = new Product("Kurti", Size.Small, Color.Green);
            var productB = new Product("jeans", Size.Medium, Color.Blue);
            var productC = new Product("t-shirt", Size.XL, Color.Red);
            var productD = new Product("Saree", Size.Small, Color.Red);
            Product[] products = { productA, productB, productC, productD };
            var filter = new ProductFilter();
            foreach (var product in filter.FilterBySize(products,Size.Small))
            {
                Console.WriteLine(product.Name);
            }
            Console.ReadLine();
            Console.WriteLine("filter BY color");
            foreach(var product in filter.FilterByColor(products,Color.Blue))
            {
                Console.WriteLine(product.Name);
            }
           Console.ReadLine();
        }

    }
}
