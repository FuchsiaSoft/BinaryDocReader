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
        public void BitTooHighTest()
        {
            byte thisByte = 123;
            thisByte.IsBitSet(8);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BitTooLowTest()
        {
            byte thisByte = 123;
            thisByte.IsBitSet(-1);
        }

        //TODO: do some actual checks on this to make sure it's
        //picking up flags right etc.

        [TestMethod]
        public void CheckBitFlagsTest()
        {
            // test byte is:
            // dec: 214
            // hex: 0xD6

            // position: 76543210
            // bin:      11010110
            //

            byte thisByte = 214;

            //bits 7,6,4,2,1 should be set
            //bits 5,3,0     should be not set

            Assert.IsTrue(thisByte.IsBitSet(7));
            Assert.IsTrue(thisByte.IsBitSet(6));
            Assert.IsTrue(thisByte.IsBitSet(4));
            Assert.IsTrue(thisByte.IsBitSet(2));
            Assert.IsTrue(thisByte.IsBitSet(1));

            Assert.IsFalse(thisByte.IsBitSet(5));
            Assert.IsFalse(thisByte.IsBitSet(3));
            Assert.IsFalse(thisByte.IsBitSet(0));
        }

        [TestMethod]
        public void CheckNibbleExtractTest()
        {
            // test byte is:
            // dec: 214
            // nibble1: 0110 or 6
            // nibble2: 1011 or 11

            byte thisByte = 214;
            //TODO: finish this
        }

    }
}
