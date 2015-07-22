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
    internal class FileInformationBlock
    {
        private byte[] _Data;

        private FileInformationBlock() { }

        public FileInformationBlockBase FibBase { get; private set; }

        public static FileInformationBlock Read(Stream fileStream)
        {
            FileInformationBlock fib = new FileInformationBlock();
            fib.FibBase = FileInformationBlockBase.Read(fileStream);

            return fib;
        }
    }
}
