using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FuchsiaSoft.BinaryWordDocReader.FileReading.Internals
{
    /// <summary>
    /// Represents the FileInformationBlock (Fib) structure within
    /// the word document stream.  
    /// Full details: https://msdn.microsoft.com/en-us/library/office/dd949344(v=office.12).aspx
    /// </summary>
    internal class Fib
    {
        /// <summary>
        /// The FileInformationBlockBase (fixed 32 byte structure) for
        /// this FileInformationBlock
        /// </summary>
        public FibBase FibBase { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the count of 16-bit 
        /// values corresponding to fibRgW that follow. MUST be 0x000E.
        /// </summary>
        public UInt16 csw { get; private set; }

        /// <summary>
        /// The FibRgW97.
        /// </summary>
        public FibRgW97 fibRgW { get; private set; }

        /// <summary>
        /// An unsigned integer that specifies the count of 32-bit 
        /// values corresponding to fibRgLw that follow. MUST be 0x0016.
        /// </summary>
        public UInt16 cslw { get; private set; }
        
        private Fib(Stream fileStream)
        {
            FibBase = FibBase.Read(fileStream);
            using (BinaryReader binaryReader = new BinaryReader(fileStream))
            {
                binaryReader.BaseStream.Seek(32, SeekOrigin.Begin);

                csw = binaryReader.ReadUInt16();
                fibRgW = FibRgW97.Read(binaryReader.ReadBytes(28));
                cslw = binaryReader.ReadUInt16();

            }

            CheckState();
        }


        private void CheckState()
        {
            string invalidDataString = "The document is not in expected format";
            if (csw != 0x000E ||
                cslw != 0x0016)
            {
                throw new InvalidDataException(invalidDataString);
            }
        }

        /// <summary>
        /// Reads the Fib from the provided document stream, and 
        /// returns a new Fib object representing it.
        /// </summary>
        /// <param name="fileStream">The entire Word document stream</param>
        /// <returns>New Fib object.</returns>
        public static Fib Read(Stream fileStream)
        {
            return new Fib(fileStream);
        }
    }
}
