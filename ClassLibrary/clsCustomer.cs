using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Boolean mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        private DateTime mDateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }

        //private data member for the CustomerId property
        private Int32 mCustomerId;
        public int CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }

        private string mFirstName;
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        private string mLastName;
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }

        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }


        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramter for the customer ID to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stord procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if the recod is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //coppy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string firstName, string lastName, string email, string dateOfBirth)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary varible to stor date values
            DateTime DateTemp;
            //if the firstName is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The first name my not be blank: ";
            }
            //if the firstName is greater than 50 characters
            if (firstName.Length > 50)
            {
                Error = Error + "The first name must not be more than 50 characters";
            }
            //if the lastName is blank
            if (lastName.Length == 0)
            {
                //record the error
                Error = Error + "The last name my not be blank: ";
            }
            //if the lastName is greater than 50 characters
            if (lastName.Length > 50)
            {
                Error = Error + "The last name must not be more than 50 characters";
            }
            //if the email is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email my not be blank: ";
            }
            //if the email is greater than 50 characters
            if (email.Length > 50)
            {
                Error = Error + "The email must not be more than 50 characters";
            }
            //if the LastName is blank
            try
            {
                //check to see if the date is older than 100 years
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record the error
                    Error = Error + "The date cannot be more then 100 years the past: ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The dtae was not a valid date: ";
            }
            //return any error messages
            return Error;
        } 
    }
}
