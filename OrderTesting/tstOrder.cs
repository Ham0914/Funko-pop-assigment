using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        //create some test data to pass to the method
        string OrderNo = "2";
        string FunkoName = "Shazam";
        string Price = "10";
        string DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Available, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }
        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }
        public void FunkoNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Hulk";
            //assign the data to the property
            AnOrder.FunkoName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.FunkoName, TestData);
        }
        [TestMethod]
        public void FunkoNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.FunkoNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.FunkoNo, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            double TestData = 9.99;
            //assign the data to the property
            AnOrder.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Price, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 FunkoNo = 1;
            //invoke the method 
            Found = AnOrder.Find(FunkoNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FunkoNo = 1;
            //invoke the method
            Found = AnOrder.Find(FunkoNo);
            //check the address no
            if (AnOrder.OrderNo != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FunkoNo = 1;
            //invoke the method
            Found = AnOrder.Find(FunkoNo);
            //check the property
            if (AnOrder.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FunkoNo = 1;
            //invoke the method
            Found = AnOrder.Find(FunkoNo);
            //check the property
            if (AnOrder.DateAdded != Convert.ToDateTime("01/01/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFunkoNoFound()
        {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //boolean variable to store the result of the search
        Boolean Found = false;
        //create some test data to use with the method
        Boolean OK = true;
        //create some test data to use with the method
        Int32 FunkoNo = 1;
        //invoke the method
        Found = AnOrder.Find(FunkoNo);
            //check the address no
            if (AnOrder.FunkoNo != 1)
            {
                OK = false;
            }
    //test to see that the result is correct
    Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFunkoNameFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FunkoNo = 1;
            //invoke the method
            Found = AnOrder.Find(FunkoNo);
            //check the property
            if (AnOrder.FunkoName != "Hulk")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FunkoNo = 1;
            //invoke the method
            Found = AnOrder.Find(FunkoNo);
            //check the address no
            if (AnOrder.Price != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, FunkoName, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FunkoNameMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string FunkoName = "";
            Error = AnOrder.Valid(FunkoName, Price, DateAdded, OrderNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FunkoNameMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FunkoName = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FunkoNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FunkoName = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FunkoNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FunkoName = "01234567890123456789012345678"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FunkoNameMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FunkoName = "012345678901234567890123456789"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FunkoNameMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FunkoName = "012345678901234"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FunkoNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FunkoName = "0123456789012345678901234567890"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void FunkoNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FunkoName = ""; //this should fail
            FunkoName = FunkoName.PadRight(200, 'a');
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Price = "";
            Error = AnOrder.Valid(FunkoName, Price, DateAdded, OrderNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "1"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "2"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "999999998"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "999999999"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Price = "1000000000"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string Price = "this is not a price!";
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string OrderNo = "0";
            Error = AnOrder.Valid(FunkoName, Price, DateAdded, OrderNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "1";
            //create some test data to pass to the method
            string OrderNo = "1"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "2"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "999999998"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "999999999"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string OrderNo = "1000000000"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string OrderNo = "this is not an Order Number!";
            //invoke the method
            Error = AnOrder.Valid(Price, OrderNo, FunkoName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}
