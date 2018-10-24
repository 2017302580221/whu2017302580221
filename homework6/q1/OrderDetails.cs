using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class OrderDetails
    {
        public string commodityName;  
        public int commodityNum;   
        public int commodityPrice;

        public OrderDetails(string name, int num, int price)
        {
            this.commodityName = name;
            this.commodityNum = num;
            this.commodityPrice = price;
        }
        public OrderDetails() { }
    }
}
