using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace CustomerTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerCollectionOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.FirstName = "Lara";
            TestItem.LastName = "Croft";
            TestItem.Email = "LCroft@Gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("14/02/1992");
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Active = true;
            TestCustomer.CustomerId = 1;
            TestCustomer.FirstName = "Lara";
            TestCustomer.LastName = "Croft";
            TestCustomer.Email = "LCroft@Gmail.com";
            TestCustomer.DateOfBirth = Convert.ToDateTime("14/02/1992");
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.FirstName = "Lara";
            TestItem.LastName = "Croft";
            TestItem.Email = "LCroft@Gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("14/02/1992");
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.FirstName = "Lara";
            TestItem.LastName = "Croft";
            TestItem.Email = "LCroft@Gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("14/02/1992");
            // set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            // set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdatemETHODoK()
        {
            //Create and instance of the class we want to creat
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.FirstName = "Lara";
            TestItem.LastName = "Croft";
            TestItem.Email = "LCroft@Gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("14/02/1992");
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.FirstName = "Sarah";
            TestItem.LastName = "Shoft";
            TestItem.Email = "SShoft@Gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("15/02/1992");
            //set the record based on the new data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
    }
}
