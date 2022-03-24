using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void ActivePropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Active = TestData;
            //test to seee that the two values are the same
            Assert.AreEqual(AnCustomer.Active, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Elli";
            //Assign the data to the property
            AnCustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Farrow";
            //Assign the data to the property
            AnCustomer.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "ElliFarrow@gmail.com";
            //Assign the data to the property
            AnCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Email, TestData);
        }

        [TestMethod]
        public void FindMethordOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the methord
            Int32 CustomerId = 4;
            //invoke the methord
            Found = AnCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean varible to store the results of the search
            Boolean Found = false;
            //boolean varible to record if the data is ok (assume it is)
            Boolean Ok = true;
            //create some test data to use with the methord
            Int32 CustomerId = 4;
            //invoke the methord
            Found = AnCustomer.Find(CustomerId);
            //check the CoustomerId
            if (AnCustomer.CustomerId != 4)
            {
                Ok = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean varible to store the results of the search
            Boolean Found = false;
            //boolean varible to record if the data is ok (assume it is)
            Boolean Ok = true;
            //create some test data to use with the methord
            Int32 CustomerId = 4;
            //invoke the methord
            Found = AnCustomer.Find(CustomerId);
            //check the property
            if (AnCustomer.FirstName != "Buzz")
            {
                Ok = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean varible to store the results of the search
            Boolean Found = false;
            //boolean varible to record if the data is ok (assume it is)
            Boolean Ok = true;
            //create some test data to use with the methord
            Int32 CustomerId = 4;
            //invoke the methord
            Found = AnCustomer.Find(CustomerId);
            //check the property
            if (AnCustomer.LastName != "Aldrin")
            {
                Ok = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean varible to store the results of the search
            Boolean Found = false;
            //boolean varible to record if the data is ok (assume it is)
            Boolean Ok = true;
            //create some test data to use with the methord
            Int32 CustomerId = 4;
            //invoke the methord
            Found = AnCustomer.Find(CustomerId);
            //check the property
            if (AnCustomer.Email != "BAldrin@gmail.com")
            {
                Ok = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void DateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean varible to store the results of the search
            Boolean Found = false;
            //boolean varible to record if the data is ok (assume it is)
            Boolean Ok = true;
            //create some test data to use with the methord
            Int32 CustomerId = 4;
            //invoke the methord
            Found = AnCustomer.Find(CustomerId);
            //check the property
            if (AnCustomer.DateOfBirth != Convert.ToDateTime("20/01/1930"))
            {
                Ok = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void ActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean varible to store the results of the search
            Boolean Found = false;
            //boolean varible to record if the data is ok (assume it is)
            Boolean Ok = true;
            //create some test data to use with the methord
            Int32 CustomerId = 4;
            //invoke the methord
            Found = AnCustomer.Find(CustomerId);
            //check the property
            if (AnCustomer.Active != true)
            {
                Ok = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(Ok);
        }
    }
}

