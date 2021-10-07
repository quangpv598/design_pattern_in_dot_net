using OCPDemo.Enums;
using OCPDemo.Models;
using OCPDemo.ProductFilters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPDemo.ProductFilters.Specifications
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;
        public SizeSpecification(Size size)
        {
            this.size = size;
        }
        public override bool IsSatisfied(Product item)
        {
            return item.Size == size;
        }
    }
}
