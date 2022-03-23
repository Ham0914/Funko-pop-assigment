using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStaff ThisStaff { get; set; }

        //constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process 
            while (Index < RecordCount)
            {
                //create a blank staff member
                clsStaff aStaff = new clsStaff();
                //read in the fields from the current record
                aStaff.staffID = Convert.ToInt32(DB.DataTable.Rows[Index]["staffID"]);
                aStaff.staffEmail = Convert.ToString(DB.DataTable.Rows[Index]["staffEmail"]);
                aStaff.staffName = Convert.ToString(DB.DataTable.Rows[Index]["staffName"]);
                aStaff.department = Convert.ToString(DB.DataTable.Rows[Index]["department"]);
                aStaff.HireDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["hireDate"]);
                aStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                //add the record to the private data member
                mStaffList.Add(aStaff);
                //point at the next record
                Index++;
            }
        }
    }
}