#region MIT License

// Copyright (c) 2018 exomia - Daniel Bätz
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

#endregion

using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exomia.Serialization.Utils
{
    public static unsafe partial class BitUtil
    {
        #region Methods

        /// <summary>
        ///     reads a boolean value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>boolean value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ReadBoolean(ref byte[] bytes, int offset)
        {
            return bytes[offset] != 0;
        }

        /// <summary>
        ///     reads a bool value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>bool value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ReadBoolean(byte* ptr, int offset)
        {
            return *(ptr + offset) != 0;
        }

        /// <summary>
        ///     reads a byte value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>byte value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ReadByte(ref byte[] bytes, int offset)
        {
            return bytes[offset];
        }

        /// <summary>
        ///     reads a byte value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>byte value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ReadByte(byte* ptr, int offset)
        {
            return *(ptr + offset);
        }

        /// <summary>
        ///     reads a sbyte value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>sbyte value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ReadSByte(ref byte[] bytes, int offset)
        {
            return (sbyte)bytes[offset];
        }

        /// <summary>
        ///     reads a sbyte value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>sbyte value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ReadSByte(byte* ptr, int offset)
        {
            return (sbyte)*(ptr + offset);
        }

        /// <summary>
        ///     reads a byte array of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="count">bytes to read</param>
        /// <returns>byte array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] ReadBytes(ref byte[] bytes, int offset, int count)
        {
            byte[] buffer = new byte[count];
            Buffer.BlockCopy(bytes, offset, buffer, 0, count);
            return buffer;
        }

        /// <summary>
        ///     reads a float value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>float value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ReadSingle(ref byte[] bytes, int offset)
        {
            //float align
            if (offset % 4 == 0)
            {
                fixed (byte* ptr = bytes)
                {
                    return *(float*)(ptr + offset);
                }
            }
            uint num = (uint)(
                bytes[offset] |
                (bytes[offset + 1] << 8) |
                (bytes[offset + 2] << 16) |
                (bytes[offset + 3] << 24));
            return *(float*)&num;
        }

        /// <summary>
        ///     reads a float value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>float value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ReadSingle(byte* ptr, int offset)
        {
            if (offset % 4 == 0)
            {
                return *(float*)(ptr + offset);
            }
            uint num = (uint)(
                *(ptr + offset) |
                (*(ptr + offset + 1) << 8) |
                (*(ptr + offset + 2) << 16) |
                (*(ptr + offset + 3) << 24));
            return *(float*)&num;
        }

        /// <summary>
        ///     reads a double value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>double value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ReadReal(ref byte[] bytes, int offset)
        {
            //double align
            if (offset % 8 == 0)
            {
                fixed (byte* ptr = bytes)
                {
                    return *(double*)(ptr + offset);
                }
            }
            uint num = (uint)(
                bytes[offset] |
                (bytes[offset + 1] << 8) |
                (bytes[offset + 2] << 16) |
                (bytes[offset + 3] << 24));
            ulong num2 = ((ulong)(
                              bytes[offset + 4] |
                              (bytes[offset + 5] << 8) |
                              (bytes[offset + 6] << 16) |
                              (bytes[offset + 7] << 24)) << 32) |
                         num;
            return *(double*)&num2;
        }

        /// <summary>
        ///     reads a double value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <returns>double value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ReadReal(byte* ptr, int offset)
        {
            //double align
            if (offset % 8 == 0)
            {
                return *(double*)(ptr + offset);
            }
            uint num = (uint)(
                *(ptr + offset) |
                (*(ptr + offset + 1) << 8) |
                (*(ptr + offset + 2) << 16) |
                (*(ptr + offset + 3) << 24));
            ulong num2 = ((ulong)(
                              *(ptr + offset + 4) |
                              (*(ptr + offset + 5) << 8) |
                              (*(ptr + offset + 6) << 16) |
                              (*(ptr + offset + 7) << 24)) << 32) |
                         num;
            return *(double*)&num2;
        }

        /// <summary>
        ///     reads a short value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>short value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ReadInt16(ref byte[] bytes, int offset)
        {
            fixed (byte* ptr = bytes)
            {
                return *(short*)(ptr + offset);
            }
        }

        /// <summary>
        ///     reads a short value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>short value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ReadInt16(byte* ptr, int offset)
        {
            return *(short*)(ptr + offset);
        }

        /// <summary>
        ///     reads a ushort value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>ushort value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ReadUInt16(ref byte[] bytes, int offset)
        {
            fixed (byte* ptr = bytes)
            {
                return *(ushort*)(ptr + offset);
            }
        }

        /// <summary>
        ///     reads a ushort value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>ushort value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ReadUInt16(byte* ptr, int offset)
        {
            return *(ushort*)(ptr + offset);
        }

        /// <summary>
        ///     reads a int value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>int value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ReadInt32(ref byte[] bytes, int offset)
        {
            fixed (byte* ptr = bytes)
            {
                return *(int*)(ptr + offset);
            }
        }

        /// <summary>
        ///     reads a int value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>int value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ReadInt32(byte* ptr, int offset)
        {
            return *(int*)(ptr + offset);
        }

        /// <summary>
        ///     reads a uint value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>uint value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ReadUInt32(ref byte[] bytes, int offset)
        {
            fixed (byte* ptr = bytes)
            {
                return *(uint*)(ptr + offset);
            }
        }

        /// <summary>
        ///     reads a uint value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>uint value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ReadUInt32(byte* ptr, int offset)
        {
            return *(uint*)(ptr + offset);
        }

        /// <summary>
        ///     reads a long value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>long value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ReadInt64(ref byte[] bytes, int offset)
        {
            fixed (byte* ptr = bytes)
            {
                return *(long*)(ptr + offset);
            }
        }

        /// <summary>
        ///     reads a long value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>uint value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ReadInt64(byte* ptr, int offset)
        {
            return *(long*)(ptr + offset);
        }

        /// <summary>
        ///     reads a ulong value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>ulong value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ReadUInt64(ref byte[] bytes, int offset)
        {
            fixed (byte* ptr = bytes)
            {
                return *(ulong*)(ptr + offset);
            }
        }

        /// <summary>
        ///     reads a ulong value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>ulong value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ReadUInt64(byte* ptr, int offset)
        {
            return *(ulong*)(ptr + offset);
        }

        /// <summary>
        ///     reads a char value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>char value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ReadChar(ref byte[] bytes, int offset)
        {
            fixed (byte* ptr = bytes)
            {
                return (char)*(ushort*)(ptr + offset);
            }
        }

        /// <summary>
        ///     reads a char value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>char value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ReadChar(byte* ptr, int offset)
        {
            return (char)*(ushort*)(ptr + offset);
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>string value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(ref byte[] bytes, int offset)
        {
            int count = ReadUInt16(ref bytes, offset);
            return count > 0 ? s_Encoding.GetString(bytes, offset + 2, count) : null;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="encoding">specify the encoding to use</param>
        /// <returns>string value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(ref byte[] bytes, int offset, Encoding encoding)
        {
            int count = ReadUInt16(ref bytes, offset);
            return count > 0 ? encoding.GetString(bytes, offset + 2, count) : null;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof string in bytes</param>
        /// <returns>string value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(ref byte[] bytes, int offset, out int byteSize)
        {
            int count = ReadUInt16(ref bytes, offset);
            byteSize = 2 + count;
            return count > 0 ? s_Encoding.GetString(bytes, offset + 2, count) : null;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="encoding">specify the encoding to use</param>
        /// <param name="byteSize">out sizeof string in bytes</param>
        /// <returns>string value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(ref byte[] bytes, int offset, Encoding encoding, out int byteSize)
        {
            int count = ReadUInt16(ref bytes, offset);
            byteSize = 2 + count;
            return count > 0 ? encoding.GetString(bytes, offset + 2, count) : null;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset
        ///     unicode string only!
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>string value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(byte* ptr, int offset)
        {
            int count = ReadUInt16(ptr, offset);
            return count > 0 ? new string((sbyte*)(ptr + offset + 2), 0, count, Encoding.Unicode) : null;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset
        ///     unicode string only!
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof string in bytes</param>
        /// <returns>string value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(byte* ptr, int offset, out int byteSize)
        {
            int count = ReadUInt16(ptr, offset);
            byteSize = 2 + count;
            return count > 0 ? new string((sbyte*)(ptr + offset + 2), 0, count, Encoding.Unicode) : null;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset
        ///     unicode string only!
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="encoding">specify the encoding to use</param>
        /// <returns>string value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(byte* ptr, int offset, Encoding encoding)
        {
            int count = ReadUInt16(ptr, offset);
            return count > 0 ? new string((sbyte*)(ptr + offset + 2), 0, count, encoding) : null;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset
        ///     unicode string only!
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="encoding">specify the encoding to use</param>
        /// <param name="byteSize">out sizeof string in bytes</param>
        /// <returns>string value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(byte* ptr, int offset, Encoding encoding, out int byteSize)
        {
            int count = ReadUInt16(ptr, offset);
            byteSize = 2 + count;
            return count > 0 ? new string((sbyte*)(ptr + offset + 2), 0, count, encoding) : null;
        }

        /// <summary>
        ///     reads a decimal value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>decimal value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ReadDecimal(ref byte[] bytes, int offset)
        {
            fixed (byte* ptr = bytes)
            {
                return *(decimal*)(ptr + offset);
            }
        }

        /// <summary>
        ///     reads a decimal value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>decimal value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ReadDecimal(byte* ptr, int offset)
        {
            return *(decimal*)(ptr + offset);
        }

        /// <summary>
        ///     reads a Guid value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>Guid value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuid(ref byte[] bytes, int offset)
        {
            fixed (byte* ptr = bytes)
            {
                return *(Guid*)(ptr + offset);
            }
        }

        /// <summary>
        ///     reads a Guid value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>Guid value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuid(byte* ptr, int offset)
        {
            return *(Guid*)(ptr + offset);
        }

        /// <summary>
        ///     reads a Guid value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>Guid value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TimeSpan ReadTimeSpan(ref byte[] bytes, int offset)
        {
            fixed (byte* ptr = bytes)
            {
                return TimeSpan.FromTicks(*(long*)(ptr + offset));
            }
        }

        /// <summary>
        ///     reads a TimeSpan value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>TimeSpan value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TimeSpan ReadTimeSpan(byte* ptr, int offset)
        {
            return *(TimeSpan*)(ptr + offset);
        }

        /// <summary>
        ///     reads a Guid value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>Guid value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ReadDateTime(ref byte[] bytes, int offset)
        {
            fixed (byte* ptr = bytes)
            {
                return DateTime.FromBinary(*(long*)(ptr + offset));
            }
        }

        /// <summary>
        ///     reads a DateTime value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <returns>DateTime value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ReadDateTime(byte* ptr, int offset)
        {
            return *(DateTime*)(ptr + offset);
        }

        #endregion
    }
}