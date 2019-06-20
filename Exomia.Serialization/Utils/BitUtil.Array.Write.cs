#region License

// Copyright (c) 2018-2019, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System;
using System.Runtime.CompilerServices;

namespace Exomia.Serialization.Utils
{
    /// <content>
    ///     A bit utility.
    /// </content>
    public static unsafe partial class BitUtil
    {
        /// <summary>
        ///     writes a boolean array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> boolean array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, bool[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (bool* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length);
                }
            }

            return 4 + (1 * length);
        }

        /// <summary>
        ///     writes a boolean array into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   boolean array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, bool[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (bool* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length);
                }
            }
            byteSize = length;
        }

        /// <summary>
        ///     writes a boolean array into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   boolean array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, bool[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (bool* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length);
            }
            byteSize = length;
        }

        /// <summary>
        ///     writes a byte array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   byte array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, byte[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (byte* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length);
                }
            }
            byteSize = length;
        }

        /// <summary>
        ///     writes a byte array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   byte array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, byte[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (byte* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length);
            }
            byteSize = length;
        }

        /// <summary>
        ///     writes a sbyte array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> sbyte array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, sbyte[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (sbyte* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length);
                }
            }

            return 4 + (1 * length);
        }

        /// <summary>
        ///     writes a sbyte array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   sbyte array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, sbyte[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (sbyte* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length);
                }
            }
            byteSize = length;
        }

        /// <summary>
        ///     writes a sbyte array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   sbyte array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, sbyte[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (sbyte* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length);
            }
            byteSize = length;
        }

        /// <summary>
        ///     writes a float array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> float array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, float[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (float* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 4);
                }
            }

            return 4 + (4 * length);
        }

        /// <summary>
        ///     writes a float array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   float array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, float[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (float* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 4);
                }
            }
            byteSize = length * 4;
        }

        /// <summary>
        ///     writes a float array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   float array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, float[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (float* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length * 4);
            }
            byteSize = length * 4;
        }

        /// <summary>
        ///     writes a double array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> double array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, double[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (double* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 8);
                }
            }

            return 4 + (8 * length);
        }

        /// <summary>
        ///     writes a double array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   double array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, double[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (double* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 8);
                }
            }
            byteSize = length * 8;
        }

        /// <summary>
        ///     writes a double array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   double array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, double[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (double* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length * 8);
            }
            byteSize = length * 8;
        }

        /// <summary>
        ///     writes a short array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> short array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, short[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (short* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 2);
                }
            }

            return 4 + (2 * length);
        }

        /// <summary>
        ///     writes a short array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   short array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, short[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (short* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 2);
                }
            }
            byteSize = length * 2;
        }

        /// <summary>
        ///     writes a short array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   short array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, short[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (short* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length * 2);
            }
            byteSize = length * 2;
        }

        /// <summary>
        ///     writes a ushort array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> ushort array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, ushort[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (ushort* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 2);
                }
            }

            return 4 + (2 * length);
        }

        /// <summary>
        ///     writes a ushort array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   ushort array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, ushort[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (ushort* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 2);
                }
            }
            byteSize = length * 2;
        }

        /// <summary>
        ///     writes a ushort array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   ushort array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, ushort[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (ushort* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length * 2);
            }
            byteSize = length * 2;
        }

        /// <summary>
        ///     writes a int array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> int array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, int[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (int* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 4);
                }
            }

            return 4 + (4 * length);
        }

        /// <summary>
        ///     writes a int array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   int array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, int[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (int* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 4);
                }
            }
            byteSize = length * 4;
        }

        /// <summary>
        ///     writes a int array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   int array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, int[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (int* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length * 4);
            }
            byteSize = length * 4;
        }

        /// <summary>
        ///     writes a uint array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> uint array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, uint[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (uint* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 4);
                }
            }

            return 4 + (4 * length);
        }

        /// <summary>
        ///     writes a uint array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   uint array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, uint[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (uint* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 4);
                }
            }
            byteSize = length * 4;
        }

        /// <summary>
        ///     writes a uint array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   uint array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, uint[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (uint* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length * 4);
            }
            byteSize = length * 4;
        }

        /// <summary>
        ///     writes a long array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> long array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, long[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (long* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 8);
                }
            }

            return 4 + (8 * length);
        }

        /// <summary>
        ///     writes a ulong array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   long array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, long[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (long* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 8);
                }
            }
            byteSize = length * 8;
        }

        /// <summary>
        ///     writes a long array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   long array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, long[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (long* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length * 8);
            }
            byteSize = length * 8;
        }

        /// <summary>
        ///     writes a ulong array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> ulong array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, ulong[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (ulong* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 8);
                }
            }

            return 4 + (8 * length);
        }

        /// <summary>
        ///     writes a long array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   ulong array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, ulong[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (ulong* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 8);
                }
            }
            byteSize = length * 8;
        }

        /// <summary>
        ///     writes a ulong array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   ulong array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, ulong[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (ulong* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length * 8);
            }
            byteSize = length * 8;
        }

        /// <summary>
        ///     writes a char array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> char array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, char[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (char* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 2);
                }
            }

            return 4 + (2 * length);
        }

        /// <summary>
        ///     writes a char array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   char array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, char[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (char* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 2);
                }
            }
            byteSize = length * 2;
        }

        /// <summary>
        ///     writes a char array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   char array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, char[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (char* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length * 2);
            }
            byteSize = length * 2;
        }

        /// <summary>
        ///     writes a string array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> string array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
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
        ///     writes a string array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   string array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, string[] values, out int byteSize)
        {
            int length = values.Length;
            WriteUnsafe(ref bytes, offset, values.Length);

            int startOffset = offset;
            offset += 4;

            for (int i = 0; i < length; i++)
            {
                WriteUnsafe(ref bytes, offset, values[i]);
                offset += 2 + s_encoding.GetMaxByteCount(values[i].Length);
            }

            byteSize = offset - startOffset;
        }

        /// <summary>
        ///     writes a decimal array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> decimal array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, decimal[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (decimal* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 16);
                }
            }

            return 4 + (16 * length);
        }

        /// <summary>
        ///     writes a decimal array into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   decimal array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, decimal[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (decimal* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 16);
                }
            }
            byteSize = length * 16;
        }

        /// <summary>
        ///     writes a decimal array into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   decimal array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, decimal[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (decimal* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length * 16);
            }
            byteSize = length * 16;
        }

        /// <summary>
        ///     writes a Guid array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> Guid array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, Guid[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (Guid* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 16);
                }
            }

            return 4 + (16 * length);
        }

        /// <summary>
        ///     writes a Guid array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   Guid array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, Guid[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (Guid* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 16);
                }
            }
            byteSize = length * 16;
        }

        /// <summary>
        ///     writes a Guid array into the byte array to the given offset does not ensure capacity of
        ///     the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   Guid array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, Guid[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (Guid* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length * 16);
            }
            byteSize = length * 16;
        }

        /// <summary>
        ///     writes a TimeSpan array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> TimeSpan array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, TimeSpan[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (TimeSpan* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 8);
                }
            }

            return 4 + (8 * length);
        }

        /// <summary>
        ///     writes a TimeSpan array into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   TimeSpan array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, TimeSpan[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (TimeSpan* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 8);
                }
            }
            byteSize = length * 8;
        }

        /// <summary>
        ///     writes a TimeSpan array into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   TimeSpan array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, TimeSpan[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (TimeSpan* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length * 8);
            }
            byteSize = length * 8;
        }

        /// <summary>
        ///     writes a DateTime array into the byte array to the given offset.
        /// </summary>
        /// <param name="bytes">  [in,out] byte array. </param>
        /// <param name="offset"> offset. </param>
        /// <param name="values"> DateTime array. </param>
        /// <returns>
        ///     size in bytes written.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref byte[] bytes, int offset, DateTime[] values)
        {
            EnsureCapacity(ref bytes, offset, 4 + values.Length);

            int length = values.Length;
            fixed (DateTime* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 8);
                }
            }

            return 4 + (8 * length);
        }

        /// <summary>
        ///     writes a DateTime array into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="bytes">    [in,out] byte array. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   DateTime array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(ref byte[] bytes, int offset, DateTime[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (DateTime* src = values)
            {
                fixed (byte* dst = bytes)
                {
                    *(int*)dst = length;
                    MemCpy(dst + offset + 4, src, length * 8);
                }
            }
            byteSize = length * 8;
        }

        /// <summary>
        ///     writes a DateTime array into the byte array to the given offset does not ensure capacity
        ///     of the byte array.
        /// </summary>
        /// <param name="dst">      [in,out] byte pointer. </param>
        /// <param name="offset">   offset. </param>
        /// <param name="values">   DateTime array. </param>
        /// <param name="byteSize"> [out] out sizeof bytes used. </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteUnsafe(byte* dst, int offset, DateTime[] values, out int byteSize)
        {
            int length = values.Length;
            fixed (DateTime* src = values)
            {
                *(int*)dst = length;
                MemCpy(dst + offset + 4, src, length * 8);
            }
            byteSize = length * 8;
        }
    }
}