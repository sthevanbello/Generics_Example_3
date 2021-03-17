using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Example_02.Entities
{
    class Products : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Products))
            {
                throw new ArgumentException("Comparing erro: argument is not a Product");
            }
            Products other = obj as Products;

            return Price.CompareTo(other.Price);
        }

        
    }
}
