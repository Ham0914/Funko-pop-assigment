using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to Method
        string FirstName = "Adam";
        string LastName = "Kurt";
        string Email = "AKurt@gmail.com";
        string DateOfBirth = DateTime.Now.Date.ToString();

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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnOrder = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "a"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aa"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String FirstName = "";//this should cause an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'a'); //this should pass
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a'); //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a'); //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(200, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String LastName = "";//this should cause an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "a"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aa"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(49, 'a'); //this should pass
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(50, 'a'); //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(25, 'a'); //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Email = "";//this should cause an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "a"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aa"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(49, 'a'); //this should pass
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(50, 'a'); //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(25, 'a'); //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1000 years
            TestDate = TestDate.AddYears(-1000);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years and 1 day
            TestDate = TestDate.AddYears(-100).AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to the minimum
            TestDate = DateTime.Now.Date.AddYears(-100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //set the date to the minimum + 1
            TestDate = DateTime.Now.Date.AddYears(-100).AddDays(1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidDate()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateOfBirth to a non date value
            String DateOfBirth = "this is not a valid date";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}