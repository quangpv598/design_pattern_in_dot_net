using OCPDemo.Enums;
using OCPDemo.Models;
using OCPDemo.ProductFilters.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPDemo.ProductFilters.Extensions
{
    public static class CriteriaExtensions
    {
        public static AndSpecification<Product> And(this Color color, Size size)
        {
            return new AndSpecification<Product>(
                new ColorSpecification(color),
                new SizeSpecification(size));
        }
    }
}
