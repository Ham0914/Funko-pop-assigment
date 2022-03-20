using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }


        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();

            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.FunkoName = "shazam";
            TestItem.FunkoNo = 1;
            TestItem.Price = 1;
            TestItem.OrderNo = 1;

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();

            TestOrder.Available = true;
            TestOrder.DateAdded = DateTime.Now.Date;
            TestOrder.FunkoName = "shazam";
            TestOrder.FunkoNo = 1;
            TestOrder.Price = 1;
            TestOrder.OrderNo = 1;

            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();

            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.FunkoName = "shazam";
            TestItem.FunkoNo = 1;
            TestItem.Price = 1;
            TestItem.OrderNo = 1;

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }

    }

}
