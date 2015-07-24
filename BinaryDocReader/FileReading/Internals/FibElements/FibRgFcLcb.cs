using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuchsiaSoft.BinaryWordDocReader.FileReading.Internals.FibElements
{
    /// <summary>
    /// Represents the FibRgFcLcb structure within a Fib.
    /// The FibRgFcLcb structure specifies the file offsets 
    /// and byte counts for various portions of the data 
    /// in the document. The structure of FibRgFcLcb 
    /// depends on the value of nFib
    /// Full details: https://msdn.microsoft.com/en-us/library/office/dd943835(v=office.12).aspx
    /// For the purposes of this reader there is only one
    /// FibRgFcLcb class, and it will have properties for all of
    /// the fields specified in the 97 - 07 formats
    /// </summary>
    internal class FibRgFcLcb : FibRgFcLcb2007
    {


        private FibRgFcLcb(byte[] data)
        {
            ReadFibRgFcLcb97(data);
            if (data.Length > 744) ReadFibRgFcLcb2000(data);
            if (data.Length > 864) ReadFibRgFcLcb2002(data);
            if (data.Length > 1088) ReadFibRgFcLcb2003(data);
            if (data.Length > 1312) ReadFibRgFcLcb2007(data);
        }

        public static FibRgFcLcb Read(byte[] data)
        {
            return new FibRgFcLcb(data);
        }
    }
}
