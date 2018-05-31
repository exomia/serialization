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
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>boolean array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool[] ReadArrayBoolean(ref byte[] bytes, int offset, out int byteSize)
        {
            fixed (byte* src = bytes)
            {
                return ReadArrayBoolean(src, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a bool value of the byte array from the given offset
        /// </summary>
        /// <param name="src">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>bool array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool[] ReadArrayBoolean(byte* src, int offset, out int byteSize)
        {
            int length = ReadInt32(src, offset);
            bool[] buffer = new bool[length];
            fixed (bool* dst = buffer)
            {
                MemCpy(dst, src + offset + 4, length);
            }
            byteSize = length;
            return buffer;
        }

        /// <summary>
        ///     reads a float value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>float array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float[] ReadArraySingle(ref byte[] bytes, int offset, out int byteSize)
        {
            fixed (byte* src = bytes)
            {
                return ReadArraySingle(src, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a float value of the byte array from the given offset
        /// </summary>
        /// <param name="src">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>float array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float[] ReadArraySingle(byte* src, int offset, out int byteSize)
        {
            int length = ReadInt32(src, offset);
            float[] buffer = new float[length];
            fixed (float* dst = buffer)
            {
                MemCpy(dst, src + offset + 4, length * 4);
            }
            byteSize = length * 4;
            return buffer;
        }

        /// <summary>
        ///     reads a double value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>double array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double[] ReadArrayReal(ref byte[] bytes, int offset, out int byteSize)
        {
            fixed (byte* src = bytes)
            {
                return ReadArrayReal(src, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a double value of the byte array from the given offset
        /// </summary>
        /// <param name="src">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>double array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double[] ReadArrayReal(byte* src, int offset, out int byteSize)
        {
            int length = ReadInt32(src, offset);
            double[] buffer = new double[length];
            fixed (double* dst = buffer)
            {
                MemCpy(dst, src + offset + 4, length * 8);
            }
            byteSize = length * 8;
            return buffer;
        }

        /// <summary>
        ///     reads a short value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>short array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short[] ReadArrayInt16(ref byte[] bytes, int offset, out int byteSize)
        {
            fixed (byte* src = bytes)
            {
                return ReadArrayInt16(src, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a short value of the byte array from the given offset
        /// </summary>
        /// <param name="src">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>short array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short[] ReadArrayInt16(byte* src, int offset, out int byteSize)
        {
            int length = ReadInt32(src, offset);
            short[] buffer = new short[length];
            fixed (short* dst = buffer)
            {
                MemCpy(dst, src + offset + 4, length * 2);
            }
            byteSize = length * 2;
            return buffer;
        }

        /// <summary>
        ///     reads a ushort value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>ushort array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort[] ReadArrayUInt16(ref byte[] bytes, int offset, out int byteSize)
        {
            fixed (byte* src = bytes)
            {
                return ReadArrayUInt16(src, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a ushort value of the byte array from the given offset
        /// </summary>
        /// <param name="src">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>ushort array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort[] ReadArrayUInt16(byte* src, int offset, out int byteSize)
        {
            int length = ReadInt32(src, offset);
            ushort[] buffer = new ushort[length];
            fixed (ushort* dst = buffer)
            {
                MemCpy(dst, src + offset + 4, length * 2);
            }
            byteSize = length * 2;
            return buffer;
        }

        /// <summary>
        ///     reads a int value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>int array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int[] ReadArrayInt32(ref byte[] bytes, int offset, out int byteSize)
        {
            fixed (byte* src = bytes)
            {
                return ReadArrayInt32(src, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a int value of the byte array from the given offset
        /// </summary>
        /// <param name="src">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>int array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int[] ReadArrayInt32(byte* src, int offset, out int byteSize)
        {
            int length = ReadInt32(src, offset);
            int[] buffer = new int[length];
            fixed (int* dst = buffer)
            {
                MemCpy(dst, src + offset + 4, length * 4);
            }
            byteSize = length * 4;
            return buffer;
        }

        /// <summary>
        ///     reads a uint value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>uint array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint[] ReadArrayUInt32(ref byte[] bytes, int offset, out int byteSize)
        {
            fixed (byte* src = bytes)
            {
                return ReadArrayUInt32(src, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a uint value of the byte array from the given offset
        /// </summary>
        /// <param name="src">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>uint array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint[] ReadArrayUInt32(byte* src, int offset, out int byteSize)
        {
            int length = ReadInt32(src, offset);
            uint[] buffer = new uint[length];
            fixed (uint* dst = buffer)
            {
                MemCpy(dst, src + offset + 4, length * 4);
            }
            byteSize = length * 4;
            return buffer;
        }

        /// <summary>
        ///     reads a long value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>long array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long[] ReadArrayInt64(ref byte[] bytes, int offset, out int byteSize)
        {
            fixed (byte* src = bytes)
            {
                return ReadArrayInt64(src, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a long value of the byte array from the given offset
        /// </summary>
        /// <param name="src">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>uint array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long[] ReadArrayInt64(byte* src, int offset, out int byteSize)
        {
            int length = ReadInt32(src, offset);
            long[] buffer = new long[length];
            fixed (long* dst = buffer)
            {
                MemCpy(dst, src + offset + 4, length * 8);
            }
            byteSize = length * 8;
            return buffer;
        }

        /// <summary>
        ///     reads a ulong value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>ulong array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong[] ReadArrayUInt64(ref byte[] bytes, int offset, out int byteSize)
        {
            fixed (byte* src = bytes)
            {
                return ReadArrayUInt64(src, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a ulong value of the byte array from the given offset
        /// </summary>
        /// <param name="src">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>ulong array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong[] ReadArrayUInt64(byte* src, int offset, out int byteSize)
        {
            int length = ReadInt32(src, offset);
            ulong[] buffer = new ulong[length];
            fixed (ulong* dst = buffer)
            {
                MemCpy(dst, src + offset + 4, length * 8);
            }
            byteSize = length * 8;
            return buffer;
        }

        /// <summary>
        ///     reads a char value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>char array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char[] ReadArrayChar(ref byte[] bytes, int offset, out int byteSize)
        {
            fixed (byte* src = bytes)
            {
                return ReadArrayChar(src, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a char value of the byte array from the given offset
        /// </summary>
        /// <param name="src">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>char array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char[] ReadArrayChar(byte* src, int offset, out int byteSize)
        {
            int length = ReadInt32(src, offset);
            char[] buffer = new char[length];
            fixed (char* dst = buffer)
            {
                MemCpy(dst, src + offset + 4, length * 2);
            }
            byteSize = length * 2;
            return buffer;
        }

        /// <summary>
        ///     reads a string value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>string array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string[] ReadArrayString(ref byte[] bytes, int offset, out int byteSize)
        {
            int length = ReadInt32(ref bytes, offset);
            int startOffset = offset;
            offset += 4;
            string[] buffer = new string[length];
            for (int i = 0; i < length; i++)
            {
                buffer[i] = ReadString(ref bytes, offset, out int bs);
                offset += bs;
            }
            byteSize = offset - startOffset;
            return buffer;
        }

        /// <summary>
        ///     reads a decimal value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>decimal array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal[] ReadArrayDecimal(ref byte[] bytes, int offset, out int byteSize)
        {
            fixed (byte* src = bytes)
            {
                return ReadArrayDecimal(src, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a decimal value of the byte array from the given offset
        /// </summary>
        /// <param name="src">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>decimal array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal[] ReadArrayDecimal(byte* src, int offset, out int byteSize)
        {
            int length = ReadInt32(src, offset);
            decimal[] buffer = new decimal[length];
            fixed (decimal* dst = buffer)
            {
                MemCpy(dst, src + offset + 4, length * 16);
            }
            byteSize = length * 16;
            return buffer;
        }

        /// <summary>
        ///     reads a Guid value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>Guid array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid[] ReadArrayGuid(ref byte[] bytes, int offset, out int byteSize)
        {
            fixed (byte* src = bytes)
            {
                return ReadArrayGuid(src, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a Guid value of the byte array from the given offset
        /// </summary>
        /// <param name="src">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>Guid array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid[] ReadArrayGuid(byte* src, int offset, out int byteSize)
        {
            int length = ReadInt32(src, offset);
            Guid[] buffer = new Guid[length];
            fixed (Guid* dst = buffer)
            {
                MemCpy(dst, src + offset + 4, length * 16);
            }
            byteSize = length * 16;
            return buffer;
        }

        /// <summary>
        ///     reads a Guid value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>Guid array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TimeSpan[] ReadArrayTimeSpan(ref byte[] bytes, int offset, out int byteSize)
        {
            fixed (byte* src = bytes)
            {
                return ReadArrayTimeSpan(src, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a TimeSpan value of the byte array from the given offset
        /// </summary>
        /// <param name="src">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>TimeSpan array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TimeSpan[] ReadArrayTimeSpan(byte* src, int offset, out int byteSize)
        {
            int length = ReadInt32(src, offset);
            TimeSpan[] buffer = new TimeSpan[length];
            fixed (TimeSpan* dst = buffer)
            {
                MemCpy(dst, src + offset + 4, length * 8);
            }
            byteSize = length * 8;
            return buffer;
        }

        /// <summary>
        ///     reads a Guid value of the byte array from the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>Guid array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime[] ReadArrayDateTime(ref byte[] bytes, int offset, out int byteSize)
        {
            fixed (byte* src = bytes)
            {
                return ReadArrayDateTime(src, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a DateTime value of the byte array from the given offset
        /// </summary>
        /// <param name="src">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>DateTime array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime[] ReadArrayDateTime(byte* src, int offset, out int byteSize)
        {
            int length = ReadInt32(src, offset);
            DateTime[] buffer = new DateTime[length];
            fixed (DateTime* dst = buffer)
            {
                MemCpy(dst, src + offset + 4, length * 8);
            }
            byteSize = length * 8;
            return buffer;
        }

        #endregion
    }
}