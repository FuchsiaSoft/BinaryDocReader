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

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, of 
        /// the SttbfGlsy at offset fcSttbfGlsy in the Table Stream. 
        /// If base.fGlsy of the Fib that contains this FibRgFcLcb97 
        /// is zero, this value MUST be zero.
        /// </summary>
        public UInt32 lcbSttbfGlsy { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table 
        /// Stream. A PlcfGlsy that contains information about the 
        /// AutoText items that are defined in this document begins at 
        /// this offset.
        /// </summary>
        public UInt32 fcPlcfGlsy { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, of 
        /// the PlcfGlsy at offset fcPlcfGlsy in the Table Stream. 
        /// If base.fGlsy of the Fib that contains this FibRgFcLcb97 
        /// is zero, this value MUST be zero.
        /// </summary>
        public UInt32 lcbPlcfGlsy { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the offset in the 
        /// Table Stream where a Plcfhdd begins. The Plcfhdd specifies 
        /// the locations of each block of header/footer text in the 
        /// WordDocument Stream. If lcbPlcfHdd is 0, fcPlcfHdd is 
        /// undefined and MUST be ignored.
        /// </summary>
        public UInt32 fcPlcfHdd { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, of 
        /// the Plcfhdd at offset fcPlcfHdd in the Table Stream. 
        /// If there is no Plcfhdd, this value MUST be zero. A Plcfhdd 
        /// MUST exist if FibRgLw97.ccpHdd indicates that there are 
        /// characters in the Header Document (that is, if FibRgLw97.ccpHdd 
        /// is greater than 0). Otherwise, the Plcfhdd MUST NOT exist.
        /// </summary>
        public UInt32 lcbPlcfHdd { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table Stream. 
        /// A PlcBteChpx begins at the offset. fcPlcfBteChpx MUST be greater 
        /// than zero, and MUST be a valid offset in the Table Stream.
        /// </summary>
        public UInt32 fcPlcfBteChpx { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, of the 
        /// PlcBteChpx at offset fcPlcfBteChpx in the Table Stream. 
        /// lcbPlcfBteChpx MUST be greater than zero.
        /// </summary>
        public UInt32 lcbPlcfBteChpx { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table 
        /// Stream. A PlcBtePapx begins at the offset. fcPlcfBtePapx 
        /// MUST be greater than zero, and MUST be a valid offset in 
        /// the Table Stream.
        /// </summary>
        public UInt32 fcPlcfBtePapx { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, 
        /// of the PlcBtePapx at offset fcPlcfBtePapx in the Table 
        /// Stream. lcbPlcfBteChpx MUST be greater than zero.
        /// </summary>
        public UInt32 lcbPlcfBtePapx { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table 
        /// Stream. An SttbfFfn begins at this offset. This table 
        /// specifies the fonts that are used in the document. If 
        /// lcbSttbfFfn is 0, fcSttbfFfn is undefined and MUST be ignored.
        /// </summary>
        public UInt32 fcSttbfFfn { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, 
        /// of the SttbfFfn at offset fcSttbfFfn in the Table Stream.
        /// </summary>
        public UInt32 lcbSttbfFfn { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the 
        /// Table Stream. A PlcFld begins at this offset and specifies 
        /// the locations of field characters in the Main Document. 
        /// All CPs in this PlcFld MUST be greater than or equal to 0 
        /// and less than or equal to FibRgLw97.ccpText. If lcbPlcfFldMom 
        /// is zero, fcPlcfFldMom is undefined and MUST be ignored.
        /// </summary>
        public UInt32 fcPlcfFldMom { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, 
        /// of the PlcFld at offset fcPlcfFldMom in the Table Stream.
        /// </summary>
        public UInt32 lcbPlcfFldMom { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table Stream. 
        /// A PlcFld begins at this offset and specifies the locations 
        /// of field characters in the Header Document. All CPs in this 
        /// PlcFld are relative to the starting position of the Header 
        /// Document. All CPs in this PlcFld MUST be greater than or 
        /// equal to zero and less than or equal to FibRgLw97.ccpHdd. 
        /// If lcbPlcfFldHdr is zero, fcPlcfFldHdr is undefined 
        /// and MUST be ignored.
        /// </summary>
        public UInt32 fcPlcfFldHdr { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, of 
        /// the PlcFld at offset fcPlcfFldHdr in the Table Stream.
        /// </summary>
        public UInt32 lcbPlcfFldHdr { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table Stream. 
        /// A PlcFld begins at this offset and specifies the locations of 
        /// field characters in the Footnote Document. All CPs in this PlcFld 
        /// are relative to the starting position of the Footnote Document. 
        /// All CPs in this PlcFld MUST be greater than or equal to zero and 
        /// less than or equal to FibRgLw97.ccpFtn. If lcbPlcfFldFtn is zero, 
        /// fcPlcfFldFtn is undefined, and MUST be ignored.
        /// </summary>
        public UInt32 fcPlcfFldFtn { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, 
        /// of the PlcFld at offset fcPlcfFldFtn in the Table Stream.
        /// </summary>
        public UInt32 lcbPlcfFldFtn { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table Stream. 
        /// A PlcFld begins at this offset and specifies the locations of 
        /// field characters in the Comment Document. All CPs in this 
        /// PlcFld are relative to the starting position of the Comment 
        /// Document. All CPs in this PlcFld MUST be greater than or 
        /// equal to zero and less than or equal to FibRgLw97.ccpAtn. 
        /// If lcbPlcfFldAtn is zero, fcPlcfFldAtn is undefined and MUST
        /// be ignored.
        /// </summary>
        public UInt32 fcPlcfFldAtn { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, of 
        /// the PlcFld at offset fcPlcfFldAtn in the Table Stream.
        /// </summary>
        public UInt32 lcbPlcfFldAtn { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the Table 
        /// Stream. An SttbfBkmk that contains the names of the 
        /// bookmarks (1) in the document begins at this offset. If 
        /// lcbSttbfBkmk is zero, fcSttbfBkmk is undefined and MUST 
        /// be ignored.
        /// This SttbfBkmk is parallel to the PlcfBkf at offset 
        /// fcPlcfBkf in the Table Stream. Each string specifies 
        /// the name of the bookmark (1) that is associated with 
        /// the data element which is located at the same offset 
        /// in that PlcfBkf. For this reason, the SttbfBkmk that 
        /// begins at offset fcSttbfBkmk, and the PlcfBkf that 
        /// begins at offset fcPlcfBkf, MUST contain the same number 
        /// of elements.
        /// </summary>
        public UInt32 fcSttbfBkmk { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, 
        /// of the SttbfBkmk at offset fcSttbfBkmk.
        /// </summary>
        public UInt32 lcbSttbfBkmk { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the 
        /// Table Stream. A PlcfBkf that contains information about 
        /// the standard bookmarks (1) in the document begins 
        /// at this offset. If lcbPlcfBkf is zero, fcPlcfBkf is 
        /// undefined and MUST be ignored.
        /// Each data element in the PlcfBkf is associated, in 
        /// a one-to-one correlation, with a data element in the 
        /// PlcfBkl at offset fcPlcfBkl. For this reason, the PlcfBkf 
        /// that begins at offset fcPlcfBkf, and the PlcfBkl that 
        /// begins at offset fcPlcfBkl, MUST contain the same number 
        /// of data elements. This PlcfBkf is parallel to the SttbfBkmk 
        /// at offset fcSttbfBkmk in the Table Stream. Each data element 
        /// in the PlcfBkf specifies information about the 
        /// bookmark (1) that is associated with the element which is 
        /// located at the same offset in that SttbfBkmk. For this 
        /// reason, the PlcfBkf that begins at offset fcPlcfBkf, 
        /// and the SttbfBkmk that begins at offset fcSttbfBkmk, 
        /// MUST contain the same number of elements.
        /// The largest value that a CP marking the start or end 
        /// of a standard bookmark (1) is allowed to have is the 
        /// CP representing the end of all document parts.
        /// </summary>
        public UInt32 fcPlcfBkf { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, 
        /// of the PlcfBkf at offset fcPlcfBkf.
        /// </summary>
        public UInt32 lcbPlcfBkf { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the 
        /// Table Stream. A PlcfBkl that contains information 
        /// about the standard bookmarks (1) in the document begins
        /// at this offset. If lcbPlcfBkl is zero, fcPlcfBkl 
        /// is undefined and MUST be ignored.
        /// Each data element in the PlcfBkl is associated, 
        /// in a one-to-one correlation, with a data element 
        /// in the PlcfBkf at offset fcPlcfBkf. For this reason, 
        /// the PlcfBkl that begins at offset fcPlcfBkl, and the 
        /// PlcfBkf that begins at offset fcPlcfBkf, MUST contain 
        /// the same number of data elements.
        /// The largest value that a CP marking the start or end 
        /// of a standard bookmark (1) is allowed to have is the 
        /// value of the CP representing the end of all document 
        /// parts.
        /// </summary>
        public UInt32 fcPlcfBkl { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, 
        /// in bytes, of the PlcfBkl at offset fcPlcfBkl.
        /// </summary>
        public UInt32 lcbPlcfBkl { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the offset 
        /// in the Table Stream of a Tcg that specifies 
        /// command-related customizations. If lcbCmds is 
        /// zero, fcCmds is undefined and MUST be ignored.
        /// </summary>
        public UInt32 fcCmds { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, 
        /// in bytes, of the Tcg at offset fcCmds.
        /// </summary>
        public UInt32 lcbCmds { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset 
        /// in the Table Stream. The PrDrvr, which contains 
        /// printer driver information (the names of drivers, 
        /// port, and so on), begins at this offset. If 
        /// lcbPrDrvr is zero, fcPrDrvr is undefined and 
        /// MUST be ignored.
        /// </summary>
        public UInt32 fcPrDrvr { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, 
        /// in bytes, of the PrDrvr at offset fcPrDrvr.
        /// </summary>
        public UInt32 lcbPrDrvr { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies an offset in the 
        /// Table Stream. The PrEnvPort that is the print 
        /// environment in portrait mode begins at this offset. 
        /// If lcbPrEnvPort is zero, fcPrEnvPort is undefined 
        /// and MUST be ignored.
        /// </summary>
        public UInt32 fcPrEnvPort { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, 
        /// of the PrEnvPort at offset fcPrEnvPort.
        /// </summary>
        public UInt32 lcbPrEnvPort { get; private set; }

        protected void ReadFibRgFcLcb97(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
