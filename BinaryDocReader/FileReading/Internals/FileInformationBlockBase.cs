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

        private FileInformationBlockBase();

        internal static FileInformationBlockBase Read(Stream fileStream)
        {
            FileInformationBlockBase fibBase = new FileInformationBlockBase();

            using (BinaryReader binaryReader = new BinaryReader(fileStream))
            {
                binaryReader.BaseStream.Position = 0;
                fibBase._Data = binaryReader.ReadBytes(32);
            }

            return fibBase;
        }
    }
}
