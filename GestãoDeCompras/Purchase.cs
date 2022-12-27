using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderControl
{
    public class Purchase
    {
        public static Int64 LotAux { get; private set; }
        public Int64 Lot { get; set; }
        public Product Product { get; set; }
        public Int16 Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Total 
        { 
            get
            {
                return CalculateTotal();
            }
        }
        static Purchase()
        {
            LotAux = 1;
        }
        public Purchase()
        {
            Lot = LotAux++;
        }
        public decimal CalculateTotal()
        {
            return Quantity * Product.Price;
        }
        public override string ToString()
        {
            return "["+Lot+"] "+Quantity+" x "+Product.Name+" = R$"+this.CalculateTotal();
        }
    }
}
