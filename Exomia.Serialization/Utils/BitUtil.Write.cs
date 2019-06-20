#region License

// Copyright (c) 2018-2019, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

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
        ///     The zero.
        /// </summary>
        private const byte ZERO = 0;

        /// <summary>
        ///     The one.
        /// </summary>
        private const byte ONE = 1;

        /// <summary>
        ///     writes a boolean value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  boolean value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, bool value)
        {
            EnsureCapacity(ref bytes, offset, 1);
            bytes[offset] = value ? ONE : ZERO;
            return 1;
        }

        /// <summary>
        ///     writes a boolean value into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  boolean value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, bool value)
        {
            bytes[offset] = value ? ONE : ZERO;
        }

        /// <summary>
        ///     writes a boolean value into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  boolean value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, bool value)
        {
            *(bool*)(dst + offset) = value;
        }

        /// <summary>
        ///     writes a byte value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  byte value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, byte value)
        {
            EnsureCapacity(ref bytes, offset, 1);
            bytes[offset] = value;
            return 1;
        }

        /// <summary>
        ///     writes a byte value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  byte value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, byte value)
        {
            bytes[offset] = value;
        }

        /// <summary>
        ///     writes a byte value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  byte value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, byte value)
        {
            *(dst + offset) = value;
        }

        /// <summary>
        ///     writes a sbyte value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  sbyte value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, sbyte value)
        {
            EnsureCapacity(ref bytes, offset, 1);
            bytes[offset] = (byte)value;
            return 1;
        }

        /// <summary>
        ///     writes a sbyte value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  sbyte value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, sbyte value)
        {
            bytes[offset] = (byte)value;
        }

        /// <summary>
        ///     writes a sbyte value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  sbyte value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, sbyte value)
        {
            *(dst + offset) = (byte)value;
        }

        /// <summary>
        ///     writes a byte array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  byte array value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, byte[] value)
        {
            EnsureCapacity(ref bytes, offset, value.Length);
            Buffer.BlockCopy(value, 0, bytes, offset, value.Length);
            return value.Length;
        }

        /// <summary>
        ///     writes a byte array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  byte array value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, byte[] value)
        {
            Buffer.BlockCopy(value, 0, bytes, offset, value.Length);
        }

        /// <summary>
        ///     writes a float value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  float value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, float value)
        {
            EnsureCapacity(ref bytes, offset, 4);

            //float align check
            if (offset % 4 == 0)
            {
                fixed (byte* dst = bytes)
                {
                    *(float*)(dst + offset) = value;
                }
            }
            else
            {
                uint num = *(uint*)&value;
                bytes[offset]     = (byte)num;
                bytes[offset + 1] = (byte)(num >> 8);
                bytes[offset + 2] = (byte)(num >> 16);
                bytes[offset + 3] = (byte)(num >> 24);
            }

            return 4;
        }

        /// <summary>
        ///     writes a float value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  float value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, float value)
        {
            //float align check
            if (offset % 4 == 0)
            {
                fixed (byte* dst = bytes)
                {
                    *(float*)(dst + offset) = value;
                }
            }
            else
            {
                uint num = *(uint*)&value;
                bytes[offset]     = (byte)num;
                bytes[offset + 1] = (byte)(num >> 8);
                bytes[offset + 2] = (byte)(num >> 16);
                bytes[offset + 3] = (byte)(num >> 24);
            }
        }

        /// <summary>
        ///     writes a float value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  float value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, float value)
        {
            //float align check
            if (offset % 4 == 0)
            {
                *(float*)(dst + offset) = value;
            }
            else
            {
                uint num = *(uint*)&value;
                *(dst          + offset) = (byte)num;
                *(dst + offset + 1)      = (byte)(num >> 8);
                *(dst + offset + 2)      = (byte)(num >> 16);
                *(dst + offset + 3)      = (byte)(num >> 24);
            }
        }

        /// <summary>
        ///     writes a double value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  double value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, double value)
        {
            EnsureCapacity(ref bytes, offset, 8);

            //double align check
            if (offset % 8 == 0)
            {
                fixed (byte* dst = bytes)
                {
                    *(double*)(dst + offset) = value;
                }
            }
            else
            {
                ulong num = (ulong)*(long*)&value;
                bytes[offset]     = (byte)num;
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
        ///     writes a double value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  double value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, double value)
        {
            //double align check
            if (offset % 8 == 0)
            {
                fixed (byte* dst = bytes)
                {
                    *(double*)(dst + offset) = value;
                }
            }
            else
            {
                ulong num = (ulong)*(long*)&value;
                bytes[offset]     = (byte)num;
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
        ///     writes a double value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  double value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, double value)
        {
            //double align check
            if (offset % 8 == 0)
            {
                *(double*)(dst + offset) = value;
            }
            else
            {
                ulong num = (ulong)*(long*)&value;
                *(dst          + offset) = (byte)num;
                *(dst + offset + 1)      = (byte)(num >> 8);
                *(dst + offset + 2)      = (byte)(num >> 16);
                *(dst + offset + 3)      = (byte)(num >> 24);
                *(dst + offset + 4)      = (byte)(num >> 32);
                *(dst + offset + 5)      = (byte)(num >> 40);
                *(dst + offset + 6)      = (byte)(num >> 48);
                *(dst + offset + 7)      = (byte)(num >> 56);
            }
        }

        /// <summary>
        ///     writes a short value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  short value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, short value)
        {
            EnsureCapacity(ref bytes, offset, 2);

            fixed (byte* dst = bytes)
            {
                *(short*)(dst + offset) = value;
            }

            return 2;
        }

        /// <summary>
        ///     writes a short value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  short value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, short value)
        {
            fixed (byte* dst = bytes)
            {
                *(short*)(dst + offset) = value;
            }
        }

        /// <summary>
        ///     writes a short value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  short value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, short value)
        {
            *(short*)(dst + offset) = value;
        }

        /// <summary>
        ///     writes a ushort value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  ushort value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, ushort value)
        {
            EnsureCapacity(ref bytes, offset, 2);

            fixed (byte* dst = bytes)
            {
                *(ushort*)(dst + offset) = value;
            }

            return 2;
        }

        /// <summary>
        ///     writes a ushort value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  ushort value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, ushort value)
        {
            fixed (byte* dst = bytes)
            {
                *(ushort*)(dst + offset) = value;
            }
        }

        /// <summary>
        ///     writes a ushort value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  ushort value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, ushort value)
        {
            *(ushort*)(dst + offset) = value;
        }

        /// <summary>
        ///     writes a int value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  int value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, int value)
        {
            EnsureCapacity(ref bytes, offset, 4);

            fixed (byte* dst = bytes)
            {
                *(int*)(dst + offset) = value;
            }

            return 4;
        }

        /// <summary>
        ///     writes a int value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  int value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, int value)
        {
            fixed (byte* dst = bytes)
            {
                *(int*)(dst + offset) = value;
            }
        }

        /// <summary>
        ///     writes a int value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  int value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, int value)
        {
            *(int*)(dst + offset) = value;
        }

        /// <summary>
        ///     writes a uint value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  uint value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, uint value)
        {
            EnsureCapacity(ref bytes, offset, 4);

            fixed (byte* dst = bytes)
            {
                *(uint*)(dst + offset) = value;
            }

            return 4;
        }

        /// <summary>
        ///     writes a uint value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  uint value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, uint value)
        {
            fixed (byte* dst = bytes)
            {
                *(uint*)(dst + offset) = value;
            }
        }

        /// <summary>
        ///     writes a uint value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  uint value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, uint value)
        {
            *(uint*)(dst + offset) = value;
        }

        /// <summary>
        ///     writes a long value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  long value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, long value)
        {
            EnsureCapacity(ref bytes, offset, 8);

            fixed (byte* dst = bytes)
            {
                *(long*)(dst + offset) = value;
            }

            return 8;
        }

        /// <summary>
        ///     writes a ulong value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  long value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, long value)
        {
            fixed (byte* dst = bytes)
            {
                *(long*)(dst + offset) = value;
            }
        }

        /// <summary>
        ///     writes a long value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  long value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, long value)
        {
            *(long*)(dst + offset) = value;
        }

        /// <summary>
        ///     writes a ulong value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  ulong value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, ulong value)
        {
            EnsureCapacity(ref bytes, offset, 8);

            fixed (byte* dst = bytes)
            {
                *(ulong*)(dst + offset) = value;
            }

            return 8;
        }

        /// <summary>
        ///     writes a long value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  ulong value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, ulong value)
        {
            fixed (byte* dst = bytes)
            {
                *(ulong*)(dst + offset) = value;
            }
        }

        /// <summary>
        ///     writes a ulong value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  ulong value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, ulong value)
        {
            *(ulong*)(dst + offset) = value;
        }

        /// <summary>
        ///     writes a char value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  char value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, char value)
        {
            EnsureCapacity(ref bytes, offset, 2);

            fixed (byte* dst = bytes)
            {
                *(ushort*)(dst + offset) = value;
            }

            return 2;
        }

        /// <summary>
        ///     writes a char value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  char value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, char value)
        {
            fixed (byte* dst = bytes)
            {
                *(ushort*)(dst + offset) = value;
            }
        }

        /// <summary>
        ///     writes a char value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  char value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, char value)
        {
            *(ushort*)(dst + offset) = value;
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  string value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, string value)
        {
            if (value == null)
            {
                Write(ref bytes, offset, (ushort)0);
                return 2;
            }

            int byteCount = s_encoding.GetByteCount(value);
            EnsureCapacity(ref bytes, offset, byteCount + 2);
            WriteUnsafe(ref bytes, offset, (ushort)byteCount);
            return s_encoding.GetBytes(value, 0, value.Length, bytes, offset + 2) + 2;
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="value">    string value. </param>
        /// <param name="encoding"> specify the encoding to use. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
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
        ///     writes a string value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  string value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, string value)
        {
            if (value == null)
            {
                WriteUnsafe(ref bytes, offset, (ushort)0);
                return;
            }
            int byteCount = s_encoding.GetByteCount(value);
            WriteUnsafe(ref bytes, offset, (ushort)byteCount);
            s_encoding.GetBytes(value, 0, value.Length, bytes, offset + 2);
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="value">    string value. </param>
        /// <param name="byteSize"> [out] out sizeof string in bytes. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, string value, out int byteSize)
        {
            if (value == null)
            {
                WriteUnsafe(ref bytes, offset, (ushort)0);
                byteSize = 2;
                return;
            }
            int byteCount = s_encoding.GetByteCount(value);
            WriteUnsafe(ref bytes, offset, (ushort)byteCount);
            byteSize = s_encoding.GetBytes(value, 0, value.Length, bytes, offset + 2) + 2;
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="value">    string value. </param>
        /// <param name="encoding"> specify the encoding to use. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, string value, Encoding encoding)
        {
            if (value == null)
            {
                WriteUnsafe(ref bytes, offset, (ushort)0);
                return;
            }
            int byteCount = s_encoding.GetByteCount(value);
            WriteUnsafe(ref bytes, offset, (ushort)byteCount);
            encoding.GetBytes(value, 0, value.Length, bytes, offset + 2);
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="value">    string value. </param>
        /// <param name="encoding"> specify the encoding to use. </param>
        /// <param name="byteSize"> [out] out sizeof string in bytes. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, string value, Encoding encoding, out int byteSize)
        {
            if (value == null)
            {
                WriteUnsafe(ref bytes, offset, (ushort)0);
                byteSize = 2;
                return;
            }
            int byteCount = s_encoding.GetByteCount(value);
            WriteUnsafe(ref bytes, offset, (ushort)byteCount);
            byteSize = encoding.GetBytes(value, 0, value.Length, bytes, offset + 2) + 2;
        }

        /// <summary>
        ///     writes a unicode string value into the byte array to the given offset does not ensure
        ///     capacity of the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  string value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, string value)
        {
            if (value == null)
            {
                WriteUnsafe(dst, offset, (ushort)0);
                return;
            }
            int byteCount = Encoding.Unicode.GetByteCount(value);
            WriteUnsafe(dst, offset, (ushort)byteCount);
            fixed (char* cdst = value)
            {
                MemCpy(dst + offset + 2, cdst, byteCount);
            }
        }

        /// <summary>
        ///     writes a unicode string value into the byte array to the given offset does not ensure
        ///     capacity of the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="value">    string value. </param>
        /// <param name="byteSize"> [out] out sizeof string in bytes. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, string value, out int byteSize)
        {
            if (value == null)
            {
                WriteUnsafe(dst, offset, (ushort)0);
                byteSize = 2;
                return;
            }
            int byteCount = Encoding.Unicode.GetByteCount(value);
            WriteUnsafe(dst, offset, (ushort)byteCount);
            fixed (char* cdst = value)
            {
                MemCpy(dst + offset + 2, cdst, byteCount);
            }
            byteSize = 2 + byteCount;
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="value">    string value. </param>
        /// <param name="encoding"> specify the encoding to use. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, string value, Encoding encoding)
        {
            if (value == null)
            {
                WriteUnsafe(dst, offset, (ushort)0);
                return;
            }
            int byteCount = encoding.GetByteCount(value);
            WriteUnsafe(dst, offset, (ushort)byteCount);
            fixed (char* cdst = value)
            {
                encoding.GetBytes(cdst, value.Length, dst + offset + 2, byteCount);
            }
        }

        /// <summary>
        ///     writes a string value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="value">    string value. </param>
        /// <param name="encoding"> specify the encoding to use. </param>
        /// <param name="byteSize"> [out] out sizeof string in bytes. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, string value, Encoding encoding, out int byteSize)
        {
            if (value == null)
            {
                WriteUnsafe(dst, offset, (ushort)0);
                byteSize = 2;
                return;
            }

            int byteCount = encoding.GetByteCount(value);
            WriteUnsafe(dst, offset, (ushort)byteCount);
            fixed (char* cdst = value)
            {
                byteSize = encoding.GetBytes(cdst, value.Length, dst + offset + 2, byteCount) + 2;
            }
        }

        /// <summary>
        ///     writes a decimal value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  decimal value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, decimal value)
        {
            EnsureCapacity(ref bytes, offset, 16);

            fixed (byte* dst = bytes)
            {
                *(decimal*)(dst + offset) = value;
            }

            return 16;
        }

        /// <summary>
        ///     writes a decimal value into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  decimal value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, decimal value)
        {
            fixed (byte* dst = bytes)
            {
                *(decimal*)(dst + offset) = value;
            }
        }

        /// <summary>
        ///     writes a decimal value into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  decimal value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, decimal value)
        {
            *(decimal*)(dst + offset) = value;
        }

        /// <summary>
        ///     writes a Guid value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  Guid value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, Guid value)
        {
            EnsureCapacity(ref bytes, offset, 16);

            fixed (byte* dst = bytes)
            {
                *(Guid*)(dst + offset) = value;
            }

            return 16;
        }

        /// <summary>
        ///     writes a Guid value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  Guid value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, Guid value)
        {
            fixed (byte* dst = bytes)
            {
                *(Guid*)(dst + offset) = value;
            }
        }

        /// <summary>
        ///     writes a Guid value into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  Guid value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, Guid value)
        {
            *(Guid*)(dst + offset) = value;
        }

        /// <summary>
        ///     writes a TimeSpan value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  TimeSpan value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, TimeSpan value)
        {
            EnsureCapacity(ref bytes, offset, 8);

            fixed (byte* dst = bytes)
            {
                *(long*)(dst + offset) = value.Ticks;
            }

            return 8;
        }

        /// <summary>
        ///     writes a TimeSpan value into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  TimeSpan value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, TimeSpan value)
        {
            fixed (byte* dst = bytes)
            {
                *(long*)(dst + offset) = value.Ticks;
            }
        }

        /// <summary>
        ///     writes a TimeSpan value into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  TimeSpan value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, TimeSpan value)
        {
            *(long*)(dst + offset) = value.Ticks;
        }

        /// <summary>
        ///     writes a DateTime value into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  DateTime value. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, DateTime value)
        {
            EnsureCapacity(ref bytes, offset, 8);

            fixed (byte* dst = bytes)
            {
                *(long*)(dst + offset) = value.Ticks;
            }

            return 8;
        }

        /// <summary>
        ///     writes a DateTime value into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  DateTime value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, DateTime value)
        {
            fixed (byte* dst = bytes)
            {
                *(long*)(dst + offset) = value.Ticks;
            }
        }

        /// <summary>
        ///     writes a DateTime value into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="dst">    [in,out] byte pointer. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="value">  DateTime value. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, DateTime value)
        {
            *(long*)(dst + offset) = value.Ticks;
        }
    }
}