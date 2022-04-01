using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.staffID = 1;
            TestItem.staffEmail = "name@email.com";
            TestItem.staffName = "Name";
            TestItem.department = "some department";
            TestItem.HireDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Active = true;
            TestStaff.staffID = 1;
            TestStaff.staffEmail = "name@email.com";
            TestStaff.staffName = "Name";
            TestStaff.department = "some department";
            TestStaff.HireDate = DateTime.Now.Date;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.staffID = 1;
            TestItem.staffEmail = "name@email.com";
            TestItem.staffName = "Name";
            TestItem.department = "some department";
            TestItem.HireDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.staffID = 1;
            TestItem.staffEmail = "name@email.com";
            TestItem.staffName = "Name";
            TestItem.department = "some department";
            TestItem.HireDate = DateTime.Now.Date;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.staffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.staffID = 1;
            TestItem.staffEmail = "someone@email.com";
            TestItem.staffName = "Some Person";
            TestItem.department = "Some Department";
            TestItem.HireDate = DateTime.Now.Date;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.staffID = PrimaryKey;
            //modify the test data
            TestItem.Active = true;
            TestItem.staffID = 2;
            TestItem.staffEmail = "anotherperson@email.com";
            TestItem.staffName = "Another Person";
            TestItem.department = "Another Department";
            TestItem.HireDate = DateTime.Now.Date;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record 
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.staffID = 1;
            TestItem.staffEmail = "someone@email.com";
            TestItem.staffName = "Some Person";
            TestItem.department = "Some Department";
            TestItem.HireDate = DateTime.Now.Date;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.staffID = PrimaryKey;
            //find the record 
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record again
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByDepartmentMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.ReportByDepartment("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByDepartmentNoneFound()
        {
            //create an instance of the class we want to create
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a department that does not exist
            FilteredStaff.ReportByDepartment("xxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByDepartmentTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a department that doesn't exist
            FilteredStaff.ReportByDepartment("Pipes");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first record is ID 34
                if (FilteredStaff.StaffList[0].staffID != 34)
                {
                    OK = false;
                }
                //check that the second record is ID 35
                if (FilteredStaff.StaffList[1].staffID != 35)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
