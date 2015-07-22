using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuchsiaSoft.FileReading;

namespace FuchsiaSoft.Tests
{
    [TestClass()]
    public class BinaryDocReaderTests
    {
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void InvalidFilePathTest()
        {
            IBinaryDocReader reader = new BinaryDocReader();
            reader.ReadContent("Not a valid file path");
        }
    }
}
