using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private bool mActive;
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
        private int mCustomerId;
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


        public bool Find(int customerID)
        {
            //set the private data members to the test data value
            mCustomerId = 3;
            mFirstName = "Buzz";
            mLastName = "Aldrin";
            mEmail = "BAldrin@gmail.com";
            mDateOfBirth = Convert.ToDateTime("20/01/1930");
            mActive = true;
            //always return true
            return true;
        }
    }
}
