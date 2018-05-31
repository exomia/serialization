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
        ///     writes a boolean array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">boolean array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, bool[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 1, values[i]);
            }

            return 4 + 1 * length;
        }

        /// <summary>
        ///     writes a boolean array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">boolean array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, bool[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 1, values[i]);
            }
        }

        /// <summary>
        ///     writes a boolean array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">boolean array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, bool[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 1, values[i]);
            }
        }

        /// <summary>
        ///     writes a byte array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">byte array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, byte[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 1, values[i]);
            }
        }

        /// <summary>
        ///     writes a sbyte array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">sbyte array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, sbyte[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 1, values[i]);
            }

            return 4 + 1 * length;
        }

        /// <summary>
        ///     writes a sbyte array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">sbyte array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, sbyte[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 1, values[i]);
            }
        }

        /// <summary>
        ///     writes a sbyte array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">sbyte array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, sbyte[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 1, values[i]);
            }
        }

        /// <summary>
        ///     writes a float array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">float array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, float[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 8, values[i]);
            }

            return 4 + 4 * length;
        }

        /// <summary>
        ///     writes a float array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">float array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, float[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 4, values[i]);
            }
        }

        /// <summary>
        ///     writes a float array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">float array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, float[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 4, values[i]);
            }
        }

        /// <summary>
        ///     writes a double array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">double array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, double[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 8, values[i]);
            }

            return 4 + 8 * length;
        }

        /// <summary>
        ///     writes a double array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">double array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, double[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 8, values[i]);
            }
        }

        /// <summary>
        ///     writes a double array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">double array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, double[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 8, values[i]);
            }
        }

        /// <summary>
        ///     writes a short array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">short array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, short[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 2, values[i]);
            }

            return 4 + 2 * length;
        }

        /// <summary>
        ///     writes a short array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">short array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, short[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 2, values[i]);
            }
        }

        /// <summary>
        ///     writes a short array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">short array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, short[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 2, values[i]);
            }
        }

        /// <summary>
        ///     writes a ushort array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">ushort array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, ushort[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 2, values[i]);
            }

            return 4 + 2 * length;
        }

        /// <summary>
        ///     writes a ushort array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">ushort array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, ushort[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 2, values[i]);
            }
        }

        /// <summary>
        ///     writes a ushort array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">ushort array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, ushort[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 2, values[i]);
            }
        }

        /// <summary>
        ///     writes a int array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">int array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, int[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 4, values[i]);
            }

            return 4 + 4 * length;
        }

        /// <summary>
        ///     writes a int array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">int array</param>
        /// MO
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, int[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 4, values[i]);
            }
        }

        /// <summary>
        ///     writes a int array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">int array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, int[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 4, values[i]);
            }
        }

        /// <summary>
        ///     writes a uint array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">uint array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, uint[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 4, values[i]);
            }

            return 4 + 4 * length;
        }

        /// <summary>
        ///     writes a uint array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">uint array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, uint[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 4, values[i]);
            }
        }

        /// <summary>
        ///     writes a uint array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">uint array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, uint[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 4, values[i]);
            }
        }

        /// <summary>
        ///     writes a long array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">long array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, long[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 8, values[i]);
            }

            return 4 + 8 * length;
        }

        /// <summary>
        ///     writes a ulong array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">long array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, long[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 8, values[i]);
            }
        }

        /// <summary>
        ///     writes a long array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">long array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, long[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 8, values[i]);
            }
        }

        /// <summary>
        ///     writes a ulong array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">ulong array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, ulong[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 8, values[i]);
            }

            return 4 + 8 * length;
        }

        /// <summary>
        ///     writes a long array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">ulong array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, ulong[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 8, values[i]);
            }
        }

        /// <summary>
        ///     writes a ulong array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">ulong array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, ulong[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 8, values[i]);
            }
        }

        /// <summary>
        ///     writes a char array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">char array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, char[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 2, values[i]);
            }

            return 4 + 2 * length;
        }

        /// <summary>
        ///     writes a char array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">char array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, char[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 2, values[i]);
            }
        }

        /// <summary>
        ///     writes a char array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">char array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, char[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 2, values[i]);
            }
        }

        /// <summary>
        ///     writes a string array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">string array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, string[] values)
        {
            int length = values.Length;
            Write(ref bytes, offset, values.Length);

            int startOffset = offset;
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                offset += Write(ref bytes, offset, values[i]);
            }

            return offset - startOffset;
        }

        /// <summary>
        ///     writes a string array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">string array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, string[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset, values[i]);
                offset += 2 + s_Encoding.GetMaxByteCount(values[i].Length);
            }
        }

        /// <summary>
        ///     writes a decimal array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">decimal array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, decimal[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 16, values[i]);
            }

            return 4 + 16 * length;
        }

        /// <summary>
        ///     writes a decimal array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">decimal array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, decimal[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 16, values[i]);
            }
        }

        /// <summary>
        ///     writes a decimal array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">decimal array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, decimal[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 16, values[i]);
            }
        }

        /// <summary>
        ///     writes a Guid array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">Guid array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, Guid[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 16, values[i]);
            }

            return 4 + 16 * length;
        }

        /// <summary>
        ///     writes a Guid array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">Guid array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, Guid[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 16, values[i]);
            }
        }

        /// <summary>
        ///     writes a Guid array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">Guid array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, Guid[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 16, values[i]);
            }
        }

        /// <summary>
        ///     writes a TimeSpan array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">TimeSpan array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, TimeSpan[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 8, values[i]);
            }

            return 4 + 8 * length;
        }

        /// <summary>
        ///     writes a TimeSpan array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">TimeSpan array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, TimeSpan[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 8, values[i]);
            }
        }

        /// <summary>
        ///     writes a TimeSpan array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">TimeSpan array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, TimeSpan[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 8, values[i]);
            }
        }

        /// <summary>
        ///     writes a DateTime array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">DateTime array</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, DateTime[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 8, values[i]);
            }

            return 4 + 8 * length;
        }

        /// <summary>
        ///     writes a DateTime array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="values">DateTime array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, DateTime[] values)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset + i * 8, values[i]);
            }
        }

        /// <summary>
        ///     writes a DateTime array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="values">DateTime array</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, DateTime[] values)
        {
            int length = values.Length;
            WriteUnsafe(ptr, offset, values.Length);
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ptr, offset + i * 8, values[i]);
            }
        }

        #endregion
    }
}