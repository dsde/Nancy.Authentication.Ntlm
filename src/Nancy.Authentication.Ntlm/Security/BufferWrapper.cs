﻿namespace Nancy.Authentication.Ntlm.Security
{
    using System;

    public struct BufferWrapper
    {
        public byte[] Buffer;
        public Common.SecurityBufferType BufferType;

        public BufferWrapper(byte[] buffer, Common.SecurityBufferType bufferType)
        {
            if (buffer == null || buffer.Length == 0)
            {
                throw new ArgumentException("buffer cannot be null or 0 length");
            }

            Buffer = buffer;
            BufferType = bufferType;
        }
    };
}
