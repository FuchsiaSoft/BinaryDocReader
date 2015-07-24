using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FuchsiaSoft.BinaryWordDocReader.FileReading
{
    /// <summary>
    /// Provides the interface for a binary Word
    /// doc reader that can extract text.
    /// </summary>
    public interface IBinaryDocReader
    {
        /// <summary>
        /// The Settings for the reader implementing
        /// this interface.
        /// </summary>
        ReaderSettings Settings { get; set; }

        /// <summary>
        /// Reads the contents of a Word doc file
        /// and returns a string consisting of the
        /// document body text.
        /// </summary>
        /// <param name="filePath">The path to the file to read</param>
        /// <returns>The contents of the document body</returns>
        string ReadContent(string filePath);

        /// <summary>
        /// Reads the contents of a Word doc file
        /// and returns a string consisting of the
        /// document body text.
        /// </summary>
        /// <param name="fileBytes">The bytes of the file to read</param>
        /// <returns>The contents of the document body</returns>
        string ReadContent(byte[] fileBytes);

        /// <summary>
        /// Reads the contents of a Word doc file
        /// and returns a string consisting of the
        /// document body text.
        /// </summary>
        /// <param name="fileStream">A stream of the file to read</param>
        /// <returns>The contents of the document body</returns>
        string ReadContent(Stream fileStream);

    }
}
