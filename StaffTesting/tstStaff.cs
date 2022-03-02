using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //test to see that it exists 
            Assert.IsNotNull(aStaff);
        }

        [TestMethod]
        public void activePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.Active, TestData);
        }

        [TestMethod]
        public void hireDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to asign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aStaff.HireDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.HireDate, TestData);
        }

        [TestMethod]
        public void staffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            aStaff.staffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.staffID, TestData);
        }

        [TestMethod]
        public void staffEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "name@email.com";
            //assign the data to the property
            aStaff.staffEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.staffEmail, TestData);

        }

        [TestMethod]
        public void staffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Joe Bloggs";
            //assign the data to the property
            aStaff.staffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.staffName, TestData);
        }

        [TestMethod]
        public void departmentPopertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "a department";
            //assign the data to the property
            aStaff.department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.department, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 staffID = 420;
            //invoke the method
            Found = aStaff.Find(staffID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 staffID = 420;
            //invoke the method
            Found = aStaff.Find(staffID);
            //check the staff ID
            if (aStaff.staffID != 420)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHireDateFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 staffID = 420;
            //invoke the method
            Found = aStaff.Find(staffID);
            //check the hire date
            if (aStaff.HireDate != Convert.ToDateTime("10/03/2022"))
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 staffID = 420;
            //invoke the method
            Found = aStaff.Find(staffID);
            //check the property
            if (aStaff.staffEmail != "name@email.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 staffID = 420;
            //invoke the method
            Found = aStaff.Find(staffID);
            //check the property
            if (aStaff.staffName != "Joe Bloggs")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDepartmentFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 staffID = 420;
            //invoke the method
            Found = aStaff.Find(staffID);
            //check the property
            if (aStaff.department != "Test Department")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 staffID = 420;
            //invoke the method
            Found = aStaff.Find(staffID);
            //check the property
            if (aStaff.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
