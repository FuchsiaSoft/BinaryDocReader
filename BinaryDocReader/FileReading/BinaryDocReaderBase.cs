using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FuchsiaSoft.BinaryWordDocReader.FileReading
{
    public abstract class BinaryDocReaderBase : IBinaryDocReader
    {
        public virtual string ReadContent(byte[] fileBytes)
        {
            using (Stream stream = new MemoryStream(fileBytes))
            {
                return ReadFromStream(stream, HeaderOption.Everything);
            }
        }

        public virtual string ReadContent(string filePath)
        {
            using (Stream stream = new FileStream(filePath, FileMode.Open))
            {
                return ReadFromStream(stream, HeaderOption.Everything);
            }
        }

        public virtual string ReadContent(Stream fileStream)
        {
            return ReadFromStream(fileStream, HeaderOption.Everything);
        }

        public string ReadContent (string filePath, HeaderOption headerOption)
        {
            using (Stream stream = new FileStream(filePath, FileMode.Open))
            {
                return ReadFromStream(stream, headerOption);
            }
        }

        public string ReadContent (byte[] fileBytes, HeaderOption headerOption)
        {
            using (Stream stream = new MemoryStream(fileBytes))
            {
                return ReadFromStream(stream, headerOption);
            }
        }

        public string ReadContent (Stream fileStream, HeaderOption headerOption)
        {
            return ReadFromStream(fileStream, headerOption);
        }

        protected abstract string ReadFromStream (Stream fileStream, HeaderOption headerOption);
    }
}
