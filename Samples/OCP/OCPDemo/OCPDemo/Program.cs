using OCPDemo.BusinessModels;
using OCPDemo.Enums;
using OCPDemo.Models;
using OCPDemo.ProductFilters;
using System;

namespace OCPDemo
{
    /// <summary>
    /// Build simple products with filter
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var apple = new ProductModel("Apple", Color.Green, Size.Small);
            var tree = new ProductModel("Tree", Color.Green, Size.Large);
            var house = new ProductModel("House", Color.Blue, Size.Large);
            Product[] products = { apple, tree, house };

            var productFilter = new ProductFilter();

            var colorSpec = new ColorSpecification(Color.Green);
            var reuslt = productFilter.Filter(products, colorSpec);

            Console.ReadLine();
        }
    }
}
