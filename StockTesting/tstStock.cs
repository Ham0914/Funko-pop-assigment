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


        [TestMethod]

        public void FindMethodOK()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;
            Int32 IdNumber = 21;

            Found = AnStock.Find(IdNumber);
            Assert.IsTrue(Found);
        }

        public void TestIdNumberNoFond()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 IdNumber = 21;

            Found = AnStock.Find(IdNumber); 

            if (AnStock.IdNum != 21)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemQTYFound()
        {

            clsStock AnStock = new clsStock();
    

            Boolean Found = false;

          
            Boolean OK = true;

       
            Int32 ItemQTY = 21;

    
            Found = AnStock.Find(ItemQTY);


            if (AnStock.ItemQty != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemTagFound()
        {
 
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 itemtag = 21;

            Found = AnStock.Find(itemtag);

            if (AnStock.ItemTag != "Test Tag")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemDescFound()
        {

            clsStock AnStock = new clsStock();

            Boolean Found = false;
  
            Boolean OK = true;
 
            Int32 itemDesc = 21;

            Found = AnStock.Find(itemDesc);

            if (AnStock.ItemDesc != "Test Desc")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStock()
        {

            clsStock AnStock = new clsStock();

            Boolean Found = false;
   
            Boolean OK = true;

            Int32 inStock = 21;

            Found = AnStock.Find(inStock);

            if (AnStock.InStock != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
           
            clsStock AnStock = new clsStock();
            Boolean Found = false;

            Boolean OK = true;

            Int32 dateadded = 21;

            Found = AnStock.Find(dateadded);

            if (AnStock.DateAdded != Convert.ToDateTime("25/03/2000"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}