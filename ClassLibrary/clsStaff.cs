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

        public string Valid(string staffEmail, string staffName, string department, string hireDate)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the staffEmail is blank
            if (staffEmail.Length == 0)
            {
                //record the error
                Error = Error + "The staff email may not be blank : ";
            }
            //if the staff email is greater than 26 characters
            if (staffEmail.Length > 26)
            {
                //record the error
                Error = Error + "The staff email must be less than 26 characeters : ";
            }
            try
            {
                //copy the hireDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(hireDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //if the staffName is blank
            if (staffName.Length == 0)
            {
                //record the error
                Error = Error + "The staff name may not be blank : ";
            }
            //if the staff name is greater than 50 characters
            if (staffName.Length > 50)
            {
                //record the error
                Error = Error + "The staff name must be less than 50 characeters : ";
            }
            //if the department is blank
            if (department.Length == 0)
            {
                //record the error
                Error = Error + "The department name may not be blank : ";
            }
            //if the department name is greater than 50 characters
            if (department.Length > 50)
            {
                //record the error
                Error = Error + "The department name must be less than 50 characeters : ";
            }
            //return any error messages
            return Error;
        }
    }
}