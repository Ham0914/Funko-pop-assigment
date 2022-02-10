using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //test to see that it exists 
            Assert.IsNotNull(aStaff);
        }
    }
}
