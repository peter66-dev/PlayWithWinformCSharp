using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class ProductObject
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string Weight { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public ProductObject()
        {
            ProductID = 0;
            CategoryID = 0;
            ProductName = "";
            Weight = "";
            UnitPrice = 0;
            UnitsInStock = 0;
        }

        public ProductObject(int proid, int cateid, string proName, string weight, decimal unitPrice, int unitsInStock)
        {
            ProductID = proid;
            CategoryID = cateid;
            ProductName = proName;
            Weight = weight;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }

        public ProductObject(int proid, int cateid, string proName, decimal unitPrice, int quantityBuy)
        {
            ProductID = proid;
            CategoryID = cateid;
            ProductName = proName;
            UnitPrice = unitPrice;
            UnitsInStock = quantityBuy;
        }

        public ProductObject(string proName, int quantityBuy)
        {
            ProductName = proName;
            UnitsInStock = quantityBuy;
        }
    }
}
