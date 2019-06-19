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
    /// <content>
    ///     A bit utility.
    /// </content>
    public static unsafe partial class BitUtil
    {
        /// <summary>
        ///     reads a boolean value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     boolean value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ReadBoolean(ref byte[] bytes, int offset)
        {
            return bytes[offset] != 0;
        }

        /// <summary>
        ///     reads a bool value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     bool value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ReadBoolean(byte* src, int offset)
        {
            return *(bool*)(src + offset);
        }

        /// <summary>
        ///     reads a byte value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     byte value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ReadByte(ref byte[] bytes, int offset)
        {
            return bytes[offset];
        }

        /// <summary>
        ///     reads a byte value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     byte value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ReadByte(byte* src, int offset)
        {
            return *(src + offset);
        }

        /// <summary>
        ///     reads a sbyte value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     sbyte value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ReadSByte(ref byte[] bytes, int offset)
        {
            return (sbyte)bytes[offset];
        }

        /// <summary>
        ///     reads a sbyte value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     sbyte value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ReadSByte(byte* src, int offset)
        {
            return (sbyte)*(src + offset);
        }

        /// <summary>
        ///     reads a byte array of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="count">  bytes to read. </param>
        /// <returns>
        ///     byte array.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] ReadBytes(ref byte[] bytes, int offset, int count)
        {
            byte[] buffer = new byte[count];
            Buffer.BlockCopy(bytes, offset, buffer, 0, count);
            return buffer;
        }

        /// <summary>
        ///     reads a float value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     float value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ReadSingle(ref byte[] bytes, int offset)
        {
            //float align
            if (offset % 4 == 0)
            {
                fixed (byte* src = bytes)
                {
                    return *(float*)(src + offset);
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
        ///     reads a float value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     float value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ReadSingle(byte* src, int offset)
        {
            if (offset % 4 == 0)
            {
                return *(float*)(src + offset);
            }
            uint num = (uint)(
                *(src + offset) |
                (*(src + offset + 1) << 8) |
                (*(src + offset + 2) << 16) |
                (*(src + offset + 3) << 24));
            return *(float*)&num;
        }

        /// <summary>
        ///     reads a double value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     double value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ReadReal(ref byte[] bytes, int offset)
        {
            //double align
            if (offset % 8 == 0)
            {
                fixed (byte* src = bytes)
                {
                    return *(double*)(src + offset);
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
        ///     reads a double value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     double value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ReadReal(byte* src, int offset)
        {
            //double align
            if (offset % 8 == 0)
            {
                return *(double*)(src + offset);
            }
            uint num = (uint)(
                *(src + offset) |
                (*(src + offset + 1) << 8) |
                (*(src + offset + 2) << 16) |
                (*(src + offset + 3) << 24));
            ulong num2 = ((ulong)(
                              *(src + offset + 4) |
                              (*(src + offset + 5) << 8) |
                              (*(src + offset + 6) << 16) |
                              (*(src + offset + 7) << 24)) << 32) |
                         num;
            return *(double*)&num2;
        }

        /// <summary>
        ///     reads a short value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     short value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ReadInt16(ref byte[] bytes, int offset)
        {
            fixed (byte* src = bytes)
            {
                return *(short*)(src + offset);
            }
        }

        /// <summary>
        ///     reads a short value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     short value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ReadInt16(byte* src, int offset)
        {
            return *(short*)(src + offset);
        }

        /// <summary>
        ///     reads a ushort value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     ushort value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ReadUInt16(ref byte[] bytes, int offset)
        {
            fixed (byte* src = bytes)
            {
                return *(ushort*)(src + offset);
            }
        }

        /// <summary>
        ///     reads a ushort value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     ushort value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ReadUInt16(byte* src, int offset)
        {
            return *(ushort*)(src + offset);
        }

        /// <summary>
        ///     reads a int value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     int value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ReadInt32(ref byte[] bytes, int offset)
        {
            fixed (byte* src = bytes)
            {
                return *(int*)(src + offset);
            }
        }

        /// <summary>
        ///     reads a int value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     int value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ReadInt32(byte* src, int offset)
        {
            return *(int*)(src + offset);
        }

        /// <summary>
        ///     reads a uint value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     uint value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ReadUInt32(ref byte[] bytes, int offset)
        {
            fixed (byte* src = bytes)
            {
                return *(uint*)(src + offset);
            }
        }

        /// <summary>
        ///     reads a uint value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     uint value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ReadUInt32(byte* src, int offset)
        {
            return *(uint*)(src + offset);
        }

        /// <summary>
        ///     reads a long value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     long value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ReadInt64(ref byte[] bytes, int offset)
        {
            fixed (byte* src = bytes)
            {
                return *(long*)(src + offset);
            }
        }

        /// <summary>
        ///     reads a long value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     uint value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ReadInt64(byte* src, int offset)
        {
            return *(long*)(src + offset);
        }

        /// <summary>
        ///     reads a ulong value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     ulong value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ReadUInt64(ref byte[] bytes, int offset)
        {
            fixed (byte* src = bytes)
            {
                return *(ulong*)(src + offset);
            }
        }

        /// <summary>
        ///     reads a ulong value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     ulong value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ReadUInt64(byte* src, int offset)
        {
            return *(ulong*)(src + offset);
        }

        /// <summary>
        ///     reads a char value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     char value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ReadChar(ref byte[] bytes, int offset)
        {
            fixed (byte* src = bytes)
            {
                return (char)*(ushort*)(src + offset);
            }
        }

        /// <summary>
        ///     reads a char value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     char value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ReadChar(byte* src, int offset)
        {
            return (char)*(ushort*)(src + offset);
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     string value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(ref byte[] bytes, int offset)
        {
            int count = ReadUInt16(ref bytes, offset);
            return count > 0 ? s_encoding.GetString(bytes, offset + 2, count) : null;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="encoding"> specify the encoding to use. </param>
        /// <returns>
        ///     string value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(ref byte[] bytes, int offset, Encoding encoding)
        {
            int count = ReadUInt16(ref bytes, offset);
            return count > 0 ? encoding.GetString(bytes, offset + 2, count) : null;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="byteSize"> [out] out sizeof string in bytes. </param>
        /// <returns>
        ///     string value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(ref byte[] bytes, int offset, out int byteSize)
        {
            int count = ReadUInt16(ref bytes, offset);
            byteSize = 2 + count;
            return count > 0 ? s_encoding.GetString(bytes, offset + 2, count) : null;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="encoding"> specify the encoding to use. </param>
        /// <param name="byteSize"> [out] out sizeof string in bytes. </param>
        /// <returns>
        ///     string value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(ref byte[] bytes, int offset, Encoding encoding, out int byteSize)
        {
            int count = ReadUInt16(ref bytes, offset);
            byteSize = 2 + count;
            return count > 0 ? encoding.GetString(bytes, offset + 2, count) : null;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset unicode string only!
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     string value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(byte* src, int offset)
        {
            int count = ReadUInt16(src, offset);
            return count > 0 ? new string((sbyte*)(src + offset + 2), 0, count, Encoding.Unicode) : null;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset unicode string only!
        /// </summary>
        /// <param name="src">      [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="byteSize"> [out] out sizeof string in bytes. </param>
        /// <returns>
        ///     string value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(byte* src, int offset, out int byteSize)
        {
            int count = ReadUInt16(src, offset);
            byteSize = 2 + count;
            return count > 0 ? new string((sbyte*)(src + offset + 2), 0, count, Encoding.Unicode) : null;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset unicode string only!
        /// </summary>
        /// <param name="src">      [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="encoding"> specify the encoding to use. </param>
        /// <returns>
        ///     string value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(byte* src, int offset, Encoding encoding)
        {
            int count = ReadUInt16(src, offset);
            return count > 0 ? new string((sbyte*)(src + offset + 2), 0, count, encoding) : null;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset unicode string only!
        /// </summary>
        /// <param name="src">      [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="encoding"> specify the encoding to use. </param>
        /// <param name="byteSize"> [out] out sizeof string in bytes. </param>
        /// <returns>
        ///     string value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(byte* src, int offset, Encoding encoding, out int byteSize)
        {
            int count = ReadUInt16(src, offset);
            byteSize = 2 + count;
            return count > 0 ? new string((sbyte*)(src + offset + 2), 0, count, encoding) : null;
        }

        /// <summary>
        ///     reads a decimal value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     decimal value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ReadDecimal(ref byte[] bytes, int offset)
        {
            fixed (byte* src = bytes)
            {
                return *(decimal*)(src + offset);
            }
        }

        /// <summary>
        ///     reads a decimal value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     decimal value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ReadDecimal(byte* src, int offset)
        {
            return *(decimal*)(src + offset);
        }

        /// <summary>
        ///     reads a Guid value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     Guid value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuid(ref byte[] bytes, int offset)
        {
            fixed (byte* src = bytes)
            {
                return *(Guid*)(src + offset);
            }
        }

        /// <summary>
        ///     reads a Guid value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     Guid value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuid(byte* src, int offset)
        {
            return *(Guid*)(src + offset);
        }

        /// <summary>
        ///     reads a Guid value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     Guid value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TimeSpan ReadTimeSpan(ref byte[] bytes, int offset)
        {
            fixed (byte* src = bytes)
            {
                return TimeSpan.FromTicks(*(long*)(src + offset));
            }
        }

        /// <summary>
        ///     reads a TimeSpan value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     TimeSpan value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TimeSpan ReadTimeSpan(byte* src, int offset)
        {
            return *(TimeSpan*)(src + offset);
        }

        /// <summary>
        ///     reads a Guid value of the byte array from the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     Guid value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ReadDateTime(ref byte[] bytes, int offset)
        {
            fixed (byte* src = bytes)
            {
                return DateTime.FromBinary(*(long*)(src + offset));
            }
        }

        /// <summary>
        ///     reads a DateTime value of the byte array from the given offset.
        /// </summary>
        /// <param name="src">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <returns>
        ///     DateTime value.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ReadDateTime(byte* src, int offset)
        {
            return *(DateTime*)(src + offset);
        }
    }
}