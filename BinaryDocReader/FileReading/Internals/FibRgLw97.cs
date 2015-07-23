using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuchsiaSoft.BinaryWordDocReader.FileReading.Internals
{
    /// <summary>
    /// Represents the FibRgLw97 structure within the
    /// document stream Fib.
    /// Full details: https://msdn.microsoft.com/en-us/library/office/dd922774(v=office.12).aspx
    /// </summary>
    internal class FibRgLw97
    {
        /// <summary>
        /// Specifies the count of bytes of those written to the 
        /// WordDocument stream of the file that have any meaning. 
        /// All bytes in the WordDocument stream at offset cbMac 
        /// and greater MUST be ignored.
        /// </summary>
        public UInt32 cbMac { get; private set; }

        /// <summary>
        /// A signed integer that specifies the count of CPs in 
        /// the main document. This value MUST be zero, 1, or greater.
        /// </summary>
        public Int32 ccpText { get; set; }

        /// <summary>
        /// A signed integer that specifies the count of CPs in the 
        /// footnote subdocument. This value MUST be zero, 1, or greater.
        /// </summary>
        public Int32 ccpFtn { get; private set; }

        /// <summary>
        /// A signed integer that specifies the count of CPs in the 
        /// header subdocument. This value MUST be zero, 1, or greater.
        /// </summary>
        public Int32 ccpHdd { get; private set; }

        /// <summary>
        /// A signed integer that specifies the count of CPs in the 
        /// comment subdocument. This value MUST be zero, 1, or greater.
        /// </summary>
        public Int32 ccpAtn { get; private set; }

        /// <summary>
        /// A signed integer that specifies the count of CPs in the 
        /// endnote subdocument. This value MUST be zero, 1, or greater.
        /// </summary>
        public Int32 ccpEdn { get; private set; }

        /// <summary>
        /// A signed integer that specifies the count of CPs in the 
        /// textbox subdocument of the main document. This value MUST 
        /// be zero, 1, or greater.
        /// </summary>
        public Int32 ccpTxbx { get; private set; }

        /// <summary>
        /// A signed integer that specifies the count of CPs in the 
        /// textbox subdocument of the header. This value MUST be 
        /// zero, 1, or greater.
        /// </summary>
        public Int32 ccpHdrTxbx { get; private set; }

        private FibRgLw97(byte[] data)
        {
            cbMac = BitConverter.ToUInt32(data, 0);
            ccpText = BitConverter.ToInt32(data, 12);
            ccpFtn = BitConverter.ToInt32(data, 16);
            ccpHdd = BitConverter.ToInt32(data, 20);
            ccpAtn = BitConverter.ToInt32(data, 28);
            ccpEdn = BitConverter.ToInt32(data, 32);
            ccpTxbx = BitConverter.ToInt32(data, 36);
            ccpHdrTxbx = BitConverter.ToInt32(data, 40);
        }

        public static FibRgLw97 Read(byte[] data)
        {
            return new FibRgLw97(data);
        }
    }
}
