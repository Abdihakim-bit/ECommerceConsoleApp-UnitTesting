using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceConsoleApp
{
    public class Product
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public decimal ItemPrice { get; set; }
        public int StockAmount { get; set; }

        public Product(int prodID, string prodName, decimal itemPrice, int stockAmount)
        {

            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }


        public void IncreaseStock(int amount)
        {
            StockAmount += amount;
        }

        public void DecreaseStock(int amount)
        {
            if (StockAmount >= amount)
                StockAmount -= amount;
            else
                throw new ArgumentException("Not enough stock to decrease.");
        }

    }
}
