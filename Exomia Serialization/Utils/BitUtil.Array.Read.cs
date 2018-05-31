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
            fixed (byte* ptr = bytes)
            {
                return ReadArrayBoolean(ptr, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a bool value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>bool array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool[] ReadArrayBoolean(byte* ptr, int offset, out int byteSize)
        {
            int lenght = ReadInt32(ptr, offset);
            offset += 4;

            bool[] buffer = new bool[lenght];

            for (int i = 0; i < lenght; i++)
            {
                buffer[i] = ReadBoolean(ptr, offset + i * 1);
            }

            byteSize = lenght * 1;

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
            fixed (byte* ptr = bytes)
            {
                return ReadArraySingle(ptr, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a float value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>float array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float[] ReadArraySingle(byte* ptr, int offset, out int byteSize)
        {
            int lenght = ReadInt32(ptr, offset);
            offset += 4;

            float[] buffer = new float[lenght];

            for (int i = 0; i < lenght; i++)
            {
                buffer[i] = ReadSingle(ptr, offset + i * 4);
            }

            byteSize = lenght * 4;

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
            fixed (byte* ptr = bytes)
            {
                return ReadArrayReal(ptr, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a double value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>double array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double[] ReadArrayReal(byte* ptr, int offset, out int byteSize)
        {
            int lenght = ReadInt32(ptr, offset);
            offset += 4;

            double[] buffer = new double[lenght];

            for (int i = 0; i < lenght; i++)
            {
                buffer[i] = ReadReal(ptr, offset + i * 8);
            }

            byteSize = lenght * 8;

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
            fixed (byte* ptr = bytes)
            {
                return ReadArrayInt16(ptr, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a short value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>short array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short[] ReadArrayInt16(byte* ptr, int offset, out int byteSize)
        {
            int lenght = ReadInt32(ptr, offset);
            offset += 4;

            short[] buffer = new short[lenght];

            for (int i = 0; i < lenght; i++)
            {
                buffer[i] = ReadInt16(ptr, offset + i * 2);
            }

            byteSize = lenght * 2;

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
            fixed (byte* ptr = bytes)
            {
                return ReadArrayUInt16(ptr, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a ushort value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>ushort array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort[] ReadArrayUInt16(byte* ptr, int offset, out int byteSize)
        {
            int lenght = ReadInt32(ptr, offset);
            offset += 4;

            ushort[] buffer = new ushort[lenght];

            for (int i = 0; i < lenght; i++)
            {
                buffer[i] = ReadUInt16(ptr, offset + i * 2);
            }

            byteSize = lenght * 2;

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
            fixed (byte* ptr = bytes)
            {
                return ReadArrayInt32(ptr, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a int value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>int array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int[] ReadArrayInt32(byte* ptr, int offset, out int byteSize)
        {
            int lenght = ReadInt32(ptr, offset);
            offset += 4;

            int[] buffer = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                buffer[i] = ReadInt32(ptr, offset + i * 4);
            }

            byteSize = lenght * 4;

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
            fixed (byte* ptr = bytes)
            {
                return ReadArrayUInt32(ptr, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a uint value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>uint array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint[] ReadArrayUInt32(byte* ptr, int offset, out int byteSize)
        {
            int lenght = ReadInt32(ptr, offset);
            offset += 4;

            uint[] buffer = new uint[lenght];

            for (int i = 0; i < lenght; i++)
            {
                buffer[i] = ReadUInt32(ptr, offset + i * 4);
            }

            byteSize = lenght * 4;

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
            fixed (byte* ptr = bytes)
            {
                return ReadArrayInt64(ptr, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a long value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>uint array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long[] ReadArrayInt64(byte* ptr, int offset, out int byteSize)
        {
            int lenght = ReadInt32(ptr, offset);
            offset += 4;

            long[] buffer = new long[lenght];

            for (int i = 0; i < lenght; i++)
            {
                buffer[i] = ReadInt64(ptr, offset + i * 8);
            }

            byteSize = lenght * 8;

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
            fixed (byte* ptr = bytes)
            {
                return ReadArrayUInt64(ptr, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a ulong value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>ulong array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong[] ReadArrayUInt64(byte* ptr, int offset, out int byteSize)
        {
            int lenght = ReadInt32(ptr, offset);
            offset += 4;

            ulong[] buffer = new ulong[lenght];

            for (int i = 0; i < lenght; i++)
            {
                buffer[i] = ReadUInt64(ptr, offset + i * 8);
            }

            byteSize = lenght * 8;

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
            fixed (byte* ptr = bytes)
            {
                return ReadArrayChar(ptr, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a char value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>char array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char[] ReadArrayChar(byte* ptr, int offset, out int byteSize)
        {
            int lenght = ReadInt32(ptr, offset);
            offset += 4;

            char[] buffer = new char[lenght];

            for (int i = 0; i < lenght; i++)
            {
                buffer[i] = ReadChar(ptr, offset + i * 2);
            }

            byteSize = lenght * 2;

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
            int lenght = ReadInt32(ref bytes, offset);

            int startOffset = offset;

            offset += 4;

            string[] buffer = new string[lenght];

            for (int i = 0; i < lenght; i++)
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
            fixed (byte* ptr = bytes)
            {
                return ReadArrayDecimal(ptr, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a decimal value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>decimal array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal[] ReadArrayDecimal(byte* ptr, int offset, out int byteSize)
        {
            int lenght = ReadInt32(ptr, offset);
            offset += 4;

            decimal[] buffer = new decimal[lenght];

            for (int i = 0; i < lenght; i++)
            {
                buffer[i] = ReadDecimal(ptr, offset + i * 16);
            }

            byteSize = lenght * 16;

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
            fixed (byte* ptr = bytes)
            {
                return ReadArrayGuid(ptr, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a Guid value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>Guid array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid[] ReadArrayGuid(byte* ptr, int offset, out int byteSize)
        {
            int lenght = ReadInt32(ptr, offset);
            offset += 4;

            Guid[] buffer = new Guid[lenght];

            for (int i = 0; i < lenght; i++)
            {
                buffer[i] = ReadGuid(ptr, offset + i * 16);
            }

            byteSize = lenght * 16;

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
            fixed (byte* ptr = bytes)
            {
                return ReadArrayTimeSpan(ptr, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a TimeSpan value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>TimeSpan array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TimeSpan[] ReadArrayTimeSpan(byte* ptr, int offset, out int byteSize)
        {
            int lenght = ReadInt32(ptr, offset);
            offset += 4;

            TimeSpan[] buffer = new TimeSpan[lenght];

            for (int i = 0; i < lenght; i++)
            {
                buffer[i] = ReadTimeSpan(ptr, offset + i * 8);
            }

            byteSize = lenght * 8;

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
            fixed (byte* ptr = bytes)
            {
                return ReadArrayDateTime(ptr, offset, out byteSize);
            }
        }

        /// <summary>
        ///     reads a DateTime value of the byte array from the given offset
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="byteSize">out sizeof array in bytes</param>
        /// <returns>DateTime array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime[] ReadArrayDateTime(byte* ptr, int offset, out int byteSize)
        {
            int lenght = ReadInt32(ptr, offset);
            offset += 4;

            DateTime[] buffer = new DateTime[lenght];

            for (int i = 0; i < lenght; i++)
            {
                buffer[i] = ReadDateTime(ptr, offset + i * 8);
            }

            byteSize = lenght * 8;

            return buffer;
        }

        #endregion
    }
}