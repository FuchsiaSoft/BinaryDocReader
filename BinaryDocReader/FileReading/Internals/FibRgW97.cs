using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FuchsiaSoft.BinaryWordDocReader.FileReading.Internals
{
    /// <summary>
    /// Represents the FibRgW97 structure
    /// Full details: https://msdn.microsoft.com/en-us/library/office/dd910114(v=office.12).aspx
    /// </summary>
    internal class FibRgW97
    {
        /// <summary>
        /// A LID whose meaning depends on the nFib value,
        /// nFib = 0x00C1: If FibBase.fFarEast is "true", 
        /// this is the LID of the stored style names. Otherwise it MUST be ignored.
        /// nFib = 0x00D9, 0x0101, 0x010C or 0x0112: The LID of the stored 
        /// style names (STD.xstzName)
        /// </summary>
        public UInt16 lidFE { get; private set; }

        private FibRgW97 (byte[] data)
        {
            //most of this structure is ignored
            lidFE = BitConverter.ToUInt16(data, 26);
        }

        public static FibRgW97 Read(byte[] data)
        {
            return new FibRgW97(data);
        }
    }
}
