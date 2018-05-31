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
        private const byte ZERO = 0;
        private const byte ONE = 1;

        #region Methods

        /// <summary>
        ///     writes a boolean value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">boolean value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, bool value)
        {
            EnsureCapacity(ref bytes, offset, 1);
            bytes[offset] = value ? ONE : ZERO;
            return 1;
        }

        /// <summary>
        ///     writes a boolean value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">boolean value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, bool value)
        {
            bytes[offset] = value ? ONE : ZERO;
        }

        /// <summary>
        ///     writes a boolean value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">boolean value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, bool value)
        {
            *(ptr + offset) = value ? ONE : ZERO;
        }

        /// <summary>
        ///     writes a byte value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">byte value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, byte value)
        {
            EnsureCapacity(ref bytes, offset, 1);
            bytes[offset] = value;
            return 1;
        }

        /// <summary>
        ///     writes a byte value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">byte value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, byte value)
        {
            bytes[offset] = value;
        }

        /// <summary>
        ///     writes a byte value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">byte value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, byte value)
        {
            *(ptr + offset) = value;
        }

        /// <summary>
        ///     writes a sbyte value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">sbyte value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, sbyte value)
        {
            EnsureCapacity(ref bytes, offset, 1);
            bytes[offset] = (byte)value;
            return 1;
        }

        /// <summary>
        ///     writes a sbyte value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">sbyte value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, sbyte value)
        {
            bytes[offset] = (byte)value;
        }

        /// <summary>
        ///     writes a sbyte value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">sbyte value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, sbyte value)
        {
            *(ptr + offset) = (byte)value;
        }

        /// <summary>
        ///     writes a byte array into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">byte array value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, byte[] value)
        {
            EnsureCapacity(ref bytes, offset, value.Length);
            Buffer.BlockCopy(value, 0, bytes, offset, value.Length);
            return value.Length;
        }

        /// <summary>
        ///     writes a byte array into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">byte array value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, byte[] value)
        {
            Buffer.BlockCopy(value, 0, bytes, offset, value.Length);
        }

        /// <summary>
        ///     writes a float value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">float value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, float value)
        {
            EnsureCapacity(ref bytes, offset, 4);

            //float align check
            if (offset % 4 == 0)
            {
                fixed (byte* ptr = bytes)
                {
                    *(float*)(ptr + offset) = value;
                }
            }
            else
            {
                uint num = *(uint*)&value;
                bytes[offset] = (byte)num;
                bytes[offset + 1] = (byte)(num >> 8);
                bytes[offset + 2] = (byte)(num >> 16);
                bytes[offset + 3] = (byte)(num >> 24);
            }

            return 4;
        }

        /// <summary>
        ///     writes a float value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">float value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, float value)
        {
            //float align check
            if (offset % 4 == 0)
            {
                fixed (byte* ptr = bytes)
                {
                    *(float*)(ptr + offset) = value;
                }
            }
            else
            {
                uint num = *(uint*)&value;
                bytes[offset] = (byte)num;
                bytes[offset + 1] = (byte)(num >> 8);
                bytes[offset + 2] = (byte)(num >> 16);
                bytes[offset + 3] = (byte)(num >> 24);
            }
        }

        /// <summary>
        ///     writes a float value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">float value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, float value)
        {
            //float align check
            if (offset % 4 == 0)
            {
                *(float*)(ptr + offset) = value;
            }
            else
            {
                uint num = *(uint*)&value;
                *(ptr + offset) = (byte)num;
                *(ptr + offset + 1) = (byte)(num >> 8);
                *(ptr + offset + 2) = (byte)(num >> 16);
                *(ptr + offset + 3) = (byte)(num >> 24);
            }
        }

        /// <summary>
        ///     writes a double value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">double value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, double value)
        {
            EnsureCapacity(ref bytes, offset, 8);

            //double align check
            if (offset % 8 == 0)
            {
                fixed (byte* ptr = bytes)
                {
                    *(double*)(ptr + offset) = value;
                }
            }
            else
            {
                ulong num = (ulong)*(long*)&value;
                bytes[offset] = (byte)num;
                bytes[offset + 1] = (byte)(num >> 8);
                bytes[offset + 2] = (byte)(num >> 16);
                bytes[offset + 3] = (byte)(num >> 24);
                bytes[offset + 4] = (byte)(num >> 32);
                bytes[offset + 5] = (byte)(num >> 40);
                bytes[offset + 6] = (byte)(num >> 48);
                bytes[offset + 7] = (byte)(num >> 56);
            }

            return 8;
        }

        /// <summary>
        ///     writes a double value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">double value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, double value)
        {
            //double align check
            if (offset % 8 == 0)
            {
                fixed (byte* ptr = bytes)
                {
                    *(double*)(ptr + offset) = value;
                }
            }
            else
            {
                ulong num = (ulong)*(long*)&value;
                bytes[offset] = (byte)num;
                bytes[offset + 1] = (byte)(num >> 8);
                bytes[offset + 2] = (byte)(num >> 16);
                bytes[offset + 3] = (byte)(num >> 24);
                bytes[offset + 4] = (byte)(num >> 32);
                bytes[offset + 5] = (byte)(num >> 40);
                bytes[offset + 6] = (byte)(num >> 48);
                bytes[offset + 7] = (byte)(num >> 56);
            }
        }

        /// <summary>
        ///     writes a double value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">double value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, double value)
        {
            //double align check
            if (offset % 8 == 0)
            {
                *(double*)(ptr + offset) = value;
            }
            else
            {
                ulong num = (ulong)*(long*)&value;
                *(ptr + offset) = (byte)num;
                *(ptr + offset + 1) = (byte)(num >> 8);
                *(ptr + offset + 2) = (byte)(num >> 16);
                *(ptr + offset + 3) = (byte)(num >> 24);
                *(ptr + offset + 4) = (byte)(num >> 32);
                *(ptr + offset + 5) = (byte)(num >> 40);
                *(ptr + offset + 6) = (byte)(num >> 48);
                *(ptr + offset + 7) = (byte)(num >> 56);
            }
        }

        /// <summary>
        ///     writes a short value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">short value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, short value)
        {
            EnsureCapacity(ref bytes, offset, 2);

            fixed (byte* ptr = bytes)
            {
                *(short*)(ptr + offset) = value;
            }

            return 2;
        }

        /// <summary>
        ///     writes a short value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">short value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, short value)
        {
            fixed (byte* ptr = bytes)
            {
                *(short*)(ptr + offset) = value;
            }
        }

        /// <summary>
        ///     writes a short value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">short value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, short value)
        {
            *(short*)(ptr + offset) = value;
        }

        /// <summary>
        ///     writes a ushort value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">ushort value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, ushort value)
        {
            EnsureCapacity(ref bytes, offset, 2);

            fixed (byte* ptr = bytes)
            {
                *(ushort*)(ptr + offset) = value;
            }

            return 2;
        }

        /// <summary>
        ///     writes a ushort value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">ushort value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, ushort value)
        {
            fixed (byte* ptr = bytes)
            {
                *(ushort*)(ptr + offset) = value;
            }
        }

        /// <summary>
        ///     writes a ushort value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">ushort value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, ushort value)
        {
            *(ushort*)(ptr + offset) = value;
        }

        /// <summary>
        ///     writes a int value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">int value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, int value)
        {
            EnsureCapacity(ref bytes, offset, 4);

            fixed (byte* ptr = bytes)
            {
                *(int*)(ptr + offset) = value;
            }

            return 4;
        }

        /// <summary>
        ///     writes a int value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">int value</param>
        /// MO
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, int value)
        {
            fixed (byte* ptr = bytes)
            {
                *(int*)(ptr + offset) = value;
            }
        }

        /// <summary>
        ///     writes a int value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">int value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, int value)
        {
            *(int*)(ptr + offset) = value;
        }

        /// <summary>
        ///     writes a uint value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">uint value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, uint value)
        {
            EnsureCapacity(ref bytes, offset, 4);

            fixed (byte* ptr = bytes)
            {
                *(uint*)(ptr + offset) = value;
            }

            return 4;
        }

        /// <summary>
        ///     writes a uint value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">uint value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, uint value)
        {
            fixed (byte* ptr = bytes)
            {
                *(uint*)(ptr + offset) = value;
            }
        }

        /// <summary>
        ///     writes a uint value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">uint value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, uint value)
        {
            *(uint*)(ptr + offset) = value;
        }

        /// <summary>
        ///     writes a long value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">long value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, long value)
        {
            EnsureCapacity(ref bytes, offset, 8);

            fixed (byte* ptr = bytes)
            {
                *(long*)(ptr + offset) = value;
            }

            return 8;
        }

        /// <summary>
        ///     writes a ulong value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">long value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, long value)
        {
            fixed (byte* ptr = bytes)
            {
                *(long*)(ptr + offset) = value;
            }
        }

        /// <summary>
        ///     writes a long value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">long value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, long value)
        {
            *(long*)(ptr + offset) = value;
        }

        /// <summary>
        ///     writes a ulong value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">ulong value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, ulong value)
        {
            EnsureCapacity(ref bytes, offset, 8);

            fixed (byte* ptr = bytes)
            {
                *(ulong*)(ptr + offset) = value;
            }

            return 8;
        }

        /// <summary>
        ///     writes a long value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">ulong value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, ulong value)
        {
            fixed (byte* ptr = bytes)
            {
                *(ulong*)(ptr + offset) = value;
            }
        }

        /// <summary>
        ///     writes a ulong value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">ulong value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, ulong value)
        {
            *(ulong*)(ptr + offset) = value;
        }

        /// <summary>
        ///     writes a char value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">char value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, char value)
        {
            EnsureCapacity(ref bytes, offset, 2);

            fixed (byte* ptr = bytes)
            {
                *(ushort*)(ptr + offset) = value;
            }

            return 2;
        }

        /// <summary>
        ///     writes a char value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">char value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, char value)
        {
            fixed (byte* ptr = bytes)
            {
                *(ushort*)(ptr + offset) = value;
            }
        }

        /// <summary>
        ///     writes a char value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">char value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, char value)
        {
            *(ushort*)(ptr + offset) = value;
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">string value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, string value)
        {
            if (value == null)
            {
                Write(ref bytes, offset, (ushort)0);
                return 2;
            }

            int byteCount = s_Encoding.GetByteCount(value);
            EnsureCapacity(ref bytes, offset, byteCount + 2);
            WriteUnsafe(ref bytes, offset, (ushort)byteCount);
            return s_Encoding.GetBytes(value, 0, value.Length, bytes, offset + 2) + 2;
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">string value</param>
        /// <param name="encoding">specify the encoding to use</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, string value, Encoding encoding)
        {
            if (value == null)
            {
                WriteUnsafe(ref bytes, offset, (ushort)0);
                return 2;
            }
            int byteCount = encoding.GetByteCount(value);
            EnsureCapacity(ref bytes, offset, byteCount + 2);
            WriteUnsafe(ref bytes, offset, (ushort)byteCount);
            return encoding.GetBytes(value, 0, value.Length, bytes, offset + 2) + 2;
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">string value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, string value)
        {
            if (value == null)
            {
                WriteUnsafe(ref bytes, offset, (ushort)0);
                return;
            }
            int byteCount = s_Encoding.GetByteCount(value);
            WriteUnsafe(ref bytes, offset, (ushort)byteCount);
            s_Encoding.GetBytes(value, 0, value.Length, bytes, offset + 2);
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">string value</param>
        /// <param name="byteSize">out sizeof string in bytes</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, string value, out int byteSize)
        {
            if (value == null)
            {
                WriteUnsafe(ref bytes, offset, (ushort)0);
                byteSize = 2;
                return;
            }
            int byteCount = s_Encoding.GetByteCount(value);
            WriteUnsafe(ref bytes, offset, (ushort)byteCount);
            byteSize = s_Encoding.GetBytes(value, 0, value.Length, bytes, offset + 2) + 2;
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="encoding">specify the encoding to use</param>
        /// <param name="value">string value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, string value, Encoding encoding)
        {
            if (value == null)
            {
                WriteUnsafe(ref bytes, offset, (ushort)0);
                return;
            }
            int byteCount = s_Encoding.GetByteCount(value);
            WriteUnsafe(ref bytes, offset, (ushort)byteCount);
            encoding.GetBytes(value, 0, value.Length, bytes, offset + 2);
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="encoding">specify the encoding to use</param>
        /// <param name="byteSize">out sizeof string in bytes</param>
        /// <param name="value">string value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, string value, Encoding encoding, out int byteSize)
        {
            if (value == null)
            {
                WriteUnsafe(ref bytes, offset, (ushort)0);
                byteSize = 2;
                return;
            }
            int byteCount = s_Encoding.GetByteCount(value);
            WriteUnsafe(ref bytes, offset, (ushort)byteCount);
            byteSize = encoding.GetBytes(value, 0, value.Length, bytes, offset + 2) + 2;
        }

        /// <summary>
        ///     writes a unicode string value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">string value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, string value)
        {
            if (value == null)
            {
                WriteUnsafe(ptr, offset, (ushort)0);
                return;
            }
            int byteCount = Encoding.Unicode.GetByteCount(value);
            WriteUnsafe(ptr, offset, (ushort)byteCount);
            fixed (char* cptr = value)
            {
                Memcpy(ptr + offset + 2, cptr, byteCount);
            }
        }

        /// <summary>
        ///     writes a unicode string value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">string value</param>
        /// <param name="byteSize">out sizeof string in bytes</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, string value, out int byteSize)
        {
            if (value == null)
            {
                WriteUnsafe(ptr, offset, (ushort)0);
                byteSize = 2;
                return;
            }
            int byteCount = Encoding.Unicode.GetByteCount(value);
            WriteUnsafe(ptr, offset, (ushort)byteCount);
            fixed (char* cptr = value)
            {
                Memcpy(ptr + offset + 2, cptr, byteCount);
            }
            byteSize = 2 + byteCount;
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="encoding">specify the encoding to use</param>
        /// <param name="value">string value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, string value, Encoding encoding)
        {
            if (value == null)
            {
                WriteUnsafe(ptr, offset, (ushort)0);
                return;
            }
            int byteCount = encoding.GetByteCount(value);
            WriteUnsafe(ptr, offset, (ushort)byteCount);
            fixed (char* cptr = value)
            {
                encoding.GetBytes(cptr, value.Length, ptr + offset + 2, byteCount);
            }
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="encoding">specify the encoding to use</param>
        /// <param name="byteSize">out sizeof string in bytes</param>
        /// <param name="value">string value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, string value, Encoding encoding, out int byteSize)
        {
            if (value == null)
            {
                WriteUnsafe(ptr, offset, (ushort)0);
                byteSize = 2;
                return;
            }

            int byteCount = encoding.GetByteCount(value);
            WriteUnsafe(ptr, offset, (ushort)byteCount);
            fixed (char* cptr = value)
            {
                byteSize = encoding.GetBytes(cptr, value.Length, ptr + offset + 2, byteCount) + 2;
            }
        }

        /// <summary>
        ///     writes a decimal value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">decimal value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, decimal value)
        {
            EnsureCapacity(ref bytes, offset, 16);

            fixed (byte* ptr = bytes)
            {
                *(decimal*)(ptr + offset) = value;
            }

            return 16;
        }

        /// <summary>
        ///     writes a decimal value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">decimal value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, decimal value)
        {
            fixed (byte* ptr = bytes)
            {
                *(decimal*)(ptr + offset) = value;
            }
        }

        /// <summary>
        ///     writes a decimal value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">decimal value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, decimal value)
        {
            *(decimal*)(ptr + offset) = value;
        }

        /// <summary>
        ///     writes a Guid value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">Guid value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, Guid value)
        {
            EnsureCapacity(ref bytes, offset, 16);

            fixed (byte* ptr = bytes)
            {
                *(Guid*)(ptr + offset) = value;
            }

            return 16;
        }

        /// <summary>
        ///     writes a Guid value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">Guid value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, Guid value)
        {
            fixed (byte* ptr = bytes)
            {
                *(Guid*)(ptr + offset) = value;
            }
        }

        /// <summary>
        ///     writes a Guid value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">Guid value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, Guid value)
        {
            *(Guid*)(ptr + offset) = value;
        }

        /// <summary>
        ///     writes a TimeSpan value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">TimeSpan value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, TimeSpan value)
        {
            EnsureCapacity(ref bytes, offset, 8);

            fixed (byte* ptr = bytes)
            {
                *(long*)(ptr + offset) = value.Ticks;
            }

            return 8;
        }

        /// <summary>
        ///     writes a TimeSpan value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">TimeSpan value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, TimeSpan value)
        {
            fixed (byte* ptr = bytes)
            {
                *(long*)(ptr + offset) = value.Ticks;
            }
        }

        /// <summary>
        ///     writes a TimeSpan value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">TimeSpan value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, TimeSpan value)
        {
            *(long*)(ptr + offset) = value.Ticks;
        }

        /// <summary>
        ///     writes a DateTime value into the byte array to the given offset
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">DateTime value</param>
        /// <returns>size in bytes writed</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, DateTime value)
        {
            EnsureCapacity(ref bytes, offset, 8);

            fixed (byte* ptr = bytes)
            {
                *(long*)(ptr + offset) = value.Ticks;
            }

            return 8;
        }

        /// <summary>
        ///     writes a DateTime value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="bytes">byte array</param>
        /// <param name="offset">offset</param>
        /// <param name="value">DateTime value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, DateTime value)
        {
            fixed (byte* ptr = bytes)
            {
                *(long*)(ptr + offset) = value.Ticks;
            }
        }

        /// <summary>
        ///     writes a DateTime value into the byte array to the given offset
        ///     does not ensure capacity of the byte array
        /// </summary>
        /// <param name="ptr">byte pointer</param>
        /// <param name="offset">offset</param>
        /// <param name="value">DateTime value</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* ptr, int offset, DateTime value)
        {
            *(long*)(ptr + offset) = value.Ticks;
        }

        #endregion
    }
}