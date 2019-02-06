using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Product
    {
       public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }

       
        public override string ToString()
        {
            return "Name:" + Name + "   Price:" + Price+ "    Quantity:" + Quantity + "   Type:" + Type;
        }
    }
}
