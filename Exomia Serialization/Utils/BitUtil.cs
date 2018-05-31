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
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Exomia.Serialization.Utils
{
    /// <summary>
    ///     fast binary read and write operations on a byte array
    /// </summary>
    public static unsafe partial class BitUtil
    {
        #region Variables

        private static readonly Encoding s_Encoding = Encoding.Unicode;

        #endregion

        #region Constructors

        static BitUtil()
        {
            if (!BitConverter.IsLittleEndian)
            {
                throw new Exception("Supports Little-Endian environments only.");
            }
        }

        #endregion

        #region Methods

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

        [SuppressUnmanagedCodeSecurity]
        [DllImport(
            "msvcrt.dll", EntryPoint = "memcpy", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        private static extern void MemCpy(void* dest, void* src, int count);

        #endregion
    }
}