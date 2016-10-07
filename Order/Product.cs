using System.Collections.Generic;
using System.Linq;

namespace Order
{
    public class Product
    {
        public List<int> GetOrderSum(List<MyOrder> myOrders, int groupNum,string type)
        {
            List<int> result = new List<int>();
            int groupNow = 0;
            List<int> costGroup = null;
            if (type == "Cost")
            {
                costGroup = myOrders.Select(t => t.Cost).ToList();
            }
            else if (type == "Revenue")
            {
                costGroup = myOrders.Select(t => t.Revenue).ToList();
            }
  
            
            for (int i = 0; i < costGroup.Count(); i++)
            {
                if (i % groupNum == 0)
                {
                    result.Add(0);
                    groupNow++;
                };
                result[groupNow-1] += costGroup[i];
            }
            return result;
        }
    }
}
