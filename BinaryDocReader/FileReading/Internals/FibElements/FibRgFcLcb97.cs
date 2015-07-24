using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuchsiaSoft.BinaryWordDocReader.FileReading.Internals.FibElements
{
    internal abstract class FibRgFcLcb97
    {

        /// <summary>
        /// An unsigned integer that specifies an offset in 
        /// the Table Stream. An STSH that specifies the style 
        /// sheet for this document begins at this offset.
        /// </summary>
        public UInt32 fcStshf { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes,
        /// of the STSH that begins at offset fcStshf in the Table 
        /// Stream. This MUST be a nonzero value.
        /// </summary>
        public UInt32 lcbStshf { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table Stream. 
        /// A PlcffndRef begins at this offset and specifies the locations of 
        /// footnote references in the Main Document, and whether those 
        /// references use auto-numbering or custom symbols. If lcbPlcffndRef 
        /// is zero, fcPlcffndRef is undefined and MUST be ignored.
        /// </summary>
        public UInt32 fcPlcffndRef { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, of the 
        /// PlcffndRef that begins at offset fcPlcffndRef in the Table Stream.
        /// </summary>
        public UInt32 lcbPlcffndRef { get; private set; }

        protected void ReadFibRgFcLcb97(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
