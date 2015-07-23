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
                return ReadFromStream(stream);
            }
        }

        public virtual string ReadContent(string filePath)
        {
            using (Stream stream = new FileStream(filePath, FileMode.Open))
            {
                return ReadFromStream(stream);
            }
        }

        public virtual string ReadContent(Stream fileStream)
        {
            return ReadFromStream(fileStream);
        }


        protected abstract string ReadFromStream(Stream fileStream);
    }
}
