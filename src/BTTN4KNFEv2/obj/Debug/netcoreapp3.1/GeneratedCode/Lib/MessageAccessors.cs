#pragma warning disable 162,168,649,660,661,1522
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinity.Core.Lib;
using Trinity.Network.Messaging;
using Trinity.Storage;
using Trinity.TSL;
using Trinity.TSL.Lib;
namespace BTTN4KNFE
{
    
    /// <summary>
    /// Represents a read-only accessor on the message of type GetNFECountResponse defined in the TSL protocols.
    /// The message readers will be instantiated by the system and passed to user's logic.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the reader object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// </summary>
    public unsafe sealed class GetNFECountResponseReader : GetNFECountResponse_Accessor, IDisposable
    {
        byte * buffer;
        internal GetNFECountResponseReader(byte* buf, int offset)
            : base(buf + offset
                   )
        {
            buffer = buf;
        }
        
        /// <summary>
        /// Dispose the message reader and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    /// <summary>
    /// Represents a writer accessor on the message of type GetNFECountResponse defined in the TSL protocols.
    /// The message writers should be instantiated by the user's logic and passed to the system to send it out.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the writer object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// </summary>
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// <remarks>Calling <c>Dispose()</c> does not send the message out.</remarks>
    public unsafe sealed class GetNFECountResponseWriter : GetNFECountResponse_Accessor, IDisposable
    {
        internal byte* buffer = null;
        internal int BufferLength;
        internal int Length; 
        public unsafe GetNFECountResponseWriter( long count = default(long) , long rc = default(long) )
            : base(null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            targetPtr += 16;

            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {
            *(long*)targetPtr = count;
            targetPtr += 8;
            *(long*)targetPtr = rc;
            targetPtr += 8;

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
        }
        internal unsafe GetNFECountResponseWriter(int asyncRspHeaderLength,  long count = default(long) , long rc = default(long) )
            : base(null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader + asyncRspHeaderLength;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            targetPtr += 16;

            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {
            *(long*)targetPtr = count;
            targetPtr += 8;
            *(long*)targetPtr = rc;
            targetPtr += 8;

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
        }
        
        /// <summary>
        /// Dispose the message writer and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    
    /// <summary>
    /// Represents a read-only accessor on the message of type SendNFERequest defined in the TSL protocols.
    /// The message readers will be instantiated by the system and passed to user's logic.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the reader object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// </summary>
    public unsafe sealed class SendNFERequestReader : SendNFERequest_Accessor, IDisposable
    {
        byte * buffer;
        internal SendNFERequestReader(byte* buf, int offset)
            : base(buf + offset
                   )
        {
            buffer = buf;
        }
        
        /// <summary>
        /// Dispose the message reader and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    /// <summary>
    /// Represents a writer accessor on the message of type SendNFERequest defined in the TSL protocols.
    /// The message writers should be instantiated by the user's logic and passed to the system to send it out.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the writer object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// </summary>
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// <remarks>Calling <c>Dispose()</c> does not send the message out.</remarks>
    public unsafe sealed class SendNFERequestWriter : SendNFERequest_Accessor, IDisposable
    {
        internal byte* buffer = null;
        internal int BufferLength;
        internal int Length; 
        public unsafe SendNFERequestWriter( long id = default(long) )
            : base(null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            targetPtr += 8;

            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {
            *(long*)targetPtr = id;
            targetPtr += 8;

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
        }
        internal unsafe SendNFERequestWriter(int asyncRspHeaderLength,  long id = default(long) )
            : base(null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader + asyncRspHeaderLength;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            targetPtr += 8;

            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {
            *(long*)targetPtr = id;
            targetPtr += 8;

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
        }
        
        /// <summary>
        /// Dispose the message writer and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    
    /// <summary>
    /// Represents a read-only accessor on the message of type SendNFEResponse defined in the TSL protocols.
    /// The message readers will be instantiated by the system and passed to user's logic.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the reader object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// </summary>
    public unsafe sealed class SendNFEResponseReader : SendNFEResponse_Accessor, IDisposable
    {
        byte * buffer;
        internal SendNFEResponseReader(byte* buf, int offset)
            : base(buf + offset
                   )
        {
            buffer = buf;
        }
        
        /// <summary>
        /// Dispose the message reader and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    /// <summary>
    /// Represents a writer accessor on the message of type SendNFEResponse defined in the TSL protocols.
    /// The message writers should be instantiated by the user's logic and passed to the system to send it out.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the writer object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// </summary>
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// <remarks>Calling <c>Dispose()</c> does not send the message out.</remarks>
    public unsafe sealed class SendNFEResponseWriter : SendNFEResponse_Accessor, IDisposable
    {
        internal byte* buffer = null;
        internal int BufferLength;
        internal int Length; 
        public unsafe SendNFEResponseWriter( long rc = default(long) )
            : base(null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            targetPtr += 8;

            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {
            *(long*)targetPtr = rc;
            targetPtr += 8;

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
        }
        internal unsafe SendNFEResponseWriter(int asyncRspHeaderLength,  long rc = default(long) )
            : base(null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader + asyncRspHeaderLength;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            targetPtr += 8;

            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {
            *(long*)targetPtr = rc;
            targetPtr += 8;

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
        }
        
        /// <summary>
        /// Dispose the message writer and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    
    /// <summary>
    /// Represents a read-only accessor on the message of type GetNFECountRequest defined in the TSL protocols.
    /// The message readers will be instantiated by the system and passed to user's logic.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the reader object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// </summary>
    public unsafe sealed class GetNFECountRequestReader : GetNFECountRequest_Accessor, IDisposable
    {
        byte * buffer;
        internal GetNFECountRequestReader(byte* buf, int offset)
            : base(buf + offset
                   )
        {
            buffer = buf;
        }
        
        /// <summary>
        /// Dispose the message reader and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    /// <summary>
    /// Represents a writer accessor on the message of type GetNFECountRequest defined in the TSL protocols.
    /// The message writers should be instantiated by the user's logic and passed to the system to send it out.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the writer object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// </summary>
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// <remarks>Calling <c>Dispose()</c> does not send the message out.</remarks>
    public unsafe sealed class GetNFECountRequestWriter : GetNFECountRequest_Accessor, IDisposable
    {
        internal byte* buffer = null;
        internal int BufferLength;
        internal int Length; 
        public unsafe GetNFECountRequestWriter( long dummy = default(long) )
            : base(null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            targetPtr += 8;

            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {
            *(long*)targetPtr = dummy;
            targetPtr += 8;

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
        }
        internal unsafe GetNFECountRequestWriter(int asyncRspHeaderLength,  long dummy = default(long) )
            : base(null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader + asyncRspHeaderLength;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            targetPtr += 8;

            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {
            *(long*)targetPtr = dummy;
            targetPtr += 8;

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
        }
        
        /// <summary>
        /// Dispose the message writer and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    
    /// <summary>
    /// Represents a read-only accessor on the message of type GetNFEBatchResponse defined in the TSL protocols.
    /// The message readers will be instantiated by the system and passed to user's logic.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the reader object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// </summary>
    public unsafe sealed class GetNFEBatchResponseReader : GetNFEBatchResponse_Accessor, IDisposable
    {
        byte * buffer;
        internal GetNFEBatchResponseReader(byte* buf, int offset)
            : base(buf + offset
                  
                  , ReaderResizeFunc
                   )
        {
            buffer = buf;
        }
        
        /** 
         * GetNFEBatchResponseReader is not resizable because it may be attached
         * to a buffer passed in from the network layer and we don't know how
         * to resize it.
         */
        static byte* ReaderResizeFunc(byte* ptr, int offset, int delta)
        {
            throw new InvalidOperationException("GetNFEBatchResponseReader is not resizable");
        }
        
        /// <summary>
        /// Dispose the message reader and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    /// <summary>
    /// Represents a writer accessor on the message of type GetNFEBatchResponse defined in the TSL protocols.
    /// The message writers should be instantiated by the user's logic and passed to the system to send it out.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the writer object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// </summary>
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// <remarks>Calling <c>Dispose()</c> does not send the message out.</remarks>
    public unsafe sealed class GetNFEBatchResponseWriter : GetNFEBatchResponse_Accessor, IDisposable
    {
        internal byte* buffer = null;
        internal int BufferLength;
        internal int Length; 
        public unsafe GetNFEBatchResponseWriter( List<long> udids = default(List<long>) )
            : base(null
                  
                  , null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            
            {

if(udids!= null)
{
    targetPtr += udids.Count*8+sizeof(int);
}else
{
    targetPtr += sizeof(int);
}

            }
            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {

if(udids!= null)
{
    *(int*)targetPtr = udids.Count*8;
    targetPtr += sizeof(int);
    for(int iterator_2 = 0;iterator_2<udids.Count;++iterator_2)
    {
            *(long*)targetPtr = udids[iterator_2];
            targetPtr += 8;

    }

}else
{
    *(int*)targetPtr = 0;
    targetPtr += sizeof(int);
}

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
            this.ResizeFunction = WriterResizeFunction;
            
        }
        internal unsafe GetNFEBatchResponseWriter(int asyncRspHeaderLength,  List<long> udids = default(List<long>) )
            : base(null
                  
                  , null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader + asyncRspHeaderLength;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            
            {

if(udids!= null)
{
    targetPtr += udids.Count*8+sizeof(int);
}else
{
    targetPtr += sizeof(int);
}

            }
            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {

if(udids!= null)
{
    *(int*)targetPtr = udids.Count*8;
    targetPtr += sizeof(int);
    for(int iterator_2 = 0;iterator_2<udids.Count;++iterator_2)
    {
            *(long*)targetPtr = udids[iterator_2];
            targetPtr += 8;

    }

}else
{
    *(int*)targetPtr = 0;
    targetPtr += sizeof(int);
}

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
            this.ResizeFunction = WriterResizeFunction;
            
        }
        
        private byte* WriterResizeFunction(byte* ptr, int ptr_offset, int delta)
        {
            int curlen = Length;
            int tgtlen = curlen + delta;
            if (delta >= 0)
            {
                byte* currentBufferPtr = buffer;
                int required_length = (int)(tgtlen + (this.m_ptr - currentBufferPtr));
                if(required_length < curlen) throw new AccessorResizeException("Accessor size overflow.");
                if (required_length <= BufferLength)
                {
                    Memory.memmove(
                        ptr + ptr_offset + delta,
                        ptr + ptr_offset,
                        (ulong)(curlen - (ptr + ptr_offset - this.m_ptr)));
                    Length = tgtlen;
                    return ptr;
                }
                else
                {
                    while (BufferLength < required_length)
                    {
                        if (int.MaxValue - BufferLength >= (BufferLength>>1)) BufferLength += (BufferLength >> 1);
                        else if (int.MaxValue - BufferLength >= (1 << 20)) BufferLength += (1 << 20);
                        else BufferLength = int.MaxValue;
                    }
                    byte* tmpBuffer = (byte*)Memory.malloc((ulong)BufferLength);
                    Memory.memcpy(
                        tmpBuffer,
                        currentBufferPtr,
                        (ulong)(ptr + ptr_offset - currentBufferPtr));
                    byte* newCellPtr = tmpBuffer + (this.m_ptr - currentBufferPtr);
                    Memory.memcpy(
                        newCellPtr + (ptr_offset + delta),
                        ptr + ptr_offset,
                        (ulong)(curlen - (ptr + ptr_offset - this.m_ptr)));
                    Length = tgtlen;
                    this.m_ptr = newCellPtr;
                    Memory.free(buffer);
                    buffer = tmpBuffer;
                    return tmpBuffer + (ptr - currentBufferPtr);
                }
            }
            else
            {
                if (curlen + delta < 0) throw new AccessorResizeException("Accessor target size underflow.");
                Memory.memmove(
                    ptr + ptr_offset,
                    ptr + ptr_offset - delta,
                    (ulong)(Length - (ptr + ptr_offset - delta - this.m_ptr)));
                Length = tgtlen;
                return ptr;
            }
        }
        
        /// <summary>
        /// Dispose the message writer and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    
    /// <summary>
    /// Represents a read-only accessor on the message of type GetNFERequest defined in the TSL protocols.
    /// The message readers will be instantiated by the system and passed to user's logic.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the reader object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// </summary>
    public unsafe sealed class GetNFERequestReader : GetNFERequest_Accessor, IDisposable
    {
        byte * buffer;
        internal GetNFERequestReader(byte* buf, int offset)
            : base(buf + offset
                  
                  , ReaderResizeFunc
                   )
        {
            buffer = buf;
        }
        
        /** 
         * GetNFERequestReader is not resizable because it may be attached
         * to a buffer passed in from the network layer and we don't know how
         * to resize it.
         */
        static byte* ReaderResizeFunc(byte* ptr, int offset, int delta)
        {
            throw new InvalidOperationException("GetNFERequestReader is not resizable");
        }
        
        /// <summary>
        /// Dispose the message reader and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    /// <summary>
    /// Represents a writer accessor on the message of type GetNFERequest defined in the TSL protocols.
    /// The message writers should be instantiated by the user's logic and passed to the system to send it out.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the writer object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// </summary>
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// <remarks>Calling <c>Dispose()</c> does not send the message out.</remarks>
    public unsafe sealed class GetNFERequestWriter : GetNFERequest_Accessor, IDisposable
    {
        internal byte* buffer = null;
        internal int BufferLength;
        internal int Length; 
        public unsafe GetNFERequestWriter( string udid = default(string) )
            : base(null
                  
                  , null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            
            {

        if(udid!= null)
        {
            int strlen_2 = udid.Length * 2;
            targetPtr += strlen_2+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {

        if(udid!= null)
        {
            int strlen_2 = udid.Length * 2;
            *(int*)targetPtr = strlen_2;
            targetPtr += sizeof(int);
            fixed(char* pstr_2 = udid)
            {
                Memory.Copy(pstr_2, targetPtr, strlen_2);
                targetPtr += strlen_2;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
            this.ResizeFunction = WriterResizeFunction;
            
        }
        internal unsafe GetNFERequestWriter(int asyncRspHeaderLength,  string udid = default(string) )
            : base(null
                  
                  , null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader + asyncRspHeaderLength;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            
            {

        if(udid!= null)
        {
            int strlen_2 = udid.Length * 2;
            targetPtr += strlen_2+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {

        if(udid!= null)
        {
            int strlen_2 = udid.Length * 2;
            *(int*)targetPtr = strlen_2;
            targetPtr += sizeof(int);
            fixed(char* pstr_2 = udid)
            {
                Memory.Copy(pstr_2, targetPtr, strlen_2);
                targetPtr += strlen_2;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
            this.ResizeFunction = WriterResizeFunction;
            
        }
        
        private byte* WriterResizeFunction(byte* ptr, int ptr_offset, int delta)
        {
            int curlen = Length;
            int tgtlen = curlen + delta;
            if (delta >= 0)
            {
                byte* currentBufferPtr = buffer;
                int required_length = (int)(tgtlen + (this.m_ptr - currentBufferPtr));
                if(required_length < curlen) throw new AccessorResizeException("Accessor size overflow.");
                if (required_length <= BufferLength)
                {
                    Memory.memmove(
                        ptr + ptr_offset + delta,
                        ptr + ptr_offset,
                        (ulong)(curlen - (ptr + ptr_offset - this.m_ptr)));
                    Length = tgtlen;
                    return ptr;
                }
                else
                {
                    while (BufferLength < required_length)
                    {
                        if (int.MaxValue - BufferLength >= (BufferLength>>1)) BufferLength += (BufferLength >> 1);
                        else if (int.MaxValue - BufferLength >= (1 << 20)) BufferLength += (1 << 20);
                        else BufferLength = int.MaxValue;
                    }
                    byte* tmpBuffer = (byte*)Memory.malloc((ulong)BufferLength);
                    Memory.memcpy(
                        tmpBuffer,
                        currentBufferPtr,
                        (ulong)(ptr + ptr_offset - currentBufferPtr));
                    byte* newCellPtr = tmpBuffer + (this.m_ptr - currentBufferPtr);
                    Memory.memcpy(
                        newCellPtr + (ptr_offset + delta),
                        ptr + ptr_offset,
                        (ulong)(curlen - (ptr + ptr_offset - this.m_ptr)));
                    Length = tgtlen;
                    this.m_ptr = newCellPtr;
                    Memory.free(buffer);
                    buffer = tmpBuffer;
                    return tmpBuffer + (ptr - currentBufferPtr);
                }
            }
            else
            {
                if (curlen + delta < 0) throw new AccessorResizeException("Accessor target size underflow.");
                Memory.memmove(
                    ptr + ptr_offset,
                    ptr + ptr_offset - delta,
                    (ulong)(Length - (ptr + ptr_offset - delta - this.m_ptr)));
                Length = tgtlen;
                return ptr;
            }
        }
        
        /// <summary>
        /// Dispose the message writer and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    
    /// <summary>
    /// Represents a read-only accessor on the message of type GetNFEBatchRequest defined in the TSL protocols.
    /// The message readers will be instantiated by the system and passed to user's logic.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the reader object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// </summary>
    public unsafe sealed class GetNFEBatchRequestReader : GetNFEBatchRequest_Accessor, IDisposable
    {
        byte * buffer;
        internal GetNFEBatchRequestReader(byte* buf, int offset)
            : base(buf + offset
                   )
        {
            buffer = buf;
        }
        
        /// <summary>
        /// Dispose the message reader and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    /// <summary>
    /// Represents a writer accessor on the message of type GetNFEBatchRequest defined in the TSL protocols.
    /// The message writers should be instantiated by the user's logic and passed to the system to send it out.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the writer object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// </summary>
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// <remarks>Calling <c>Dispose()</c> does not send the message out.</remarks>
    public unsafe sealed class GetNFEBatchRequestWriter : GetNFEBatchRequest_Accessor, IDisposable
    {
        internal byte* buffer = null;
        internal int BufferLength;
        internal int Length; 
        public unsafe GetNFEBatchRequestWriter( long batchindex = default(long) , long batchsize = default(long) )
            : base(null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            targetPtr += 16;

            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {
            *(long*)targetPtr = batchindex;
            targetPtr += 8;
            *(long*)targetPtr = batchsize;
            targetPtr += 8;

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
        }
        internal unsafe GetNFEBatchRequestWriter(int asyncRspHeaderLength,  long batchindex = default(long) , long batchsize = default(long) )
            : base(null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader + asyncRspHeaderLength;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            targetPtr += 16;

            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {
            *(long*)targetPtr = batchindex;
            targetPtr += 8;
            *(long*)targetPtr = batchsize;
            targetPtr += 8;

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
        }
        
        /// <summary>
        /// Dispose the message writer and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    
    /// <summary>
    /// Represents a read-only accessor on the message of type GetNFEResponse defined in the TSL protocols.
    /// The message readers will be instantiated by the system and passed to user's logic.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the reader object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// </summary>
    public unsafe sealed class GetNFEResponseReader : GetNFEResponse_Accessor, IDisposable
    {
        byte * buffer;
        internal GetNFEResponseReader(byte* buf, int offset)
            : base(buf + offset
                   )
        {
            buffer = buf;
        }
        
        /// <summary>
        /// Dispose the message reader and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    /// <summary>
    /// Represents a writer accessor on the message of type GetNFEResponse defined in the TSL protocols.
    /// The message writers should be instantiated by the user's logic and passed to the system to send it out.
    /// After finished accessing the message. It is the user's responsibility to call Dispose()
    /// on the writer object. Recommend wrapping the reader with a <c>using Statement block</c>.
    /// </summary>
    /// <seealso ref="https://msdn.microsoft.com/en-us/library/yh598w02.aspx"/>
    /// <remarks>Calling <c>Dispose()</c> does not send the message out.</remarks>
    public unsafe sealed class GetNFEResponseWriter : GetNFEResponse_Accessor, IDisposable
    {
        internal byte* buffer = null;
        internal int BufferLength;
        internal int Length; 
        public unsafe GetNFEResponseWriter( long id = default(long) , long rc = default(long) )
            : base(null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            targetPtr += 16;

            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {
            *(long*)targetPtr = id;
            targetPtr += 8;
            *(long*)targetPtr = rc;
            targetPtr += 8;

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
        }
        internal unsafe GetNFEResponseWriter(int asyncRspHeaderLength,  long id = default(long) , long rc = default(long) )
            : base(null
                   )
        {
            int preservedHeaderLength = TrinityProtocol.MsgHeader + asyncRspHeaderLength;
            
            byte* targetPtr;
            
            targetPtr = (byte*)preservedHeaderLength;
            targetPtr += 16;

            byte* tmpcellptr = (byte*)Memory.malloc((ulong)targetPtr);
            {
                BufferLength     = (int)targetPtr;
                Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
                targetPtr = tmpcellptr;
                tmpcellptr += preservedHeaderLength;
                targetPtr  += preservedHeaderLength;
                
            {
            *(long*)targetPtr = id;
            targetPtr += 8;
            *(long*)targetPtr = rc;
            targetPtr += 8;

            }
            }
            
            buffer = tmpcellptr - preservedHeaderLength;
            this.m_ptr = buffer + preservedHeaderLength;
            Length = BufferLength - preservedHeaderLength;
            
        }
        
        /// <summary>
        /// Dispose the message writer and release the memory resource.
        /// It is the user's responsibility to call this method after finished accessing the message.
        /// </summary>
        public void Dispose()
        {
            Memory.free(buffer);
            buffer = null;
        }
    }
    
}

#pragma warning restore 162,168,649,660,661,1522
