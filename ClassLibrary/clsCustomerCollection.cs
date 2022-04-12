using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //constructor for the class
        public clsCustomerCollection()
        {
            //object for data collection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the arry list with the data table
            PopulateArray(DB);
        }
        //private data member for CustomerList
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member fo ThisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the private data
                return mCustomerList.Count;
            }
            set
            {
                //not needed for now
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the databse
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("FirstName", mThisCustomer.FirstName);
            DB.AddParameter("LastName", mThisCustomer.LastName);
            DB.AddParameter("Email", mThisCustomer.Email);
            DB.AddParameter("DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("Active", mThisCustomer.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("FirstName", mThisCustomer.FirstName);
            DB.AddParameter("LastName", mThisCustomer.LastName);
            DB.AddParameter("Email", mThisCustomer.Email);
            DB.AddParameter("DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("Active", mThisCustomer.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByFirstName(string FirstName)
        {
            //filters the records based on a full or partial first name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FirstName parameter to the database
            DB.AddParameter("@FirstName", FirstName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByFirstName");
            //populate the array list whith the data table
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
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }
    }
}
