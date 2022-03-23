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

        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.Available = true;
            TestItem.FunkoNo = 1;
            TestItem.FunkoName = "Hulk";
            TestItem.OrderNo = 1;
            TestItem.Price = 1;
            TestItem.DateAdded = DateTime.Now;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.FunkoNo = PrimaryKey;

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.Available = true;
            TestItem.OrderNo = 1;
            TestItem.FunkoName = "Hulk";
            TestItem.Price = 1;
            TestItem.DateAdded = DateTime.Now;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.FunkoNo = PrimaryKey;

            TestItem.Available = false;
            TestItem.OrderNo = 2;
            TestItem.FunkoName = "Thor";
            TestItem.Price = 2;
            TestItem.DateAdded = DateTime.Now;

            AllOrders.ThisOrder = TestItem;

            AllOrders.Update();

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.Available = true;
            TestItem.FunkoNo = 1;
            TestItem.FunkoName = "Hamalam";
            TestItem.OrderNo = 1;
            TestItem.Price = 10;
            TestItem.DateAdded = DateTime.Now;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.FunkoNo = PrimaryKey;

            AllOrders.ThisOrder.Find(PrimaryKey);

            AllOrders.Delete();

            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByFunkoNoMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByFunkoNo("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByFunkoNoNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByFunkoNo("xxxxx");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByFunkoNoTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByFunkoNo("Hamalam");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].FunkoNo != 25)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].FunkoNo != 30)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }

}
