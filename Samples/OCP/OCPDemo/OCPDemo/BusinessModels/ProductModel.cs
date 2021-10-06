using OCPDemo.Enums;
using OCPDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPDemo.BusinessModels
{
    public class ProductModel : Product
    {
        public ProductModel(string name, Color color, Size size)
        {
            this.Name = name;
            this.Color = color;
            this.Size = size;
        }
    }
}
