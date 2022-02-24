using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsStock AnStock = new clsStock();
            Assert.IsNotNull(AnStock);
            
        }

        [TestMethod]
        public void InStockPropertyOK()
        {
            clsStock AnStock = new clsStock();

            Boolean TestData = true;

            AnStock.InStock = TestData;

            Assert.AreEqual(AnStock.InStock, TestData);
        }

        [TestMethod]

        public void ItemLastStock()
        {
            clsStock AnStock = new clsStock();

            DateTime TestData = DateTime.Now.Date;

            AnStock.DateAdded = TestData;

            Assert.AreEqual(AnStock.DateAdded, TestData);
        }

        [TestMethod]
        public void ItemId() //primary key
        {
            clsStock AnStock = new clsStock();
            Int32 TestData = 1;

            AnStock.IdNum = TestData;

            Assert.AreEqual(AnStock.IdNum, TestData);
        }

        [TestMethod]
        public void ItemQTY()
        {
            clsStock AnStock = new clsStock();
            Int32 TestData = 1;

            AnStock.ItemQty = TestData;

            Assert.AreEqual(AnStock.ItemQty, TestData);
        }

        [TestMethod]
        public void ItemTag()
        {
            clsStock AnStock = new clsStock();
            String TestData = "Movie";

            AnStock.ItemTag = TestData;

            Assert.AreEqual(AnStock.ItemTag, TestData);
        }

        [TestMethod]
        public void ItemDesc()
        {
            clsStock AnStock = new clsStock();
            String TestData = "This is a movie based item";

            AnStock.ItemDesc = TestData;

            Assert.AreEqual(AnStock.ItemDesc, TestData);
        }
    }
}
