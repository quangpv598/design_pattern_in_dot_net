using OCPDemo.BusinessModels;
using OCPDemo.Enums;
using OCPDemo.Models;
using OCPDemo.ProductFilters;
using OCPDemo.ProductFilters.Specifications;
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

            var colorGreenSpec = new ColorSpecification(Color.Green);
            var sizeSmallSpec = new SizeSpecification(Size.Small);
            var reuslt = productFilter.Filter(products, new AndSpecification<Product>(colorGreenSpec, sizeSmallSpec));

            var smallGreen = colorGreenSpec & sizeSmallSpec;
            var resultSample2 = productFilter.Filter(products, smallGreen);

            Console.ReadLine();
        }
    }
}
