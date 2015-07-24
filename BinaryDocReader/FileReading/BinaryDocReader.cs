using FuchsiaSoft.BinaryWordDocReader.FileReading.Internals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FuchsiaSoft.BinaryWordDocReader.FileReading
{
    public class BinaryDocReader : BinaryDocReaderBase
    {
        public BinaryDocReader() { }

        public BinaryDocReader(ReaderSettings readerSettings)
        {
            Settings = readerSettings;
        }

        protected override string ReadFromStream(Stream fileStream)
        {
            CheckSettings();

            //TODO:this--- https://msdn.microsoft.com/en-us/library/office/gg615596(v=office.14).aspx
            // and this--- https://msdn.microsoft.com/en-us/library/office/dd772895(v=office.14).aspx
            // and this--- https://msdn.microsoft.com/en-us/library/office/dd952676(v=office.14).aspx
            throw new NotImplementedException();

            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                //Read the FibRgFcLcb97.fcClx field at byte 268, 
                //and the FibRgFcLcb97.lcbClx field at byte 272. 
                //These specify the offset location and size of the Clx.
                reader.BaseStream.Seek(268, SeekOrigin.Begin);
                int fcClx = reader.ReadInt32();
                int lcbClx = reader.ReadInt32();

                //Begin reading the Clx structure from the Table stream, 
                //at the offset specified by the FibRgFcLcb97.fcClx field.
                //Inside the Clxstructure, locate the Pcdt, which immediately 
                //follows the variable-length .RgPrc array of Prc structures
                //For each member of the array:
                //a) Read the .clxt attribute, which is byte 0 of the Prc structure. 
                //If .clxt = 0x02, you have found the Pcdt.
                //b) If .clxt = 0x01, read the next 2 bytes as a signed integer, 
                //and then skip ahead that number of bytes to the next member of the array.
                reader.BaseStream.Seek(fcClx, SeekOrigin.Begin);
                bool foundPcdt = false;
                do
                {
                    byte clxt = reader.ReadByte();
                    if (clxt == 0x01)
                    {
                        reader.ReadBytes(reader.ReadUInt16());
                    }
                } while (!foundPcdt);

                //Inside the Pcdtstructure, locate the PlcPcd structure, 
                //which starts at byte 5 of the Pcdt.
                reader.BaseStream.Seek(5, SeekOrigin.Current);

            }


        }

        private void CheckSettings()
        {
            if (this.Settings == null)
            {
                Settings = ReaderSettings.Default;
            }
        }

    }
}
