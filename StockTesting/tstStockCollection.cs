using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {


        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]

        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();

            TestItem.InStock = true;
            TestItem.IdNum = 1;
            TestItem.ItemTag = "Movie";
            TestItem.ItemQty = 1;
            TestItem.ItemDesc = "Funko pop";
            TestItem.DateAdded = DateTime.Now;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]

        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestItem = new clsStock();

            TestItem.InStock = true;
            TestItem.IdNum = 1;
            TestItem.ItemTag = "Movie";
            TestItem.ItemQty = 1;
            TestItem.ItemDesc = "Funko pop";
            TestItem.DateAdded = DateTime.Now;

            AllStock.ThisStock = TestItem;

            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }


        [TestMethod]

        public void ListAndCOuntOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();

            TestItem.InStock = true;
            TestItem.IdNum = 1;
            TestItem.ItemTag = "Movie";
            TestItem.ItemQty = 1;
            TestItem.ItemDesc = "Funko pop";
            TestItem.DateAdded = DateTime.Now;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]

        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            TestItem.InStock = true;
            TestItem.IdNum = 1;
            TestItem.ItemTag = "Movie";
            TestItem.ItemQty = 1;
            TestItem.ItemDesc = "Funko pop";
            TestItem.DateAdded = DateTime.Now;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.IdNum = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestItem = new clsStock();
            
            Int32 PrimaryKey = 0;

            TestItem.InStock = true;
            TestItem.IdNum = 1;
            TestItem.ItemTag = "Movie";
            TestItem.ItemQty = 1;
            TestItem.ItemDesc = "Funko pop";
            TestItem.DateAdded = DateTime.Now;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.IdNum = PrimaryKey;

            TestItem.InStock = false;
            TestItem.IdNum = 3;
            TestItem.ItemTag = "antoher Movie";
            TestItem.ItemQty = 3;
            TestItem.ItemDesc = "another Funko pop";
            TestItem.DateAdded = DateTime.Now;

            AllStock.ThisStock = TestItem;

            AllStock.Update();

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            TestItem.InStock = true;
            TestItem.IdNum = 1;
            TestItem.ItemTag = "Movie";
            TestItem.ItemQty = 1;
            TestItem.ItemDesc = "Funko pop";
            TestItem.DateAdded = DateTime.Now;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.IdNum = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            AllStock.Delete();

            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);

            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByItemTag()
        {

            clsStockCollection FilteredStock = new clsStockCollection();

            FilteredStock.ReportByItemTag("xxxxx");

            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByitemTagTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();

            Boolean ok = true;

            FilteredStock.ReportByItemTag("xxxx");

            if(FilteredStock.Count == 2)
            {
                if(FilteredStock.StockList[0].IdNum != 4)
                {
                    ok = false;
                }
                if(FilteredStock.StockList[1].IdNum != 26)
                {
                    ok=false;
                }
            }
            else
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

    }
}
