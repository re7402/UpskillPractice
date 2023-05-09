using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample
{
    public interface IBird
    {
        void Fly();
    }
    public interface ILizard
    {
        void Crawl();
    }
    public class Bird : IBird
    {
        public int weight
        {
            get; set;
        }
        public void Fly()
        {
            Console.WriteLine($"Snoaring in the sky with weight : {weight}");
        }
    }
    public class Lizard : ILizard
    {
        public int weight { get; set; }
        public void Crawl()
        {
            Console.WriteLine($"Crawling in the dust with weight : {weight}");
        }
    }
    public class Dragon : IBird, ILizard
    {
        Bird bird = new Bird();
        Lizard lizard = new Lizard();

        public void Crawl()
        {
            lizard.Crawl();
            //Console.WriteLine("Dragon crawl");
        }
        public void Fly()
        {
            bird.Fly();
            //Console.WriteLine("Dragon flying");
        }
        public int weight
        {
            get
            {
                return weight;
            }
            set
            {
                bird.weight = value;
                lizard.weight = value;
            }
        }
    }
        public class Program
        {
            static void Main(string[] args)
            {
                Dragon d = new Dragon();
                d.weight = 12;
                d.Fly();
                d.Crawl();
                Console.ReadLine();
            }
        }
}
