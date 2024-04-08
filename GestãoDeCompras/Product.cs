using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderControl
{
    public class Product
    {
        public Int64 Code { get; set; }
        private String _name { get; set; }
        public String Name { 
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 45)
                    _name = value.Substring(0, 45);
                else
                    _name = value;
            }
        }
        public Decimal Price { get; set; }
        public Product()
        {

        }
        public Product(Int64 c, String n, Decimal p)
        {
            Code = c;
            Name = n;
            Price = p;
        }
        public override string ToString()
        {
            return "["+Code+"] "+Name+": R$ "+Price;
        }
    }
}
