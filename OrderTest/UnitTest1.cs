﻿using System;
using Order;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace OrderTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetOrderSumCost()
        {
            List<MyOrder> myOrders = this.GetProduct();

            Product target = new Product();
            List<int> expected = new List<int>() {6,15,24,21};

            List<int> actual = target.GetOrderSum(myOrders, 3, t => t.Cost).ToList();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetOrderSumRevenue()
        {
            List<MyOrder> myOrders = this.GetProduct();

            Product target = new Product();
            List<int> expected = new List<int>() { 50, 66, 60};

            List<int> actual = target.GetOrderSum(myOrders, 4, t=> t.Revenue).ToList();

            CollectionAssert.AreEqual(expected, actual);
        }

        private List<MyOrder> GetProduct()
        {
            List<MyOrder> products = new List<MyOrder>()
            {
                new MyOrder() { id = 1, Cost = 1, Revenue = 11, SellPrice = 21 },
                new MyOrder() { id = 2, Cost = 2, Revenue = 12, SellPrice = 22 },
                new MyOrder() { id = 3, Cost = 3, Revenue = 13, SellPrice = 23 },
                new MyOrder() { id = 4, Cost = 4, Revenue = 14, SellPrice = 24 },
                new MyOrder() { id = 5, Cost = 5, Revenue = 15, SellPrice = 25 },
                new MyOrder() { id = 6, Cost = 6, Revenue = 16, SellPrice = 26 },
                new MyOrder() { id = 7, Cost = 7, Revenue = 17, SellPrice = 27 },
                new MyOrder() { id = 8, Cost = 8, Revenue = 18, SellPrice = 28 },
                new MyOrder() { id = 9, Cost = 9, Revenue = 19, SellPrice = 29 },
                new MyOrder() { id = 10, Cost = 10, Revenue = 20, SellPrice = 30 },
                new MyOrder() { id = 11, Cost = 11, Revenue = 21, SellPrice = 31 }
            };

            return products;
        }
    }
}
