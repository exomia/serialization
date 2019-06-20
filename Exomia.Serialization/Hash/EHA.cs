#region License

// Copyright (c) 2018-2019, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Exomia.Serialization.Hash
{
    /// <summary>
    ///     exomia hash algorithm.
    /// </summary>
    public sealed unsafe class EHA
    {
        /// <summary>
        ///     Size of the buffer.
        /// </summary>
        private const int BUFFER_SIZE = 1024 * 4;

        /// <summary>
        ///     The block bits.
        /// </summary>
        private const int BLOCK_BITS = 1024;

        /// <summary>
        ///     Size of the block.
        /// </summary>
        private const int BLOCK_SIZE = BLOCK_BITS / 8;

        /// <summary>
        ///     The hash bits.
        /// </summary>
        private const int HASH_BITS = 192;

        /// <summary>
        ///     Size of the hash.
        /// </summary>
        private const int HASH_SIZE = HASH_BITS / 8;

        /// <summary>
        ///     The hash values.
        /// </summary>
        private const int HASH_VALUES = HASH_SIZE / 4;

        /// <summary>
        ///     Length of the block.
        /// </summary>
        private const int BLOCK_LENGTH = BLOCK_SIZE / 4;

        /// <summary>
        ///     Size of the words.
        /// </summary>
        private const int WORDS_SIZE = BLOCK_LENGTH * HASH_VALUES;

        /// <summary>
        ///     The rounds.
        /// </summary>
        private const int ROUNDS = 4;

        /// <summary>
        ///     The rounds offset.
        /// </summary>
        private const int ROUNDS_OFFSET = BLOCK_LENGTH / ROUNDS;

        /// <summary>
        ///     The h 0.
        /// </summary>
        private const uint H0 = 0x209536F9;

        /// <summary>
        ///     The first h.
        /// </summary>
        private const uint H1 = 0x1267A4BB;

        /// <summary>
        ///     The second h.
        /// </summary>
        private const uint H2 = 0xEE1F88D;

        /// <summary>
        ///     The third h.
        /// </summary>
        private const uint H3 = 0xA4B0B65;

        /// <summary>
        ///     The fourth h.
        /// </summary>
        private const uint H4 = 0x350798D7;

        /// <summary>
        ///     The fifth h.
        /// </summary>
        private const uint H5 = 0x2AE59A2F;

        /// <summary>
        ///     The c 0.
        /// </summary>
        private const uint C0 = 0xEEBB2A29;

        /// <summary>
        ///     The first c.
        /// </summary>
        private const uint C1 = 0x214EE939;

        /// <summary>
        ///     The second c.
        /// </summary>
        private const uint C2 = 0x117DFA89;

        /// <summary>
        ///     The third c.
        /// </summary>
        private const uint C3 = 0xFF8F44BB;

        /// <summary>
        ///     The fourth c.
        /// </summary>
        private const uint C4 = 0xD28146D5;

        /// <summary>
        ///     The fifth c.
        /// </summary>
        private const uint C5 = 0x8EA96F89;

        /// <summary>
        ///     The one.
        /// </summary>
        private const byte ONE = 0b10000000;

        /// <summary>
        ///     The 0.
        /// </summary>
        private readonly uint _h0;

        /// <summary>
        ///     The first h.
        /// </summary>
        private readonly uint _h1;

        /// <summary>
        ///     The second h.
        /// </summary>
        private readonly uint _h2;

        /// <summary>
        ///     The third h.
        /// </summary>
        private readonly uint _h3;

        /// <summary>
        ///     The fourth h.
        /// </summary>
        private readonly uint _h4;

        /// <summary>
        ///     The fifth h.
        /// </summary>
        private readonly uint _h5;

        /// <summary>
        ///     Initializes a new instance of the <see cref="EHA" /> class.
        /// </summary>
        /// <param name="seed"> The seed. </param>
        public EHA(long seed)
        {
            uint s1 = (uint)seed;
            uint s2 = (uint)(seed >> 32);
            _h0 = s1 + H0 + R1(s1, 12);
            _h1 = s2 + H1 + R1(s1, 12);
            _h2 = R1(s1, 30)                     ^ (_h0 + H2 + _h1);
            _h3 = R1(s2, 30)                     ^ (_h1 + H3 + _h2);
            _h4 = (R1(_h2, 30) + ~_h0 + H4) ^ s1 ^ s2;
            _h5 = (R1(_h3, 30) + ~_h1 + H5) ^ s1 ^ s2;
        }

        /// <summary>
        ///     Process a block with 1024bit = 32x32-bit words.
        /// </summary>
        /// <param name="hash"> The hash. </param>
        /// <param name="ptr">  [in,out] If non-null, the pointer. </param>
        /// <param name="size"> The size. </param>
        private static void ProcessBlock(uint[] hash, byte* ptr, int size)
        {
            // DEFAULT FULL BLOCK
            if (size == BLOCK_SIZE)
            {
                ProcessBlock(hash, (uint*)ptr);
                return;
            }

            // LESS THAN A FULL BLOCK
            Set(ptr      + size, 0, BLOCK_SIZE - size);
            *(ptr + size + 1) = ONE;

            uint value = *(uint*)&size;

            // IF WE HAVE ENOUGH SPACE
            if (size < BLOCK_SIZE - 5)
            {
                *(uint*)((ptr + BLOCK_SIZE) - 4) = value;
                ProcessBlock(hash, (uint*)ptr);
                return;
            }

            // ELSE FILL UP
            int b = (size + 5) - BLOCK_SIZE;
            for (int i = 1; i < b; i++)
            {
                *(ptr + size + i) = (byte)(value >> ((i - 1) * 8));
            }
            ProcessBlock(hash, (uint*)ptr);

            // CLEAR & PROCESS REST
            Set(ptr, 0, BLOCK_SIZE);
            for (int i = b; i < 5; i++)
            {
                *(ptr + size + i) = (byte)(value >> ((i - 1) * 8));
            }
            ProcessBlock(hash, (uint*)ptr);
        }

        /// <summary>
        ///     Process a block with 1024bit = 32x32-bit words.
        /// </summary>
        /// <param name="hash"> The hash. </param>
        /// <param name="ptr">  [in,out] If non-null, the pointer. </param>
        private static void ProcessBlock(uint[] hash, uint* ptr)
        {
            //get last hash
            uint a = hash[0];
            uint b = hash[1];
            uint c = hash[2];
            uint d = hash[3];
            uint e = hash[4];
            uint f = hash[5];

            uint* words = stackalloc uint[WORDS_SIZE];

            for (int i = 0; i < BLOCK_LENGTH; ++i)
            {
                *(words + i) = *(ptr + i);
            }

            for (int i = BLOCK_LENGTH; i < WORDS_SIZE; ++i)
            {
                *(words + i) = R1(
                    *((words + i) - 5) ^ *((words + i) - 7) ^ *((words + i) - (BLOCK_LENGTH - 7)) ^
                    *((words + i) - (BLOCK_LENGTH - 3)), 1);
            }

            // first round
            for (int i = 0; i < ROUNDS_OFFSET; ++i)
            {
                int offset = HASH_VALUES * i;
                f += R1(a, 5) + F1(b, e, d) + *(words + offset + 0) + C0;
                b =  R1(b, 29);
                e += R1(f, 4) + F1(f, c, d) + *(words + offset + 1) + C0;
                f =  R1(f, 29);
                d += R1(e, 4) + F1(a, b, c) + *(words + offset + 2) + C0;
                a =  R1(a, 27);
                c += R1(d, 5) + F1(e, a, b) + *(words + offset + 3) + C0;
                e =  R1(e, 27);
                b += R1(c, 8) + F1(d, f, a) + *(words + offset + 4) + C0;
                d =  R1(d, 30);
                a += R1(b, 8) + F1(f, d, e) + *(words + offset + 5) + C0;
                c =  R1(c, 30);
            }

            // second round
            for (int i = ROUNDS_OFFSET; i < ROUNDS_OFFSET * 2; ++i)
            {
                int offset = HASH_VALUES * i;
                f += R1(a, 3) + F2(b, a, d) + *(words + offset + 0) + C1;
                b =  R1(b, 22);
                e += R1(a, 8) + F2(f, c, d) + *(words + offset + 1) + C1;
                f =  R1(f, 22);
                d += R1(e, 8) + F2(a, b, c) + *(words + offset + 2) + C1;
                a =  R1(a, 12);
                c += R1(d, 6) + F2(e, a, b) + *(words + offset + 3) + C1;
                e =  R1(e, 31);
                b += R1(c, 4) + F2(d, e, f) + *(words + offset + 4) + C1;
                d =  R1(d, 18);
                a += R1(b, 4) + F2(c, d, e) + *(words + offset + 5) + C1;
                c =  R1(c, 31);
            }

            // third round
            for (int i = ROUNDS_OFFSET * 2; i < ROUNDS_OFFSET * 3; ++i)
            {
                int offset = HASH_VALUES * i;
                f += R1(a, 5) + F3(e, b, c) + *(words + offset + 0) + C2;
                b =  R1(b, 27);
                e += R1(a, 3) + F3(b, c, d) + *(words + offset + 1) + C2;
                f =  R1(f, 27);
                d += R1(e, 3) + F3(a, b, d) + *(words + offset + 2) + C2;
                a =  R1(a, 28);
                c += R1(d, 5) + F3(e, a, f) + *(words + offset + 3) + C2;
                e =  R1(e, 28);
                b += R1(c, 7) + F3(d, e, a) + *(words + offset + 4) + C2;
                d =  R1(d, 30);
                a += R1(b, 7) + F3(c, d, e) + *(words + offset + 5) + C2;
                c =  R1(c, 30);
            }

            // fourth round
            for (int i = ROUNDS_OFFSET * 3; i < ROUNDS_OFFSET * 4; ++i)
            {
                int offset = HASH_VALUES * i;
                f += R1(a, 9) + F4(b, a, c) + *(words + offset + 0) + C3;
                b =  R1(b, 26);
                e += R1(a, 9) + F4(f, c, d) + *(words + offset + 1) + C3;
                f =  R1(f, 26);
                d += R1(e, 7) + F4(a, b, c) + *(words + offset + 2) + C3;
                a =  R1(a, 23);
                c += R1(d, 7) + F4(d, a, b) + *(words + offset + 3) + C3;
                e =  R1(e, 23);
                b += R1(c, 5) + F4(d, f, a) + *(words + offset + 4) + C3;
                d =  R1(d, 15);
                a += R1(b, 5) + F4(c, d, e) + *(words + offset + 5) + C3;
                c =  R1(c, 15);
            }

            //update hash
            hash[0] += a ^ C4;
            hash[1] += b ^ C4;
            hash[2] += c | C5;
            hash[3] += d | C5;
            hash[4] += e & C4;
            hash[5] += f ^ ~C5;
        }

        /// <summary>
        ///     memset call. Sets the first num bytes of the block of memory pointed by ptr to the
        ///     specified value (interpreted as an unsigned char).
        /// </summary>
        /// <param name="dest">  [in,out] destination addr. </param>
        /// <param name="value"> value to be set. </param>
        /// <param name="count"> count of bytes. </param>
        /// <returns>
        ///     Null if it fails, else a void*.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(
            "msvcrt.dll", EntryPoint = "memset", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        private static extern void* Set(
            void* dest,
            int   value,
            int   count);

        /// <summary>
        ///     generates a hash from a given stream and returns it as a byte array.
        /// </summary>
        /// <param name="stream"> input. </param>
        /// <returns>
        ///     byte array.
        /// </returns>
        public byte[] ToBytes(Stream stream)
        {
            uint[] hash   = Hash(stream);
            byte[] buffer = new byte[HASH_SIZE];
            int    offset = 0;
            fixed (byte* ptr = buffer)
            {
                for (int i = 0; i < HASH_VALUES; ++i)
                {
                    *(ptr + offset + 0) =  (byte)(hash[i]         & 0xFF);
                    *(ptr + offset + 1) =  (byte)((hash[i] >> 8)  & 0xFF);
                    *(ptr + offset + 2) =  (byte)((hash[i] >> 16) & 0xFF);
                    *(ptr + offset + 3) =  (byte)((hash[i] >> 24) & 0xFF);
                    offset              += 4;
                }
            }
            return buffer;
        }

        /// <summary>
        ///     generates a hash from given string data and returns it as a hex string.
        /// </summary>
        /// <param name="data"> data. </param>
        /// <returns>
        ///     hex string.
        /// </returns>
        public byte[] ToBytes(string data)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(data)))
            {
                return ToBytes(ms);
            }
        }

        /// <summary>
        ///     generates a hash from given string data and returns it as a hex string.
        /// </summary>
        /// <param name="data"> data. </param>
        /// <returns>
        ///     hex string.
        /// </returns>
        public byte[] ToBytes(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return ToBytes(ms);
            }
        }

        /// <summary>
        ///     generates a hash from a given stream and returns it as a hex string.
        /// </summary>
        /// <param name="stream"> input. </param>
        /// <returns>
        ///     hex string.
        /// </returns>
        public string ToString(Stream stream)
        {
            uint[] hash = Hash(stream);

            StringBuilder result = new StringBuilder(HASH_SIZE * 2);
            for (int i = 0; i < HASH_VALUES; ++i)
            {
                result.Append(hash[i].ToString("X8"));
            }

            return result.ToString();
        }

        /// <summary>
        ///     generates a hash from given string data and returns it as a hex string.
        /// </summary>
        /// <param name="data"> data. </param>
        /// <returns>
        ///     hex string.
        /// </returns>
        public string ToString(string data)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(data)))
            {
                return ToString(ms);
            }
        }

        /// <summary>
        ///     generates a hash from given string data and returns it as a hex string.
        /// </summary>
        /// <param name="data"> data. </param>
        /// <returns>
        ///     hex string.
        /// </returns>
        public string ToString(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return ToString(ms);
            }
        }

        /// <summary>
        ///     Hashes the given stream.
        /// </summary>
        /// <param name="stream"> input. </param>
        /// <returns>
        ///     An uint[].
        /// </returns>
        private uint[] Hash(Stream stream)
        {
            uint[] hash  = new uint[HASH_VALUES] { _h0, _h1, _h2, _h3, _h4, _h5 };
            byte[] block = new byte[BUFFER_SIZE];

            fixed (byte* ptr = block)
            {
                int size;
                while ((size = stream.Read(block, 0, BUFFER_SIZE)) > 0)
                {
                    int offset = 0;
                    while (offset + BLOCK_SIZE < size)
                    {
                        ProcessBlock(hash, ptr + offset, BLOCK_SIZE);
                        offset += BLOCK_SIZE;
                    }
                    ProcessBlock(hash, ptr + offset, size - offset);
                }
            }
            return hash;
        }

        #region mix functions

        /// <summary>
        ///     F 1.
        /// </summary>
        /// <param name="a"> The uint to process. </param>
        /// <param name="b"> The int to process. </param>
        /// <param name="c"> The uint to process. </param>
        /// <returns>
        ///     An uint.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint F1(uint a, uint b, uint c)
        {
            return c ^ ((b ^ a) & c);
        }

        /// <summary>
        ///     F 2.
        /// </summary>
        /// <param name="a"> The uint to process. </param>
        /// <param name="b"> The int to process. </param>
        /// <param name="c"> The uint to process. </param>
        /// <returns>
        ///     An uint.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint F2(uint a, uint b, uint c)
        {
            return a ^ b ^ c;
        }

        /// <summary>
        ///     F 3.
        /// </summary>
        /// <param name="a"> The uint to process. </param>
        /// <param name="b"> The int to process. </param>
        /// <param name="c"> The uint to process. </param>
        /// <returns>
        ///     An uint.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint F3(uint a, uint b, uint c)
        {
            return (a & b) | (a & c) | (b & c);
        }

        /// <summary>
        ///     F 4.
        /// </summary>
        /// <param name="a"> The uint to process. </param>
        /// <param name="b"> The int to process. </param>
        /// <param name="c"> The uint to process. </param>
        /// <returns>
        ///     An uint.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint F4(uint a, uint b, uint c)
        {
            return (a & b) | ((c ^ ~a) & b) | ~c;
        }

        /// <summary>
        ///     R 1.
        /// </summary>
        /// <param name="a"> The uint to process. </param>
        /// <param name="b"> The int to process. </param>
        /// <returns>
        ///     An uint.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint R1(uint a, int b)
        {
            return (a << b) | (a >> (32 - b));
        }

        #endregion
    }
}