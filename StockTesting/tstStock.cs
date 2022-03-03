using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock {

        string itemQT = "100";
        string TagItem = "Movie";
        string descItem = " some desc";
        string DateAdded = DateTime.Now.Date.ToString();

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
            Int32 itemID = 1;

            Found = AnStock.Find(itemID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestitemIDNoFond()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 itemID = 1;

            Found = AnStock.Find(itemID); 

            if (AnStock.IdNum != 1)
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


            Int32 itemID = 1;


            Found = AnStock.Find(itemID);


            if (AnStock.ItemQty != 100)
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

            Int32 itemID = 1;

            Found = AnStock.Find(itemID);

            if (AnStock.ItemTag != "Movie")
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

            Int32 itemID = 1;

            Found = AnStock.Find(itemID);

            if (AnStock.ItemDesc != "Movie funko pop")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {

            clsStock AnStock = new clsStock();

            Boolean Found = false;
   
            Boolean OK = true;

            Int32 itemID = 1; ;

            Found = AnStock.Find(itemID);

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

            Int32 itemID = 1;

            Found = AnStock.Find(itemID);

            if (AnStock.DateAdded != Convert.ToDateTime("25/07/2020"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOk()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            Error = AnStock.Valid(itemQT,descItem,DateAdded,TagItem);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void itemQTYMinLessOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string itemQT = "-1";

            Error = AnStock.Valid(itemQT, descItem, DateAdded, TagItem);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void itemQTYMin()
        {
            clsStock AnStock = new clsStock();

            String Error = "";
            int number = 0;

            string itemQT = number.ToString();

            Error = AnStock.Valid(itemQT, descItem, DateAdded, TagItem);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void itemQTYMinPlusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";
            int number = 1;

            string itemQT = number.ToString();

            Error = AnStock.Valid(itemQT, descItem, DateAdded, TagItem);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void itemQTYInavlidDataType()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            String itemQT = "two";

            Error = AnStock.Valid(itemQT, descItem, DateAdded, TagItem);
            Assert.AreNotEqual(Error, "");
        }

    }
}