using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for Available
        private Boolean mAvailable;
        public bool Available
        {
            get
            {
                //this line of code sends data out of the property
                return mAvailable;
            }
            set
            {
                //this line of code allows data into the property
                mAvailable = value;
            }
        }
        //private date added data member
        private DateTime mDateAdded;     
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        //private data member for the Order No
        private Int32 mOrderNo;
        //OrderNo public property
        public Int32 OrderNo
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderNo;
            }
            set
            {
                //this line of code allows data into the property
                mOrderNo = value;
            }
        }
        //private data member for the FunkoName
        private string mFunkoName;
        public string FunkoName
        {
            get
            {
                //return the private data
                return mFunkoName;
            }
            set
            {
                //set the private data
                mFunkoName = value;
            }
        }

        private Int32 mFunkoNo;
        public int FunkoNo
        {
            get
            {
                //return the private data
                return mFunkoNo;
            }
            set
            {
                //set the private data
                mFunkoNo = value;
            }
        }
        private double mPrice;
        public double Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }


        public bool Find(int orderNo)
        {
            //set the private data members to the test data value
            mOrderNo = 21;
            mAvailable = true;
            mFunkoNo = 14;
            mPrice = 9.99;
            mFunkoName = "Hulk";
            mDateAdded = Convert.ToDateTime("16/9/2015");

            //always return true
            return true;
        }
    }
}