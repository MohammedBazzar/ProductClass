using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask
{
    internal class Product
    {
        public int id;
        public String name;
        public float price;
        public string description;

        public void  print()
        {
            Console.WriteLine($" product id: {id}... name: {name}.... product price{price}....description:{description}");
            Console.WriteLine("================================");
        }
    }
}
