using System;
using System.Collections.Generic;

namespace ClassLibrary
{

    public class clsStockCollection
    {

        List<clsStock> mStockList = new List<clsStock>();

        clsStock mThisStock = new clsStock();

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //
            }
        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@itemQTY", mThisStock.ItemQty);
            DB.AddParameter("@inStockItem", mThisStock.InStock);
            DB.AddParameter("@itemTag", mThisStock.ItemTag);
            DB.AddParameter("@itemLastStock", mThisStock.DateAdded);
            DB.AddParameter("@itemDesc", mThisStock.ItemDesc);

            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
                clsDataConnection DB = new clsDataConnection();

                DB.AddParameter("@itemID", mThisStock.IdNum);
                DB.AddParameter("@itemQTY", mThisStock.ItemQty);
                DB.AddParameter("@inStockItem", mThisStock.InStock);
                DB.AddParameter("@itemTag", mThisStock.ItemTag);
                DB.AddParameter("@itemLastStock", mThisStock.DateAdded);
                DB.AddParameter("@itemDesc", mThisStock.ItemDesc);

                DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@itemID", mThisStock.IdNum);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByItemTag(string itemTag)
        {
          clsDataConnection db = new clsDataConnection();

            db.AddParameter("itemTag", itemTag);
            db.Execute("sproc_tblStock_FilterByitemTag");

            PopulateArray(db);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            
            Int32 Count;

            Count = DB.Count;

            mStockList = new List<clsStock>();

            while(Index < Count)
            {
                clsStock AnStock = new clsStock();

                AnStock.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["inStockItem"]);
                AnStock.IdNum = Convert.ToInt32(DB.DataTable.Rows[Index]["itemID"]);
                AnStock.ItemTag = Convert.ToString(DB.DataTable.Rows[Index]["itemTag"]);
                AnStock.ItemDesc = Convert.ToString(DB.DataTable.Rows[Index]["itemDesc"]);
                AnStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["itemLastStock"]);
                AnStock.ItemQty = Convert.ToInt32(DB.DataTable.Rows[Index]["itemQTY"]);

                mStockList.Add(AnStock);

                Index++;
            }
        }
    }
}