using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data memeber thisStaff
        clsStaff mThisStaff = new clsStaff();

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

        //public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        //constructor for the class
        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parametres for the stored procedure
            DB.AddParameter("@staffEmail", mThisStaff.staffEmail);
            DB.AddParameter("@staffName", mThisStaff.staffName);
            DB.AddParameter("@department", mThisStaff.department);
            DB.AddParameter("@hireDate", mThisStaff.HireDate);
            DB.AddParameter("@active", mThisStaff.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parametres for the stored procedure
            DB.AddParameter("@staffID", mThisStaff.staffID);
            DB.AddParameter("@staffEmail", mThisStaff.staffEmail);
            DB.AddParameter("@staffName", mThisStaff.staffName);
            DB.AddParameter("@department", mThisStaff.department);
            DB.AddParameter("@hireDate", mThisStaff.HireDate);
            DB.AddParameter("@active", mThisStaff.Active);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@staffID", mThisStaff.staffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByDepartment(string department)
        {
            //filters the records based on their depatment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the department parameter to the database
            DB.AddParameter("@department", department);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByDepartment");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
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