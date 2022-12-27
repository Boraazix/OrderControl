using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderControl
{
    internal class MockDatabase
    {
        public static BindingList<Purchase> Purchases { get; set; }
        public static List<Product> Products {get; set;}
        static MockDatabase()
        {
            Purchases = new BindingList<Purchase>();
            Products = new List<Product>
            {
                new Product(1, "Paçoca", 0.5m),
                new Product(2, "Garrafa", 30m),
                new Product(3, "Celular", 3210.99m),
                new Product(4, "Caixa JBL", 400m),
                new Product(5, "Mouse Mancer", 99.9m),
                new Product(6, "Disco Vinil", 500m),
                new Product(7, "Cadeira Gamer HyperX", 1700m),
                new Product(8, "SSD NVME 1TiB Kingston", 597.9m),
                new Product(9, "Cabo Ehternet CAT7E 20m", 300m),
                new Product(10, "MousePad Dr. Mouse", 200m),
                new Product(11, "Boné aba reta", 50m),
                new Product(12, "Corta Vento Supreme", 500m),
                new Product(13, "Óculos Escuros", 20m),
                new Product(14, "Piranha de cabelo", 2m),
                new Product(15, "Extintor de Incêndio", 300m),
                new Product(16, "Bag Gucci", 5000m),
                new Product(17, "Chinelo Balenciaga", 2630m),
                new Product(18, "Maçaneta Gamer", 300m),
                new Product(19, "ZSN Pro KZ", 150m),
                new Product(20, "Relógio Rolex", 107000m)
            };
        }

        public static Product FindProductById(Int64 c)
        {
            foreach (Product p in Products)
            {
                if (p.Code == c)
                    return p;
            }
            return null;
        }
        public static List<Product> FindProductByPartialName(String n)
        {
            List<Product> lista = new List<Product>();
            foreach (Product p in Products)
            {
                if (p.Name.ToUpper().Contains(n.ToUpper()))
                {
                    lista.Add(p);
                }
            }
            return lista;
        }
        public static List<Purchase> ExpiresOneDay()
        {
            List<Purchase> c = new List<Purchase>();
            foreach (Purchase c2 in MockDatabase.Purchases)
            {
                if (c2.ExpirationDate.Date <= DateTime.Now.Date.AddDays(1))
                    c.Add(c2);
            }
            return c;
        }
        public static List<Purchase> ExpiresFiveDays()
        {
            List<Purchase> c = new List<Purchase>();
            foreach (Purchase c2 in MockDatabase.Purchases)
            {
                if (c2.ExpirationDate.Date <= DateTime.Now.Date.AddDays(5))
                    c.Add(c2);
            }
            return c;
        }
        public static List<Purchase> 
            CustomPurchaseExpirationDate
            (DateTime c0, DateTime cf, DateTime v0, DateTime vf, Boolean ckC, Boolean ckV)
        {
            List<Purchase> c = new List<Purchase>();
            foreach (Purchase c2 in MockDatabase.Purchases)
            {
                if(ckC && ckV)
                {
                    c.Add(c2);
                }
                else if (ckC && !ckV)
                {
                    if (v0.Date <= c2.ExpirationDate.Date && c2.ExpirationDate.Date <= vf.Date)
                        c.Add(c2);
                }
                else if (!ckC && ckV)
                {
                    if (c0.Date <= c2.PurchaseDate.Date && c2.PurchaseDate.Date <= cf.Date)
                        c.Add(c2);
                }
                else if (!ckC && !ckV)
                {
                    if(c0.Date <= c2.PurchaseDate.Date && c2.PurchaseDate.Date <= cf.Date && v0.Date <= c2.ExpirationDate.Date && c2.ExpirationDate.Date <= vf.Date)
                        c.Add(c2);
                }
            }
            return c;
        }
    }
}
