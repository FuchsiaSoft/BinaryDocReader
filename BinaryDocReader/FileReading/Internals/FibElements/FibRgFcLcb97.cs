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

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table Stream. 
        /// A PlcffndTxt begins at this offset and specifies the locations of 
        /// each block of footnote text in the Footnote Document. 
        /// If lcbPlcffndTxt is zero, fcPlcffndTxt is undefined and 
        /// MUST be ignored.
        /// </summary>
        public UInt32 fcPlcffndTxt { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, of the 
        /// PlcffndTxt that begins at offset fcPlcffndTxt in the Table Stream.
        /// lcbPlcffndTxt MUST be zero if FibRgLw97.ccpFtn is zero, 
        /// and MUST be nonzero if FibRgLw97.ccpFtn is nonzero.
        /// </summary>
        public UInt32 lcbPlcffndTxt { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table Stream. 
        /// A PlcfandRef begins at this offset and specifies the dates, user 
        /// initials, and locations of comments in the Main Document. If 
        /// lcbPlcfandRef is zero, fcPlcfandRef is undefined and MUST be ignored.
        /// </summary>
        public UInt32 fcPlcfandRef { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, of the 
        /// PlcfandRef at offset fcPlcfandRef in the Table Stream.
        /// </summary>
        public UInt32 lcbPlcfandRef { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table Stream. 
        /// A PlcfandTxt begins at this offset and specifies the locations of 
        /// comment text ranges in the Comment Document. If lcbPlcfandTxt is 
        /// zero, fcPlcfandTxt is undefined, and MUST be ignored.
        /// </summary>
        public UInt32 fcPlcfandTxt { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, of the 
        /// PlcfandTxt at offset fcPlcfandTxt in the Table Stream.
        /// lcbPlcfandTxt MUST be zero if FibRgLw97.ccpAtn is zero, 
        /// and MUST be nonzero if FibRgLw97.ccpAtn is nonzero.
        /// </summary>
        public UInt32 lcbPlcfandTxt { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table Stream. 
        /// A PlcfSed begins at this offset and specifies the locations of 
        /// property lists for each section in the Main Document. If 
        /// lcbPlcfSed is zero, fcPlcfSed is undefined and MUST be ignored.
        /// </summary>
        public UInt32 fcPlcfSed { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, of the 
        /// PlcfSed that begins at offset fcPlcfSed in the Table Stream.
        /// </summary>
        public UInt32 lcbPlcfSed { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table Stream. 
        /// A Plc begins at this offset and specifies version-specific information 
        /// about paragraph height. This Plc SHOULD NOT be emitted and SHOULD
        /// be ignored.
        /// </summary>
        public UInt32 fcPlcfPhe { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, of the Plc 
        /// at offset fcPlcfPhe in the Table Stream. 
        /// </summary>
        public UInt32 lcbPlcfPhe { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table Stream. 
        /// A SttbfGlsy that contains information about the AutoText items that 
        /// are defined in this document begins at this offset.
        /// </summary>
        public UInt32 fcSttbfGlsy { get; private set; }


        protected void ReadFibRgFcLcb97(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
