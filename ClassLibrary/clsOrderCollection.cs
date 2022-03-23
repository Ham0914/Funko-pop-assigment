﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();

        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("FunkoName", mThisOrder.FunkoName);
            DB.AddParameter("Price", mThisOrder.Price);
            DB.AddParameter("DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("Available", mThisOrder.Available);

            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("FunkoName", mThisOrder.FunkoName);
            DB.AddParameter("Price", mThisOrder.Price);
            DB.AddParameter("DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("Available", mThisOrder.Available);
            DB.AddParameter("FunkoNo", mThisOrder.FunkoNo);

            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FunkoNo", mThisOrder.FunkoNo);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByFunkoNo(string FunkoName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FunkoName", FunkoName);
            DB.Execute("sproc_tblOrder_FilterByFunkoNo");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 Count;

            Count = DB.Count;

            mOrderList = new List<clsOrder>();

            while (Index < Count)
            {
                clsOrder AnOrder = new clsOrder();

                AnOrder.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AnOrder.FunkoNo = Convert.ToInt32(DB.DataTable.Rows[Index]["FunkoNo"]);
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnOrder.FunkoName = Convert.ToString(DB.DataTable.Rows[Index]["FunkoName"]);

                mOrderList.Add(AnOrder);

                Index++;
            }
        }


    }
}