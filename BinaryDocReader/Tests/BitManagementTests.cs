using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuchsiaSoft.BinaryWordDocReader.FileReading.Internals;

namespace FuchsiaSoft.BinaryWordDocReader.Tests
{
    [TestClass()]
    public class BitManagementTests
    {
        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestBitTooHigh()
        {
            byte thisByte = 123;
            thisByte.IsBitSet(8);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBitTooLow()
        {
            byte thisByte = 123;
            thisByte.IsBitSet(-1);
        }

        //TODO: do some actual checks on this to make sure it's
        //picking up flags right etc.
    }
}
