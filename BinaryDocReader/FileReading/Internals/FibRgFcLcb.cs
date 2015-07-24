using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuchsiaSoft.BinaryWordDocReader.FileReading.Internals
{
    /// <summary>
    /// Represents the FibRgFcLcb structure within a Fib.
    /// The FibRgFcLcb structure specifies the file offsets 
    /// and byte counts for various portions of the data 
    /// in the document. The structure of FibRgFcLcb 
    /// depends on the value of nFib
    /// Full details: https://msdn.microsoft.com/en-us/library/office/dd943835(v=office.12).aspx
    /// </summary>
    internal abstract class FibRgFcLcb
    {
        //public virtual FibRgFcLcb Read() { }
    }
}
