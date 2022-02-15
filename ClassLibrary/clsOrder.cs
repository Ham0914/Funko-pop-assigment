using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Available { get; set; }
        public DateTime DateAdded { get; set; }
        public int OrderNo { get; set; }
        public string FunkoName { get; set; }
        public int FunkoNo { get; set; }
        public double Price { get; set; }
    }
}