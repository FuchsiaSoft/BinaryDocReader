using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FuchsiaSoft.FileReading
{
    class BinaryDocReader : BinaryDocReaderBase
    {
        protected override string ReadFromStream(Stream fileStream)
        {
            //TODO:this--- https://msdn.microsoft.com/en-us/library/office/gg615596(v=office.14).aspx
            // and this--- https://msdn.microsoft.com/en-us/library/office/dd772895(v=office.14).aspx
            // and this--- https://msdn.microsoft.com/en-us/library/office/dd952676(v=office.14).aspx
            throw new NotImplementedException();
        }
    }
}
