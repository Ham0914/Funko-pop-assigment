using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool InStock { get; set; }
        public DateTime DateAdded { get; set; }
        public int IdNum { get; set; }
        public int ItemQty { get; set; }
        public string ItemTag { get; set; }
        public string ItemDesc { get; set; }
    }
}