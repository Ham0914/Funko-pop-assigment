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
    }
}
