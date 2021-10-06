using OCPDemo.Enums;
using OCPDemo.Models;
using OCPDemo.ProductFilters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPDemo.ProductFilters
{
    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
        {
            return items.Where(p => specification.IsSatisfied(p));
        }
    }
}
