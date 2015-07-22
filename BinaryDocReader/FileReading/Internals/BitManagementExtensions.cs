using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuchsiaSoft.BinaryWordDocReader.FileReading.Internals
{
    public static class BitManagementExtensions
    {
        /// <summary>
        /// Checks if a particular bit is set for the byte
        /// </summary>
        /// <param name="value">The byte to check</param>
        /// <param name="position">The position of the bit to check</param>
        /// <returns>True if the bit is set</returns>
        public static bool IsBitSet(this byte value, int position)
        {
            if (position > 7 || position < 0)
            {
                throw new ArgumentOutOfRangeException
                    ("Bit position to check must be between 0 and 7");
            }

            return (value & (1 << position)) != 0;
        }

        /// <summary>
        /// Returns a byte of the numeric value for the
        /// nibble at the specified bit position within
        /// the current byte
        /// </summary>
        /// <param name="value">The byte to check</param>
        /// <param name="position">The position of the nibble to retrieve</param>
        /// <returns>Byte of the nibble's value</returns>
        public static byte GetNibble(this byte value, int position)
        {
            if (position > 4 || position < 0)
            {
                throw new ArgumentOutOfRangeException
                    ("Nibble position must be between " +
                     "0 and 4 in the current byte");
            }
                
            return (byte)((value & 0xF0) >> position);
        }
    }
}
