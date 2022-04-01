using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {

        //good test data
        //create some test data to pass the method
        string staffEmail = "fullname@email.com";
        string staffName = "Joe Bloggs";
        string department = "some department";
        string HireDate = DateTime.Now.Date.ToString();

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
            Int32 staffID = 1;
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
            Int32 staffID = 1;
            //invoke the method
            Found = aStaff.Find(staffID);
            //check the staff ID
            if (aStaff.staffID != 1)
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
            Int32 staffID = 1;
            //invoke the method
            Found = aStaff.Find(staffID);
            //check the hire date
            if (aStaff.HireDate != Convert.ToDateTime("24/01/2022"))
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
            Int32 staffID = 1;
            //invoke the method
            Found = aStaff.Find(staffID);
            //check the property
            if (aStaff.staffEmail != "joebloggs@email.com")
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
            Int32 staffID = 1;
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
            Int32 staffID = 1;
            //invoke the method
            Found = aStaff.Find(staffID);
            //check the property
            if (aStaff.department != "Stock Management")
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
            Int32 staffID = 1;
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffEmail = ""; //this should trigger an error
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffEmail = "a@email.com"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffEmail = "aa@email.com"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffEmail = "aaaaaaaaaaaaaaa@email.com"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffEmail = "aaaaaaaaaaaaaaaa@email.com"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffEmail = "aaa@email.com"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffEmail = "aaaaaaaaaaaaaaaaa@email.com"; //this should fail
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffEmail = "";
            staffEmail = staffEmail.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string HireDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 366 days
            TestDate = TestDate.AddDays(-366);
            //convert the date variable to a string variable
            string HireDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDateMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is one year ago
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string HireDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HireDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 364 days
            TestDate = TestDate.AddDays(-364);
            //convert the date variable to a string variable
            string HireDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HireDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string HireDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDateInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the HireDate to a non date value
            string HireDate = "this is not a date!";
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffName = ""; //this should trigger an error
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffName = "a"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffName = "aa"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffName = "";
            staffName = staffName.PadRight(49, 'a'); //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffName = "";
            staffName = staffName.PadRight(50, 'a'); //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffName = "aaaaaaaaaaaa aaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffName = "";
            staffName = staffName.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string staffName = "";
            staffName = staffName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string department = ""; //this should trigger an error
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string department = "a"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string department = "aa"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string department = "";
            department = department.PadRight(49, 'a'); //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string department = "";
            department = department.PadRight(50, 'a'); //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string department = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string department = "";
            department = department.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string department = "";
            department = department.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = aStaff.Valid(staffEmail, staffName, department, HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}