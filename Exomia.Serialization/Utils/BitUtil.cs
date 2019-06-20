#region License

// Copyright (c) 2018-2019, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Exomia.Serialization.Utils
{
    /// <summary>
    ///     fast binary read and write operations on a byte array.
    /// </summary>
    public static unsafe partial class BitUtil
    {
        /// <summary>
        ///     The encoding.
        /// </summary>
        private static readonly Encoding s_encoding = Encoding.Unicode;

        /// <summary>
        ///     Initializes static members of the <see cref="BitUtil" /> class.
        /// </summary>
        /// <exception cref="Exception"> Thrown when an exception error condition occurs. </exception>
        static BitUtil()
        {
            if (!BitConverter.IsLittleEndian)
            {
                throw new Exception("Supports Little-Endian environments only.");
            }
        }

        /// <summary>
        ///     Ensures that capacity.
        /// </summary>
        /// <param name="bytes">        [in,out] The bytes. </param>
        /// <param name="offset">       The offset. </param>
        /// <param name="appendLength"> Length of the append. </param>
        internal static void EnsureCapacity(ref byte[] bytes, int offset, int appendLength)
        {
            int newLength = offset + appendLength;
            if (bytes == null)
            {
                bytes = new byte[newLength];
                return;
            }

            if (newLength > bytes.Length)
            {
                Resize(ref bytes, newLength);
            }
        }

        /// <summary>
        ///     Resizes.
        /// </summary>
        /// <param name="array">   [in,out] The array. </param>
        /// <param name="newSize"> Size of the new. </param>
        internal static void Resize(ref byte[] array, int newSize)
        {
            if (array == null)
            {
                array = new byte[newSize];
                return;
            }

            if (array.Length != newSize)
            {
                byte[] buffer = new byte[newSize];
                Buffer.BlockCopy(array, 0, buffer, 0, array.Length > newSize ? newSize : array.Length);
                array = buffer;
            }
        }

        /// <summary>
        ///     Memory copy.
        /// </summary>
        /// <param name="dest">  [in,out] If non-null, destination for the. </param>
        /// <param name="src">   [in,out] If non-null, source for the. </param>
        /// <param name="count"> Number of. </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(
            "msvcrt.dll", EntryPoint = "memcpy", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        private static extern void MemCpy(void* dest, void* src, int count);
    }
}