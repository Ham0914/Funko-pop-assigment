 using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the staff ID property
        private Int32 mStaffID;
        public Int32 staffID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the property
                mStaffID = value;
            }
        }

        //private data member for active
        private Boolean mActive;
        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //HireDate private member variable 
        private DateTime mHireDate;
        //HireDate public property
        public DateTime HireDate
        {
            get
            {
                //return the private data
                return mHireDate;
            }
            set
            {
                //set the private data
                mHireDate = value;
            }
        }

        //private data member for staff email
        private string mStaffEmail;
        //public data member for staff email
        public string staffEmail
        {
            get
            {
                //return the private data
                return mStaffEmail;
            }
            set
            {
                //set the private data
                mStaffEmail = value;
            }
        }

        //private data member for staff name
        private string mStaffName;
        //public data member for staff name
        public string staffName
        {
            get
            {
                //return the private data
                return mStaffName;
            }
            set
            {
                //set the private data
                mStaffName = value;
            }
        }

        //private data for department
        private string mDepartment;
        //public data member for department
        public string department
        {
            get
            {
                //return the private data
                return mDepartment;
            }
            set
            {
                //set the private data
                mDepartment = value;
            }
        }
        
        public bool Find(int staffID)
        {
            //create am instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Stadd ID to search for
            DB.AddParameter("@staffID", staffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found (there should either be one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["staffID"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["staffEmail"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["staffName"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["department"]);
                mHireDate = Convert.ToDateTime(DB.DataTable.Rows[0]["hireDate"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false, indicating a problem
                return false;
            }
        }
    }
}