using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task1
{
    internal class Product
    {
        private int stockQuantity = 0;
        private double price = 0;

        public string Name { get; set; }
        public int StockQuantity { get { return stockQuantity; } private set {
                if (value >= 0)
                    stockQuantity = value;
                else
                    throw new Exception("Stock Quantity cannot be set to -ve value");
                    
            } 
        }
        public double Price { get { return price; } 
            set {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Price cannot be set to -ve value");
            } 
        }
        public bool IsAvaliable { get { return StockQuantity > 0; } }

        public bool UpdateStock(int amount)
        {
            bool isValid = false;
            try
            {
                StockQuantity += amount;
                isValid = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isValid;
        }

    }
}
