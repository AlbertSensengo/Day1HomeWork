using System;
using System.Collections.Generic;
using System.Linq;

namespace Order
{
    public class Product
    {
        public IEnumerable<int> GetOrderSum(List<MyOrder> myOrders, int groupNum, Func<MyOrder,int> selector)
        {
            int i = 0;
            while (i < myOrders.Count())
            {
                yield return myOrders.Skip(i).Take(groupNum).Sum(selector);
                i += groupNum;
            }
        }
    }
}
