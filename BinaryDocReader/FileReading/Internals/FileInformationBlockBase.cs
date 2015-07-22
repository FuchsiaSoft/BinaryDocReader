using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FuchsiaSoft.BinaryWordDocReader.FileReading.Internals
{
    /// <summary>
    /// Represents the FileInformationBlockBase (FibBase) structure
    /// from within the FileInformationBlock in the document stream.
    /// This is a fixed length (32 byte) structure.
    /// Full details: https://msdn.microsoft.com/en-us/library/office/dd944620(v=office.12).aspx
    /// </summary>
    internal class FileInformationBlockBase
    {
        private byte[] _Data;

        /// <summary>
        /// An unsigned integer that specifies that this is a Word Binary File. 
        /// This value MUST be 0xA5EC.
        /// </summary>
        public UInt16 wIdent { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the version number of the file format 
        /// used. Superseded by FibRgCswNew.nFibNew if it is present. 
        /// This value SHOULD be 0x00C1.
        /// </summary>
        public UInt16 nFib { get; private set; }

        /// <summary>
        /// A LID that specifies the install language of the application that is 
        /// producing the document. If nFib is 0x00D9 or greater, then any East Asian 
        /// install lid or any install lid with a base language of Spanish, German or 
        /// French MUST be recorded as lidAmerican. If the nFib is 0x0101 or greater, 
        /// then any install lid with a base language of Vietnamese, Thai, 
        /// or Hindi MUST be recorded as lidAmerican.
        /// </summary>
        public UInt16 lid { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the offset in the WordDocument 
        /// stream of the FIB for the document which contains all the AutoText 
        /// items. If this value is 0, there are no AutoText items attached. Otherwise 
        /// the FIB is found at file location pnNext×512. If fGlsy is 1 or fDot is 0, 
        /// this value MUST be 0. If pnNext is not 0, each FIB MUST share the same 
        /// values for FibRgFcLcb97.fcPlcBteChpx, FibRgFcLcb97.lcbPlcBteChpx, 
        /// FibRgFcLcb97.fcPlcBtePapx, FibRgFcLcb97.lcbPlcBtePapx, and FibRgLw97.cbMac.
        /// </summary>
        public UInt16 pnNext { get; private set; }

        /// <summary>
        /// Specifies whether this is a document template
        /// </summary>
        public bool fDot { get; private set; }

        /// <summary>
        /// Specifies whether this is a document that contains only AutoText items 
        /// (see FibRgFcLcb97.fcSttbfGlsy, FibRgFcLcb97.fcPlcfGlsy and 
        /// FibRgFcLcb97.fcSttbGlsyStyle).
        /// </summary>
        public bool fGlsy { get; private set; }

        /// <summary>
        /// Specifies that the last save operation that was performed on this 
        /// document was an incremental save operation.
        /// </summary>
        public bool fComplex { get; private set; }

        /// <summary>
        /// An unsigned integer. If nFib is less than 0x00D9, then cQuickSaves 
        /// specifies the number of consecutive times this document was 
        /// incrementally saved. If nFib is 0x00D9 or greater, then cQuickSaves 
        /// MUST be 0xF. 
        /// </summary>
        public UInt16 cQuickSaves { get; private set; }

        /// <summary>
        /// Specifies whether the document is encrypted or obfuscated as 
        /// specified in Encryption and Obfuscation.
        /// </summary>
        public bool fEncrypted { get; private set; }

        /// <summary>
        /// Specifies the Table stream to which the FIB refers. When this value 
        /// is set to 1, use 1Table; when this value is set to 0, use 0Table.
        /// </summary>
        public bool fWhichTblStm { get; private set; }

        /// <summary>
        /// Specifies whether the document author recommended that the document 
        /// be opened in read-only mode.
        /// </summary>
        public bool fReadOnlyRecommended { get; private set; }

        /// <summary>
        /// Specifies whether the document has a write-reservation password.
        /// </summary>
        public bool fWriteReservation { get; private set; }

        /// <summary>
        /// This value MUST be 1.
        /// </summary>
        public bool fExtChar { get; private set; }

        /// <summary>
        /// Specifies whether to override the language information and font that are 
        /// specified in the paragraph style at istd 0 (the normal style) with the 
        /// defaults that are appropriate for the installation 
        /// language of the application.
        /// </summary>
        public bool fLoadOverride { get; private set; }

        /// <summary>
        /// Specifies whether the installation language of the application that 
        /// created the document was an East Asian language.
        /// </summary>
        public bool fFarEast { get; private set; }

        /// <summary>
        /// If fEncrypted is 1, this bit specifies whether the document is 
        /// obfuscated by using XOR obfuscation (section 2.2.6.1); otherwise, 
        /// this bit MUST be ignored.
        /// </summary>
        public bool fObfuscated { get; private set; }

        /// <summary>
        /// This value SHOULD<14> be 0x00BF. This value MUST be 0x00BF or 0x00C1. 
        /// </summary>
        public UInt16 nFibBack { get; private set; }

        /// <summary>
        /// If fEncrypted is 1 and fObfuscation is 1, this value specifies the 
        /// XOR obfuscation (section 2.2.6.1) password verifier. If fEncrypted 
        /// is 1 and fObfuscation is 0, this value specifies the size of the 
        /// EncryptionHeader that is stored at the beginning of the Table stream 
        /// as described in Encryption and Obfuscation. 
        /// Otherwise, this value MUST be 0. 
        /// </summary>
        public UInt32 lKey { get; private set; }

        /// <summary>
        /// Specifies whether to override the section properties for page size, 
        /// orientation, and margins with the defaults that are appropriate for 
        /// the installation language of the application.
        /// </summary>
        public bool fLoadOverridePage { get; private set; }

        private FileInformationBlockBase(Stream fileStream)
        {
            using (BinaryReader binaryReader = new BinaryReader(fileStream))
            {
                //read underlying data first
                binaryReader.BaseStream.Position = 0;
                _Data = binaryReader.ReadBytes(32);

                //then read all the elements
                binaryReader.BaseStream.Position = 0;

                wIdent = binaryReader.ReadUInt16();
                nFib = binaryReader.ReadUInt16();
                binaryReader.ReadBytes(2); //unused segment of FibBase, ignore
                lid = binaryReader.ReadUInt16();
                pnNext = binaryReader.ReadUInt16();

                byte currentByte = binaryReader.ReadByte();

                fDot = currentByte.IsBitSet(0);
                fGlsy = currentByte.IsBitSet(1);
                fComplex = currentByte.IsBitSet(2);
                cQuickSaves = currentByte.GetNibble(4);


                currentByte = binaryReader.ReadByte();

                fEncrypted = currentByte.IsBitSet(0);
                fWhichTblStm = currentByte.IsBitSet(1);
                fReadOnlyRecommended = currentByte.IsBitSet(2);
                fWriteReservation = currentByte.IsBitSet(3);
                fExtChar = currentByte.IsBitSet(4);
                fLoadOverride = currentByte.IsBitSet(5);
                fFarEast = currentByte.IsBitSet(6);
                if (fEncrypted) fObfuscated = currentByte.IsBitSet(7);

                nFibBack = binaryReader.ReadUInt16();
                lKey = binaryReader.ReadUInt32();

                binaryReader.ReadByte(); //unused segment, ignore

                currentByte = binaryReader.ReadByte();
                fLoadOverridePage = currentByte.IsBitSet(2);
            }

            CheckState();
        }

        /// <summary>
        /// Checks the internal state of some of the FibBase fields to
        /// make sure that the document is a valid 03 and prior
        /// Word doc.
        /// </summary>
        private void CheckState()
        {
            string invalidDataString = "The document is not a valid Word Binary File";
            if (wIdent != 0xA5EC || !fExtChar ||
                (nFibBack != 0x00BF && nFibBack != 0x00C1))
            {
                throw new InvalidDataException(invalidDataString);
            }
        }

        /// <summary>
        /// Reads the FibBase structure from the specified document
        /// stream and returns a new FileInformationBlockBase object
        /// representing it.
        /// </summary>
        /// <param name="fileStream">The word document stream</param>
        /// <returns>New FileInformationBlockBase</returns>
        internal static FileInformationBlockBase Read(Stream fileStream)
        {
            return new FileInformationBlockBase(fileStream);
        }
    }
}
