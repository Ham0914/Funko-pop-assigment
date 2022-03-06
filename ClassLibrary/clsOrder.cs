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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order number to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mFunkoNo = Convert.ToInt32(DB.DataTable.Rows[0]["FunkoNo"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mFunkoName = Convert.ToString(DB.DataTable.Rows[0]["FunkoName"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                //return that everything worked OK#
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }


            }
        }
    }
