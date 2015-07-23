namespace FuchsiaSoft.BinaryWordDocReader.FileReading
{
    /// <summary>
    /// Options for how to read the content of the file
    /// with respect to the body text and header/footers
    /// </summary>
    public enum HeaderOption
    {
        /// <summary>
        /// Read only the document header,
        /// ignoring the document body
        /// </summary>
        HeaderOnly,
        /// <summary>
        /// Read only the document footer, 
        /// ignoring the document body
        /// </summary>
        FooterOnly,
        /// <summary>
        /// Read only the document header and footer, 
        /// ignoring the document body
        /// </summary>
        HeaderAndFooterOnly,
        /// <summary>
        /// Read only the document body, ignoring header and footer
        /// </summary>
        DocumentOnly,
        /// <summary>
        /// Read everything, with header at the beginning,
        /// document body in the middle and footer at the end
        /// </summary>
        Everything
    }
}