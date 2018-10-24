using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    [Serializable]
    public class Order
    {
        public string customerName;  
        public int customerNum = 0;   

        public int index2;

        public List<OrderDetails> OrderDetails = new List<OrderDetails>();

        public Order() { }
        public Order(string name, int num, List<OrderDetails> list)
        {
            this.customerName = name;
            this.customerNum = num;
            this.OrderDetails = list;
        }
        string[] line = File.ReadAllLines("addtest.txt");
        
        public void Add()
        {
            try
            {
                OrderDetails orderDetail = new OrderDetails();
                Console.WriteLine("请输入商品名称:");
                orderDetail.commodityName = line[index2++];
                Console.WriteLine("请输入商品数目:");
                orderDetail.commodityNum = int.Parse(line[index2++]);
                Console.WriteLine("请输入商品单价:");
                orderDetail.commodityPrice = int.Parse(line[index2]);
                OrderDetails.Add(orderDetail);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public void Show()
        {
            Console.WriteLine("商品:");
            foreach (OrderDetails t in OrderDetails)
            {
                Console.WriteLine(t.commodityName + " * " + t.commodityNum + " " + t.commodityPrice + "元/件");
            }
        }
       
        public void Clear()
        {
            OrderDetails.Clear();
        }
      
        public Order Find(string s)
        {
            foreach (OrderDetails t in OrderDetails)
            {
                if (t.commodityName.Equals(s))
                {
                    return this;
                }
            }
            return null;
        }
       
        public int Sum()
        {
            int sum = 0;
            foreach (OrderDetails t in OrderDetails)
            {
                sum += t.commodityPrice * t.commodityNum;
            }
            return sum;
        }
    }
}
