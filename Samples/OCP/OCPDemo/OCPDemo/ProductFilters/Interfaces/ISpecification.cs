using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPDemo.ProductFilters.Interfaces
{
    public abstract class ISpecification<T>
    {
       public abstract bool IsSatisfied(T item);
       public static ISpecification<T> operator &(ISpecification<T> first, ISpecification<T> second)
        {
            return new AndSpecification<T>(first, second);
        }
    }
}
