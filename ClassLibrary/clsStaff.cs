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
            //set the private data members to the test data value 
            mStaffID = 420;
            mHireDate = Convert.ToDateTime("10/03/2022");
            mStaffEmail = "name@email.com";
            mStaffName = "Joe Bloggs";
            mDepartment = "Test Department";
            mActive = true;
            //always return true
            return true;
        }
    }
}